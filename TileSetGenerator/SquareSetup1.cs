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
    public partial class SquareSetup1 : Form
    {
        private readonly Menu menuForm;

        public SquareSetup1(Menu menuForm)
        {
            this.Closing += new CancelEventHandler(this.form1_Closing);
            this.menuForm = menuForm;
            InitializeComponent();
        }

        // Back to Menu button click binding
        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            menuForm.Show();
            this.Hide();
        }

        // Generate tileset file click binding
        private void btnGenerateSquareSet_Click(object sender, EventArgs e)
        {
            int n;
            string message = String.Empty;

            if (int.TryParse(sizeInput.Text, out n) && n > 0)
            {
                if (nSquared.Checked)
                {
                    writeTdsFile(generateNSquared(n, 2), n + "x" + n + "-NSquared-Square");
                    message += n + "x" + n + "-NSquared-Square.tds ";
                }
                if (nComb.Checked)
                {
                    writeTdsFile(generateNComb(n, 2), n + "x" + n + "-NComb-Square");
                    message += n + "x" + n + "-NComb-Square.tds ";
                }
                if (nL.Checked)
                {
                    writeTdsFile(generateNL(n), n + "x" + n + "-NL-Square");
                    message += n + "x" + n + "-NL-Square.tds ";
                }
                if (logN.Checked)
                {
                    writeTdsFile(generateLogN(n), n + "x" + n + "-LogN-Square");
                    message += n + "x" + n + "-LogN-Square.tds ";
                }

                if (!message.Equals(String.Empty))
                {
                    message = "File(s) created: " + message;
                    MessageBox.Show(message);
                }
            }
        }

        /*
         * 
         *          PRIVATES
         * 
         */
        // Makes an N^2 style square where each tile has one and only one place in the square
        private List<Tile> generateNSquared(int n, int temperature)
        {
            var tiles = new List<Tile>();
            String currentTileName, northName, eastName, southName, westName;

            // Build all n^2 tiles one at a time
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    currentTileName = x + "" + y;
                    northName = x + "" + (y + 1);
                    eastName = (x + 1) + "" + y;
                    southName = x + "" + (y - 1);
                    westName = (x - 1) + "" + y;

                    tiles.Add(new Tile 
                    { 
                        TN = currentTileName,
                        L = currentTileName,
                        NL = currentTileName + northName,
                        EL = currentTileName + eastName,
                        SL = southName + currentTileName,
                        WL = westName + currentTileName,
                        NB = y == (n - 1) ? 0 : temperature,
                        EB = x == (n - 1) ? 0 : temperature,
                        SB = y == 0 ? 0 : temperature,
                        WB = x == 0 ? 0 : temperature
                    });
                }
            }

            return tiles;
        }

        // Makes an O(N) tileset with a seed row on the x axis and "fingers" that grow up from the seed row
        private List<Tile> generateNComb(int n, int temperature)
        {
            var tiles = new List<Tile>();
            String currentTileName, northLabel, southLabel, eastLabel, westLabel;

            // Fingers
            for (int i = 1; i < n; i++)
            {
                currentTileName = i.ToString();
                northLabel = i.ToString();
                southLabel = (i - 1).ToString();
                eastLabel = "";
                westLabel = "";

                tiles.Add(new Tile
                {
                    TN = currentTileName,
                    L = currentTileName,
                    NL = northLabel,
                    EL = eastLabel,
                    SL = southLabel,
                    WL = westLabel,
                    NB = temperature,
                    EB = 0,
                    SB = temperature,
                    WB = 0
                });
            }

            // Seed Row
            for (int i = 0; i < n; i++)
            {
                currentTileName = "s" + i;
                northLabel = "0";
                southLabel = "";
                westLabel = i + "" + i;
                eastLabel = (i + 1) + "" + (i + 1);

                tiles.Add(new Tile
                {
                    TN = currentTileName,
                    L = currentTileName,
                    NL = northLabel,
                    EL = eastLabel,
                    SL = southLabel,
                    WL = westLabel,
                    NB = temperature,
                    EB = temperature,
                    SB = 0,
                    WB = temperature
                });
            }

            return tiles;
        }

        // Makes an O(N) tileset that constructs the Y and X axis and fills in the first quadrant
        private List<Tile> generateNL(int n)
        {
            var tiles = new List<Tile>();
            String xTileName, yTileName, fillLabel = "+";

            // Add the Filler tile
            tiles.Add(new Tile
            {
                TN = "f",
                L = "f",
                NL = fillLabel,
                EL = fillLabel,
                SL = fillLabel,
                WL = fillLabel,
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 1
            });

            // Add the Seed tile
            tiles.Add(new Tile
            {
                TN = "s",
                L = "s",
                NL = "0",
                EL = "0",
                SL = "",
                WL = "",
                NB = 2,
                EB = 2,
                SB = 0,
                WB = 0
            });

            // Add the axes
            for (int i = 1; i < n; i++)
            {
                xTileName = "x" + i;
                yTileName = "y" + i;

                // x-axis
                tiles.Add(new Tile
                {
                    TN = xTileName,
                    L = xTileName,
                    NL = fillLabel,
                    EL = i.ToString(),
                    SL = "",
                    WL = (i - 1).ToString(),
                    NB = 1,
                    EB = 2,
                    SB = 0,
                    WB = 2
                });

                // y-axis
                tiles.Add(new Tile
                {
                    TN = yTileName,
                    L = yTileName,
                    NL = i.ToString(),
                    EL = fillLabel,
                    SL = (i - 1).ToString(),
                    WL = "",
                    NB = 2,
                    EB = 1,
                    SB = 2,
                    WB = 0
                });
            }

            return tiles;
        }

        // Makes a O(logN) tileset that makes a square from a binary counter
        private List<Tile> generateLogN(int n)
        {
            if (n < 4)
            {
                return generateNComb(n, 2);
            }

            List<Tile> tiles;
            var k = (int)Math.Ceiling((Math.Log(n) / Math.Log(2)));

            var offset = 1 + k;
            var startingNumber = (int)(Math.Pow(2, k)) - n + offset;
            var startString = makeBinary(startingNumber, k);

            tiles = new BinaryCounter(startString).GenerateBinaryCounterForSquare();

            // Add the Filler tiles
            tiles.Add(new Tile
            {
                TN = "f+",
                L = "f+",
                NL = "",
                EL = "+",
                SL = "",
                WL = "+",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 1
            });
            tiles.Add(new Tile
            {
                TN = "f-",
                L = "f-",
                NL = "",
                EL = "-",
                SL = "",
                WL = "-",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 1
            });

            // Add a/b tiles
            tiles.Add(new Tile
            {
                TN = "A",
                L = "A",
                NL = "#",
                EL = "-",
                SL = "",
                WL = "#",
                NB = 2,
                EB = 1,
                SB = 1,
                WB = 1
            });
            tiles.Add(new Tile
            {
                TN = "B",
                L = "B",
                NL = "",
                EL = "#",
                SL = "#",
                WL = "+",
                NB = 1,
                EB = 1,
                SB = 2,
                WB = 1
            }); tiles.Add(new Tile
            {
                TN = "a",
                L = "a",
                NL = "#",
                EL = "-",
                SL = "",
                WL = "#",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 2
            });
            tiles.Add(new Tile
            {
                TN = "b",
                L = "b",
                NL = "",
                EL = "#",
                SL = "#",
                WL = "+",
                NB = 1,
                EB = 2,
                SB = 1,
                WB = 1
            });

            return tiles;
        }

        // Makes a tileset like the binary counter one but with OPTIMAL ENCODING!
        private List<Tile> generateOptimalEncoding()
        {
            var tiles = new List<Tile>();



            return tiles;
        }

        // Writes a .tds file
        private void writeTdsFile(List<Tile> tiles, string fileName)
        {
            using (var file = new System.IO.StreamWriter(Environment.CurrentDirectory + "/" + fileName + ".tds"))
            {
                foreach (var tile in tiles)
                {
                    file.Write(tile.PrintTile());
                }
            }
        }

        // Makes a number into a binary number
        private List<char> makeBinary(int n, int k)
        {
            int bitNumber;
            var binaryNumber = new char[k];

            for (int i = k; i > 0; i--)
            {
                bitNumber = (int)Math.Pow(2, i - 1);
                if (n >= bitNumber)
                {
                    binaryNumber[i - 1] = '1';
                    n -= bitNumber;
                }
                else
                {
                    binaryNumber[i - 1] = '0';
                }
            }

            return binaryNumber.ToList();
        }

        // Closes the program on close
        private void form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }

        private void WutButton_Click(object sender, EventArgs e)
        {
            var optimalEcoding = new OptimalEncoding();
            var n = int.Parse(sizeInput.Text);

            var strings = optimalEcoding.GetBitStrings(n);

            var message = "" + optimalEcoding.GetSubstringSize(n) + ": ";

            foreach(var str in strings)
            {
                message = message + str + " ";
            }

            MessageBox.Show(message);
        }
    }
}
