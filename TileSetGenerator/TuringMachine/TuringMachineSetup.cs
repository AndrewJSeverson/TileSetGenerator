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
    public partial class TuringMachineSetup : Form
    {
        private readonly Menu menuForm;
        public readonly AlphabetSetup alphabetSetupForm;
        public readonly StartingString startingStringFrom;
        public readonly States statesSetupForm;
        public TuringMachineSetup(Menu menuForm)
        {
            this.menuForm = menuForm;
            alphabetSetupForm = new AlphabetSetup(this);
            startingStringFrom = new StartingString(this);
            statesSetupForm = new States(this);
            InitializeComponent();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            menuForm.Show();
            this.Hide();
        }

        private void btnOpenAlphabetSetup_Click(object sender, EventArgs e)
        {
            alphabetSetupForm.Show();
            this.Hide();
        }

        private void btnOpenStartStringSetup_Click(object sender, EventArgs e)
        {
            startingStringFrom.Show();
            this.Hide();
            // fill alphabet list with most current
            startingStringFrom.FillWithCurrentAlphabet();
        }

        private void btnOpenStatesSetup_Click(object sender, EventArgs e)
        {
           statesSetupForm.Show();
            this.Hide();
            // populate fiels for form
            statesSetupForm.InitializeForm();
        }

        // public functions to change colors of labels as they get completed
        public void ChangeAlphabetLabel(bool isComplete)
        {
            lblAlphabetSetup.BackColor = isComplete ? Color.Green : Color.Red;
        }

        public void ChangeStartStringLabel(bool isComplete)
        {
            lblStartStringSetup.BackColor = isComplete ? Color.Green : Color.Red;
        }

        public void ChangeStateLabel(bool isComplete)
        {
            lblStateSetup.BackColor = isComplete ? Color.Green : Color.Red;
        }
    }
}
