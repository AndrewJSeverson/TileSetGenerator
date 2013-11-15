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
    public partial class AlphabetSetup : Form
    {
        private readonly TuringMachineSetup setupForm;
        // public list of the current alphabet
        public List<char> Alphabet { get; set; } 
        public AlphabetSetup(TuringMachineSetup setupForm)
        {
            this.setupForm = setupForm;
            InitializeComponent();
            Alphabet = new List<char>();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            backToSetup();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // clear out current list of item
            Alphabet.Clear();
            // loop over all items in list and add to alphabet list
            foreach (var item in listAlphabet.Items)
            {
                Alphabet.Add(Char.Parse(item.ToString()));
            }
            // if the list has at least one item in it, we are can set this setup as done
            if (Alphabet.Count > 0)
            {
                setupForm.ChangeAlphabetLabel(true);
            }
            else
            {
                setupForm.ChangeAlphabetLabel(false);
            }
            backToSetup();
        }

        private void backToSetup()
        {
            setupForm.Show();
            this.Hide();
        }

        private void btnRemoveChar_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.listAlphabet.SelectedIndex;
            if(selectedIndex >= 0)
            {
                listAlphabet.Items.RemoveAt(selectedIndex);
            }
        }

        private void txtNewChar_KeyUp(object sender, KeyEventArgs e)
        {
            // we only want single character input for the alphabet, anything else should be removed
            string currentInput = txtNewChar.Text;

            if (currentInput.Length > 1)
            {
                // just return the first char in the string
                txtNewChar.Text = currentInput.Substring(0, 1);
            }
        }

        private void btnAddChar_Click(object sender, EventArgs e)
        {
            string charToAdd = txtNewChar.Text;
            // only add if the char is of length 1
            if(charToAdd.Length == 1)
            {
                listAlphabet.Items.Add(charToAdd);
                // clear out text box
                txtNewChar.Text = "";
            }
        }

        public bool IsAlphabetComplete()
        {
            return Alphabet.Count > 0;
        }
    }
}
