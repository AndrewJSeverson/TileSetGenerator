using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TileSetGenerator.TuringMachine
{
    public partial class StartingString : Form
    {
        private readonly TuringMachineSetup setupForm;
        public List<char> StartingStringList { get; set; }
        public int StartingIndex { get; set; }
        public StartingString(TuringMachineSetup setupForm)
        {
            StartingIndex = -1;
            StartingStringList = new List<char>();
            this.setupForm = setupForm;
            InitializeComponent();
        }

        // public method to populate list with the most current alphabet
        public void FillWithCurrentAlphabet()
        {
            // clear out previous letters, add current one
            listAlphabet.Items.Clear();
            foreach (var item in setupForm.alphabetSetupForm.Alphabet)
            {
                listAlphabet.Items.Add(item);
            }
        }

        public bool IsStartingStringComplete()
        {
            return StartingStringList.Count > 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // clear out old list
            StartingStringList.Clear();
            // save current start string into global start string
            foreach (var item in txtStartingString.Text.ToCharArray())
            {
                StartingStringList.Add(item);
            }
            // check starting index and make sure it is valid
            int startingIndex;
            if (int.TryParse(txtStartingIndex.Text, out startingIndex))
            {
                // valid int, assign it to the gloab variable
                StartingIndex = startingIndex;
            }
            // if the list has at least one item in it, we are can set this setup as done
            if (StartingStringList.Count > 0 && StartingIndex >= 0 && StartingIndex < StartingStringList.Count)
            {
                setupForm.ChangeStartStringLabel(true);
            }
            else
            {
                setupForm.ChangeStartStringLabel(false);
            }
            backToSetup();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            backToSetup();
        }

        private void backToSetup()
        {
            setupForm.Show();
            this.Hide();
        }

        private void btnAddCharToString_Click(object sender, EventArgs e)
        {
            string current = txtStartingString.Text;
            // make sure something is selected in the list
            if (listAlphabet.SelectedIndex >= 0)
            {
                // add item start string
                txtStartingString.Text = current + listAlphabet.SelectedItem;
            }
        }

        private void btnRemoveLast_Click(object sender, EventArgs e)
        {
            // remove the last added item to the string
            string current = txtStartingString.Text;
            if (current.Length > 0)
            {
                txtStartingString.Text = current.Substring(0, current.Length - 1);
            }
        }
    }
}
