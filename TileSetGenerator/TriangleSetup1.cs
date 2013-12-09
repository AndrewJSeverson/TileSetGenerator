using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TileSetGenerator.GlobalClasses;

namespace TileSetGenerator
{
    public partial class TriangleSetup1 : Form
    {
        private readonly Menu menuForm;

        public TriangleSetup1(Menu menuForm)
        {
            this.Closing += new CancelEventHandler(this.form1_Closing);
            this.menuForm = menuForm;
            InitializeComponent();
        }

        private void btnGenerateTiangleSet_Click(object sender, EventArgs e)
        {
            // first check the input and make sure a valid height was probided
            // height must be at least 8

            string inputHeight = txtTriangleHeight.Text;
            int height;
            if (!int.TryParse(inputHeight, out height))
            {
                // not an integer, return
                MessageBox.Show("Please probide a intger value of at least value 11");
                return;
            }
            // height must be an off number
            if (height%2 == 0)
            {
                MessageBox.Show("Please probide an odd number height");
                return;
            }
            if (height < 11)
            {
                // height not large enough, return
                MessageBox.Show("Please probide a intger value of at least value 11");
                return;
            }

            // we have a valid height, we can now start to generate the tiles
            
            // figure out how many seed tiles we need
            int k = (int) Math.Ceiling((Math.Log(height)/Math.Log(2)));
            int maxBit = ((int) Math.Pow(2, k)/2);
            int heightToReach = (height - (2*k) - 1)/2;
            int numberToStartAt = maxBit - heightToReach;

            char[] binaryNumber = new char[k];
            // add binary number
            for (int i = k; i > 0; i --)
            {
                int bitNumber = (int)Math.Pow(2, i-1);
                if (numberToStartAt >= bitNumber)
                {
                    binaryNumber[i-1] = '1';
                    numberToStartAt -= bitNumber;
                }
                else
                {
                    binaryNumber[i-1] = '0';
                }
            }

            BinaryCounter counter = new BinaryCounter(binaryNumber.ToList());
            // get binary counter tiles
            List<Tile> generatedTiles = counter.GenerateBinaryCounter();
            // get triangle contant tiles
            List<Tile> triangleConst = generateConstantTiles();
            // add tiles together
            foreach (var tile in triangleConst)
            {
                generatedTiles.Add(tile);
            }

            // print out default left facing tile set
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(Environment.CurrentDirectory + "/Triangle_Left_" + txtTriangleHeight.Text + ".tds"))
            {
                foreach (Tile tile in generatedTiles)
                {
                    file.Write(tile.PrintTile());
                }
            }

            // print out right facing tile set
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(Environment.CurrentDirectory + "/Triangle_Right_" + txtTriangleHeight.Text + ".tds"))
            {
                foreach (Tile tile in HelperMethods.FlipTileSetVertically(generatedTiles))
                {
                    file.Write(tile.PrintTile());
                }
            }

