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
        public States(TuringMachineSetup setupForm)
        {
            this.setupForm = setupForm;
            stateList = new List<string>();
            StatesDictionary = new Dictionary<string, Dictionary<char, Transition>>();
            InitializeComponent();
        }

        public void InitializeForm()
        {
            //todo : fix
            // clear out table
            foreach (DataGridViewRow row in transitionTable.Rows)
            {
                transitionTable.Rows.Remove(row);
            }
            foreach (DataGridViewColumn col in transitionTable.Columns)
            {
                transitionTable.Columns.Remove(col);
            }
            // remove previous values
            cboAlphabet.Items.Clear();
            lstAlphabet.Items.Clear();
            // grab alphabet, populate list and combo box with the results
            List<char> alphabet = setupForm.alphabetSetupForm.Alphabet;
            foreach (char item in alphabet)
            {
                cboAlphabet.Items.Add(item);
                lstAlphabet.Items.Add(item);
                transitionTable.Columns.Add(item.ToString(), item.ToString());
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
            int numberToReach = (lstAlphabet.Items.Count == 0 ? 1 : lstAlphabet.Items.Count) * (lstStates.Items.Count == 0 ? 1 : lstStates.Items.Count);
            int currentNumber = StatesDictionary.Values.Sum(item => item.Values.Count);
            if (numberToReach == currentNumber)
            {
                // we have all values we need
                setupForm.ChangeStateLabel(true);
            }
            else
            {
                // we don't have all values we need
                setupForm.ChangeStateLabel(false);
            }
            setupForm.Show();
            this.Hide();
        }

        private void btnAddNewState_Click(object sender, EventArgs e)
        {
            string inputText = txtAddNewState.Text;

            // if the text is of alteast length one, and it doesn't already exits, add it to the lists
            if (inputText.Length > 0 && !stateList.Contains(inputText))
            {
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
            int selectedIndex = this.lstStates.SelectedIndex;
            if(selectedIndex >= 0)
            {

                string selectedItem = lstStates.Text;
                // remove from list
                lstStates.Items.RemoveAt(selectedIndex);
                // remove from gloabl list of strings for states and dictionary
                StatesDictionary.Remove(selectedItem);
                stateList.Remove(selectedItem);
                // remove from combobox
                cboState.Items.Remove(selectedItem);
                // remove the row in the data grid
                transitionTable.Rows.RemoveAt(selectedIndex);
            }
            
        }

        private void btnUpdateState_Click(object sender, EventArgs e)
        {
            // first make sure all inputes are valid
            bool left = radioLeft.Checked;
            bool right = radioRight.Checked;
            int state = cboState.SelectedIndex;
            int alph = cboAlphabet.SelectedIndex;
            if (alph < 0 || state < 0 || (left && right))
            {
                return;
            }
            // update state dictionary with the new transition for this alphabet letter
            Transition newTrans = new Transition
                {
                    MovementDirection =
                        left
                            ? TuringMachineSettings.TransistionDirection.Left
                            : TuringMachineSettings.TransistionDirection.Right,
                    NextState = new State{StateName = cboState.Text},
                    WriteChar = Char.Parse(cboAlphabet.Text)
                };

            if (!StatesDictionary[cboState.Text].ContainsKey(char.Parse(lstAlphabet.SelectedItem.ToString())))
            {
                StatesDictionary[cboState.Text].Add(char.Parse(lstAlphabet.SelectedItem.ToString()), newTrans);
            }
            else
            {
                // else just update the value
                StatesDictionary[cboState.Text][char.Parse(lstAlphabet.SelectedItem.ToString())] = newTrans;
            }
            // add to gridview
            transitionTable[lstAlphabet.SelectedIndex, lstStates.SelectedIndex].Value = newTrans.WriteChar + ", " + (newTrans.MovementDirection == TuringMachineSettings.TransistionDirection.Left ? "Left, " : "Right, ") + newTrans.NextState.StateName;
        }
    }
}
