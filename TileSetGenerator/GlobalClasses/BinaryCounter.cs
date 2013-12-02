using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileSetGenerator.GlobalClasses
{
    /*
     *  This class will create a binary counter. I will define the constant tile types. 
     *  Additionally, the class will take in the starting binary number to start counting from. 
    */
    public class BinaryCounter
    {
        // the starting binary number for the binary counter
        public List<Char> BinaryNumber { get; set; }

        // the list of tiles to create the binary counter
        public List<Tile> BinaryCounterTiles { get; set; } 

        // constructor which takes in the starting binary number 
        public BinaryCounter(List<char> binaryNumber)
        {
            BinaryNumber = binaryNumber;
            BinaryCounterTiles = new List<Tile>();
        }

        // setter method to change the binary number
        public void SetStartingBinaryNumber(List<char> newNumber)
        {
            BinaryNumber = newNumber;
        }

        // method to call create and return the tile set
        public List<Tile> GenerateBinaryCounter()
        {
            createBinaryCounterTiles();
            return BinaryCounterTiles;
        }

        public List<Tile> GenerateBinaryCounterForSquare()
        {
            createSpecialBinaryCounterTiles();
            return BinaryCounterTiles;
        }


        // method to create the tile set
        private void createBinaryCounterTiles()
        {
            // get constant tiles for set
            List<Tile> tiles = getConstantTiles();

            bool firstIsOne = int.Parse(BinaryNumber[0].ToString()) == 1;

            // loop over the starting string chars for the seed row
            for (int i = BinaryNumber.Count - 1; i >= 0; i--)
            {
                bool seedIsOne = (int.Parse(BinaryNumber[i].ToString()) % 2) != 0;
                
                // first binary number, special seed
                if (i == 0)
                {
                    Tile seedStart = new Tile
                    {
                        TN = "Seed" + i,
                        L = BinaryNumber[i].ToString(),
                        NB = (seedIsOne ? 2 : 1),
                        EB = 0,
                        SB = 1,
                        WB = 2,
                        NL = (seedIsOne ? "1*" : "0*"),
                        EL = "",
                        SL = "",
                        WL = "0",
                    };
                    tiles.Add(seedStart);
                }
                // last binary number, special seed
                else if (i == BinaryNumber.Count - 1)
                {
                    Tile seedEnd = new Tile
                    {
                        TN = "Seed" + i,
                        L = BinaryNumber[i].ToString(),
                        NB = (firstIsOne ? 1: 2),
                        EB = 2,
                        SB = 2,
                        WB = 2,
                        NL = "*0",
                        EL = (i-1).ToString(),
                        SL = "vS",
                        WL = "<S",
                    };
                    tiles.Add(seedEnd);
                }
                // the rest of the normal seeds
                else
                {
                    Tile seed = new Tile
                    {
                        TN = "Seed" + i,
                        L = BinaryNumber[i].ToString(),
                        NB = 1,
                        EB = 2,
                        SB = 1,
                        WB = 2,
                        NL = (seedIsOne ? "1" : "0"),
                        EL = (i - 1).ToString(),
                        SL = "",
                        WL = (i).ToString(),
                    };
                    tiles.Add(seed);
                }
            }

            // set global list of tiles to the generated on
            BinaryCounterTiles = tiles;
        }

        // method to create the tile set
        private void createSpecialBinaryCounterTiles()
        {
            // get constant tiles for set
            List<Tile> tiles = getSpecialConstantTiles();

            bool firstIsOne = int.Parse(BinaryNumber[0].ToString()) == 1;

            // loop over the starting string chars for the seed row
            for (int i = BinaryNumber.Count - 1; i >= 0; i--)
            {
                bool seedIsOne = (int.Parse(BinaryNumber[i].ToString()) % 2) != 0;

                // first binary number, special seed
                if (i == 0)
                {
                    Tile seedStart = new Tile
                    {
                        TN = "Seed" + i,
                        L = BinaryNumber[i].ToString(),
                        NB = (seedIsOne ? 2 : 1),
                        EB = 2,
                        SB = 2,
                        WB = 2,
                        NL = (seedIsOne ? "1*" : "0*"),
                        EL = "#",
                        SL = "#",
                        WL = "0",
                    };
                    tiles.Add(seedStart);
                }
                // last binary number, special seed
                else if (i == BinaryNumber.Count - 1)
                {
                    Tile seedEnd = new Tile
                    {
                        TN = "Seed" + i,
                        L = BinaryNumber[i].ToString(),
                        NB = (firstIsOne ? 1 : 2),
                        EB = 2,
                        SB = 1,
                        WB = 1,
                        NL = (seedIsOne ? "*1" : "*0"),
                        EL = (i - 1).ToString(),
                        SL = "",
                        WL = "",
                    };
                    tiles.Add(seedEnd);
                }
                // the rest of the normal seeds
                else
                {
                    Tile seed = new Tile
                    {
                        TN = "Seed" + i,
                        L = BinaryNumber[i].ToString(),
                        NB = 1,
                        EB = 2,
                        SB = 1,
                        WB = 2,
                        NL = (seedIsOne ? "1" : "0"),
                        EL = (i - 1).ToString(),
                        SL = "",
                        WL = (i).ToString(),
                    };
                    tiles.Add(seed);
                }
            }

            // set global list of tiles to the generated on
            BinaryCounterTiles = tiles;
        }

        // generates the constant tiles needed to build the counter
        private List<Tile> getConstantTiles()
        {
            List<Tile> tiles = new List<Tile>();

            Tile one = new Tile
            {
                TN = "Inc0cc",
                L = "1",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "1",
                EL = "c",
                SL = "0",
                WL = "n",
            };
            tiles.Add(one);

            Tile RightInc1 = new Tile
            {
                TN = "Inc0c",
                L = "0",
                NB = 1,
                EB = 0,
                SB = 2,
                WB = 1,
                NL = "0*",
                EL = "",
                SL = "1*",
                WL = "c",
            };
            tiles.Add(RightInc1);

            Tile Inc1c = new Tile
            {
                TN = "Inc1c",
                L = "0",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "0",
                EL = "c",
                SL = "1",
                WL = "c",
            };
            tiles.Add(Inc1c);

            Tile Inc0n = new Tile
            {
                TN = "Inc0n",
                L = "0",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "0",
                EL = "n",
                SL = "0",
                WL = "n",
            };
            tiles.Add(Inc0n);

            Tile Incn1 = new Tile
            {
                TN = "Incn1",
                L = "1",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "1",
                EL = "n",
                SL = "1",
                WL = "n",
            };
            tiles.Add(Incn1);

            Tile LeftInc0n = new Tile
            {
                TN = "LeftInc0n",
                L = "0",
                NB = 2,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "*0",
                EL = "n",
                SL = "*0",
                WL = "#0",
            };
            tiles.Add(LeftInc0n);

            Tile LeftCopy0 = new Tile
            {
                TN = "LeftCopy0",
                L = "0",
                NB = 1,
                EB = 1,
                SB = 2,
                WB = 1,
                NL = "*0",
                EL = "",
                SL = "*0",
                WL = "#0",
            };
            tiles.Add(LeftCopy0);

            Tile Copy0 = new Tile
            {
                TN = "Copy0",
                L = "0",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "0",
                EL = "",
                SL = "0",
                WL = "",
            };
            tiles.Add(Copy0);

            Tile RightCopy1 = new Tile
            {
                TN = "RightCopy1",
                L = "1",
                NB = 2,
                EB = 0,
                SB = 1,
                WB = 1,
                NL = "1*",
                EL = "",
                SL = "0*",
                WL = "",
            };
            tiles.Add(RightCopy1);

            Tile Copy1 = new Tile
            {
                TN = "Copy1",
                L = "1",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "1",
                EL = "",
                SL = "1",
                WL = "",
            };
            tiles.Add(Copy1);

            return tiles;
        }

        // generates the constant tiles needed to build the counter for squares
        private List<Tile> getSpecialConstantTiles()
        {
            List<Tile> tiles = new List<Tile>();

            Tile RightInc1 = new Tile
            {
                TN = "IncRight",
                L = "0",
                NB = 1,
                EB = 1,
                SB = 2,
                WB = 1,
                NL = "0*",
                EL = "+",
                SL = "1*",
                WL = "c",
            };
            tiles.Add(RightInc1);

            Tile one = new Tile
            {
                TN = "0c",
                L = "1",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "1",
                EL = "c",
                SL = "0",
                WL = "n",
            };
            tiles.Add(one);

            Tile Inc1c = new Tile
            {
                TN = "1c",
                L = "0",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "0",
                EL = "c",
                SL = "1",
                WL = "c",
            };
            tiles.Add(Inc1c);

            Tile Inc0n = new Tile
            {
                TN = "0n",
                L = "0",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "0",
                EL = "n",
                SL = "0",
                WL = "n",
            };
            tiles.Add(Inc0n);

            Tile Incn1 = new Tile
            {
                TN = "1n",
                L = "1",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "1",
                EL = "n",
                SL = "1",
                WL = "n",
            };
            tiles.Add(Incn1);

            Tile RightCopy1 = new Tile
            {
                TN = "CopyRight",
                L = "1",
                NB = 2,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "1*",
                EL = "+",
                SL = "0*",
                WL = "",
            };
            tiles.Add(RightCopy1);

            Tile LeftInc0n = new Tile
            {
                TN = "n*0",
                L = "0",
                NB = 2,
                EB = 1,
                SB = 1,
                WB = 0,
                NL = "*0",
                EL = "n",
                SL = "*0",
                WL = "",
            };
            tiles.Add(LeftInc0n);

            Tile LeftCopy0 = new Tile
            {
                TN = "Copy0Left",
                L = "0",
                NB = 1,
                EB = 1,
                SB = 2,
                WB = 0,
                NL = "*0",
                EL = "",
                SL = "*0",
                WL = "",
            };
            tiles.Add(LeftCopy0);

            Tile Copy0 = new Tile
            {
                TN = "Copy0Middle",
                L = "0",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "0",
                EL = "",
                SL = "0",
                WL = "",
            };
            tiles.Add(Copy0);

            Tile Copy1 = new Tile
            {
                TN = "Copy1Middle",
                L = "1",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 1,
                NL = "1",
                EL = "",
                SL = "1",
                WL = "",
            };
            tiles.Add(Copy1);

            Tile IncLeft0c = new Tile
            {
                TN = "IncLeft0c",
                L = "1",
                NB = 2,
                EB = 1,
                SB = 1,
                WB = 0,
                NL = "*1",
                EL = "c",
                SL = "*0",
                WL = "",
            };
            tiles.Add(IncLeft0c);

            Tile Copy1Left = new Tile
            {
                TN = "Copy1Left",
                L = "1",
                NB = 1,
                EB = 1,
                SB = 2,
                WB = 0,
                NL = "*1",
                EL = "",
                SL = "*1",
                WL = "",
            };
            tiles.Add(Copy1Left);

            Tile IncLeft1n = new Tile
            {
                TN = "IncLeft1n",
                L = "1",
                NB = 2,
                EB = 1,
                SB = 1,
                WB = 0,
                NL = "*1",
                EL = "n",
                SL = "*1",
                WL = "",
            };
            tiles.Add(IncLeft1n);

            Tile Stop = new Tile
            {
                TN = "Stop",
                L = "Stop",
                NB = 2,
                EB = 1,
                SB = 1,
                WB = 0,
                NL = "",
                EL = "c",
                SL = "*1",
                WL = "",
            };
            tiles.Add(Stop);

            return tiles;
        }

    }
}
