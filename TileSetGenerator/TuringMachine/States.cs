using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TileSetGenerator.TuringMachine.Classes;

namespace TileSetGenerator.TuringMachine
{
    public partial class States : Form
    {
        private readonly TuringMachineSetup setupForm;
        private List<string> stateList { get; set; }
        public Dictionary<string, Dictionary<char, Transition>> StatesDictionary { get; set; }
        public State StartingState { get; set; }
        public States(TuringMachineSetup setupForm)
        {
            this.Closing += new CancelEventHandler(this.form1_Closing);
            this.setupForm = setupForm;
            stateList = new List<string>();
            StatesDictionary = new Dictionary<string, Dictionary<char, Transition>>();
            InitializeComponent();
            // add the halting state to the combo state box select
            cboState.Items.Add("halt");
        }

        public void InitializeForm()
        {
            // grab alphabet, populate list and combo box with the results if it has not already happened
            if (!(lstAlphabet.Items.Count > 0))
            {
                var alphabet = setupForm.alphabetSetupForm.Alphabet;
                foreach (var item in alphabet)
                {
                    cboAlphabet.Items.Add(item);
                    lstAlphabet.Items.Add(item);
                    transitionTable.Columns.Add(item.ToString(), item.ToString());
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setupForm.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // we want to check and see if there is a value for each state and alphabet number
            var numberToReach = (lstAlphabet.Items.Count == 0 ? 1 : lstAlphabet.Items.Count) * (lstStates.Items.Count == 0 ? 1 : lstStates.Items.Count);
            var currentNumber = StatesDictionary.Values.Sum(item => item.Values.Count);
            setupForm.ChangeStateLabel(numberToReach == currentNumber);
            setupForm.Show();
            this.Hide();
        }

        private void btnAddNewState_Click(object sender, EventArgs e)
        {
            var inputText = txtAddNewState.Text;

            // if the text is of alteast length one, and it doesn't already exits, add it to the lists
            if (inputText.Length > 0 && !stateList.Contains(inputText))
            {
                // if this is the first state being added, make it the starting state
                if (stateList.Count == 0)
                {
                    lblStartingState.Text = inputText;
                    StartingState = new State {StateName = inputText};
                }
                cboState.Items.Add(inputText);
                lstStates.Items.Add(inputText);
                // add new state to state list and dictionary
                stateList.Add(inputText);
                StatesDictionary.Add(inputText, new Dictionary<char, Transition>());
                // add new row to table
                transitionTable.Rows.Add();
                transitionTable.Rows[stateList.IndexOf(inputText)].HeaderCell.Value = inputText;
            }
            txtAddNewState.Text = "";
        }

        private void btnRemoveState_Click(object sender, EventArgs e)
        {
            var selectedIndex = this.lstStates.SelectedIndex;
            if (selectedIndex < 0) return;
            var selectedItem = lstStates.Text;
            // remove from list
            lstStates.Items.RemoveAt(selectedIndex);
            // remove from gloabl list of strings for states and dictionary
            StatesDictionary.Remove(selectedItem);
            stateList.Remove(selectedItem);
            // remove from combobox
            cboState.Items.Remove(selectedItem);
            // remove the row in the data grid
            transitionTable.Rows.RemoveAt(selectedIndex);
            // if we are removing the state that is the current starting state, reset starting state
            if (lblStartingState.Text == selectedItem)
            {
                lblStartingState.Text = "";
                StartingState = null;
            }
        }

        private void btnUpdateState_Click(object sender, EventArgs e)
        {
            // first make sure all inputes are valid
            var left = radioLeft.Checked;
            var right = radioRight.Checked;
            var state = cboState.SelectedIndex;
            var alph = cboAlphabet.SelectedIndex;
            if (alph < 0 || state < 0 || (left && right))
            {
                return;
            }
            // update state dictionary with the new transition for this alphabet letter
            var newTrans = new Transition
                {
                    MovementDirection =
                        left
                            ? TuringMachineSettings.TransistionDirection.Left
                            : TuringMachineSettings.TransistionDirection.Right,
                    NextState = new State{StateName = cboState.Text},
                    WriteChar = Char.Parse(cboAlphabet.Text)
                };

            if (!StatesDictionary[lstStates.SelectedItem.ToString()].ContainsKey(char.Parse(lstAlphabet.SelectedItem.ToString())))
            {
                StatesDictionary[lstStates.SelectedItem.ToString()].Add(char.Parse(lstAlphabet.SelectedItem.ToString()), newTrans);
            }
            else
            {
                // else just update the value
                StatesDictionary[lstStates.SelectedItem.ToString()][char.Parse(lstAlphabet.SelectedItem.ToString())] = newTrans;
            }
            // add to gridview
            transitionTable[lstAlphabet.SelectedIndex, lstStates.SelectedIndex].Value = newTrans.WriteChar + ", " + (newTrans.MovementDirection == TuringMachineSettings.TransistionDirection.Left ? "Left, " : "Right, ") + newTrans.NextState.StateName;
            // if the state being added in going to a halting state, show that
            if (newTrans.NextState.StateName == "halt")
            {
                transitionTable[lstAlphabet.SelectedIndex, lstStates.SelectedIndex].Value = "HALT";
            }
        }

        private void transitionTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = transitionTable.CurrentCell.RowIndex;
            int columnindex = transitionTable.CurrentCell.ColumnIndex;
            string row = transitionTable.CurrentCell.OwningRow.HeaderCell.Value.ToString();
            string column = transitionTable.CurrentCell.OwningColumn.HeaderText;

            lstAlphabet.SelectedIndex = columnindex;
            lstStates.SelectedIndex = rowindex;
            Dictionary<char, Transition> state = StatesDictionary[row];
            if (!state.ContainsKey(Char.Parse(column)))
            {
                return;
            }
            Transition current = state[Char.Parse(column)];
            cboAlphabet.Text = current.WriteChar.ToString();
            cboState.Text = current.NextState.StateName;
            radioLeft.Checked = current.MovementDirection == TuringMachineSettings.TransistionDirection.Left;
            radioRight.Checked = current.MovementDirection == TuringMachineSettings.TransistionDirection.Right;
        }

        private void btnUpdateStartingState_Click(object sender, EventArgs e)
        {
            var selectedIndex = this.lstStates.SelectedIndex;
            if (selectedIndex < 0) return;
            var selectedItem = lstStates.Text;
            lblStartingState.Text = selectedItem;
            StartingState = new State {StateName = selectedItem};
        }

        // Closes the program on close
        private void form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }
    }
}
