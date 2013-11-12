using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TileSetGenerator
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnTuring_Click(object sender, EventArgs e)
        {
            this.Hide();
            var turing = new TuringSetup1();
            turing.Show();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            this.Hide();
            var square = new SquareSetup1();
            square.Show();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            this.Hide();
            var rectangle = new RectangleSetup1();
            rectangle.Show();
        }
    }
}