            // print out south facing tile set
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(Environment.CurrentDirectory + "/Triangle_South_" + txtTriangleHeight.Text + ".tds"))
            {
                foreach (Tile tile in HelperMethods.FlipTileSetVHorizontally(generatedTiles))
                {
                    file.Write(tile.PrintTile());
                }
            }

            // print out 90 degree counterclockwise rotated tile set
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(Environment.CurrentDirectory + "/Triangle_90_rotated_" + txtTriangleHeight.Text + ".tds"))
            {
                foreach (Tile tile in HelperMethods.FlipTileSet90Degrees(generatedTiles))
                {
                    file.Write(tile.PrintTile());
                }
            }

            MessageBox.Show("Tile set created");
        }

        private List<Tile> generateConstantTiles()
        {
            List<Tile> tiles = new List<Tile>();

            Tile XSA = new Tile
            {
                TN = "XSA",
                L = "X",
                NB = 2,
                EB = 1,
                SB = 0,
                WB = 0,
                NL = "vS",
                EL = "#",
                SL = "",
                WL = "",
            };
            tiles.Add(XSA);

            Tile XSB = new Tile
            {
                TN = "XSB",
                L = "X",
                NB = 1,
                EB = 1,
                SB = 2,
                WB = 1,
                NL = "",
                EL = "-",
                SL = "vS",
                WL = "#",
            };
            tiles.Add(XSB);

            Tile XFillSouth = new Tile
            {
                TN = "XFillSouth",
                L = "X",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "",
                EL = "-",
                SL = "",
                WL = "-",
            };
            tiles.Add(XFillSouth);

            Tile XW0A = new Tile
            {
                TN = "XW0A",
                L = "X",
                NB = 1,
                EB = 2,
                SB = 0,
                WB = 0,
                NL = "#",
                EL = "<S",
                SL = "",
                WL = "",
            };
            tiles.Add(XW0A);

            Tile XW0B = new Tile
            {
                TN = "XW0B",
                L = "X",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 2,
                NL = "",
                EL = "#0",
                SL = "#",
                WL = "<S",
            };
            tiles.Add(XW0B);

            Tile XFillWest0 = new Tile
            {
                TN = "XFillWest0",
                L = "X",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "",
                EL = "#0",
                SL = "",
                WL = "#0",
            };
            tiles.Add(XFillWest0);

            Tile MiddleTipRow = new Tile
            {
                TN = "MiddleTipRow",
                L = "X",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "",
                EL = "y",
                SL = "",
                WL = "x",
            };
            tiles.Add(MiddleTipRow);

            Tile MiddleTurn = new Tile
            {
                TN = "MiddleTurn",
                L = "X",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "",
                EL = "c",
                SL = "*0",
                WL = "x",
            };
            tiles.Add(MiddleTurn);

            Tile MiddleTip0 = new Tile
            {
                TN = "MiddleTip0",
                L = "X",
                NB = 2,
                EB = 1,
                SB = 1,
                WB = 2,
                NL = "S^",
                EL = "x",
                SL = "#",
                WL = "TT",
            };
            tiles.Add(MiddleTip0);

            Tile MiddleTip1 = new Tile
            {
                TN = "MiddleTip1",
                L = "X",
                NB = 2,
                EB = 1,
                SB = 1,
                WB = 2,
                NL = "S^",
                EL = "y",
                SL = "#",
                WL = "TT",
            };
            tiles.Add(MiddleTip1);

            Tile MiddleTop1 = new Tile
            {
                TN = "MiddleTop1",
                L = "X",
                NB = 0,
                EB = 2,
                SB = 0,
                WB = 0,
                NL = "",
                EL = "TT",
                SL = "",
                WL = "",
            };
            tiles.Add(MiddleTop1);


            Tile MiddleTipRow2 = new Tile
            {
                TN = "MiddleTipRow(2)",
                L = "X",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "",
                EL = "x",
                SL = "",
                WL = "y",
            };
            tiles.Add(MiddleTipRow2);

            Tile XNA = new Tile
            {
                TN = "XNA",
                L = "X",
                NB = 1,
                EB = 1,
                SB = 2,
                WB = 0,
                NL = "",
                EL = "#",
                SL = "S^",
                WL = "",
            };
            tiles.Add(XNA);

            Tile XNB = new Tile
            {
                TN = "XNB",
                L = "X",
                NB = 2,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "S^",
                EL = "u",
                SL = "",
                WL = "#",
            };
            tiles.Add(XNB);

            Tile XNA2 = new Tile
            {
                TN = "XNA(2)",
                L = "X",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "",
                EL = "#",
                SL = "0",
                WL = "u",
            };
            tiles.Add(XNA2);

            Tile XNB2 = new Tile
            {
                TN = "XNB(2)",
                L = "X",
                NB = 2,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "S^",
                EL = "u",
                SL = "0",
                WL = "#",
            };
            tiles.Add(XNB2);

            Tile XNB22 = new Tile
            {
                TN = "XNB(2)(2)",
                L = "X",
                NB = 2,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "S^",
                EL = "u",
                SL = "0*",
                WL = "#",
            };
            tiles.Add(XNB22);

            Tile XNA22 = new Tile
            {
                TN = "XNA(2)(2)",
                L = "X",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "",
                EL = "#",
                SL = "0*",
                WL = "u",
            };
            tiles.Add(XNA22);

            Tile haha = new Tile
            {
                TN = "haha",
                L = "X",
                NB = 2,
                EB = 1,
                SB = 1,
                WB = 2,
                NL = "S^",
                EL = "y",
                SL = "#*",
                WL = "TT",
            };
            tiles.Add(haha);

            Tile NorthFill = new Tile
            {
                TN = "North Fill",
                L = "X",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "",
                EL = "u",
                SL = "",
                WL = "u",
            };
            tiles.Add(NorthFill);

            return tiles;
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            menuForm.Show();
            this.Hide();
        }

        // Closes the program on close
        private void form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }
    }
}
