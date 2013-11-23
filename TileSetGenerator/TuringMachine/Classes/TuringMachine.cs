using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TileSetGenerator.GlobalClasses;

namespace TileSetGenerator.TuringMachine.Classes
{
    public class TuringMachine
    {
        public string FileName { get; set; }
        public List<char> Alphabet { get; set; }
        public List<char> StartingString { get; set; }
        public int StartingPosition { get; set; }
        public State StartingState { get; set; }
        public List<State> States { get; set; }

        // method that will create the list of tiles and return them
        public List<Tile> GenerateTileSet()
        {
            List<Tile> generateTiles = new List<Tile>();

            #region Seed Row

            Tile leftSeed = new Tile
            {
                TN = "LeftSeed",
                L = "-",
                EB = 2,
                NB = 1,
                NL = "*-",
                EL = "-1"
            };
            generateTiles.Add(leftSeed);
            Tile rightSeed = new Tile
            {
                TN = "RightSeed",
                L = "-",
                WB = 2,
                NB = 1,
                NL = "-*",
                WL = (StartingString.Count-1).ToString()
            };
            generateTiles.Add(rightSeed);

            // look over starting string seed tiles
            for (int i = 0; i < StartingString.Count; i++)
            {
                Tile temp = new Tile
                {
                    TN = "Seed_" + i,
                    L = StartingString[i].ToString(),
                    NB = 1,
                    EB = 2,
                    WB = 2,
                    NL = StartingString[i].ToString(),
                    EL = (i).ToString(),
                    WL = (i - 1).ToString(),
                };
                if (StartingPosition == i)
                {
                    temp.NB = 2;
                    temp.NL = StartingState.StateName + "_" + temp.NL;
                }
                generateTiles.Add(temp);
            }

            #endregion

            #region Move Right/Left

            // loop over each state to write all transitions for that state
            foreach (var state in States)
            {
                // now we want to loop ever all transistion for each state
                foreach (var transition in state.Transistions)
                {
                    if (transition.Value.NextState.StateName == "halt")
                    {
                        // if next state is halting state, we only need the one halting tile  
                        Tile haltingTile = new Tile
                        {
                            TN = "halt",
                            L = "HALT",
                            SB = 2,
                            WB = 1,
                            EB = 1,
                            SL = state.StateName + "_" + transition.Key.ToString(),
                            WL = "L",
                            EL = "R"
                        };
                        generateTiles.Add(haltingTile);
                        continue;
                    }
                    // list of tiles to add
                    List<Tile> tilesToLoad;
                    // check if the transistion is a move left or right and build appropriate tiles
                    if (transition.Value.MovementDirection == TuringMachineSettings.TransistionDirection.Right)
                    {
                        // move right tiles to be build
                        tilesToLoad = buildMoveRightTiles(transition, state.StateName);
                    }
                    else
                    {
                        // move left tiles need to be built
                        tilesToLoad = buildMoveLeftTiles(transition, state.StateName);
                    }

                    // add the tiles to add
                    foreach (var tile in tilesToLoad)
                    {
                        generateTiles.Add(tile);
                    }
                }
            }

            #endregion

            #region Alphabet

            foreach (var character in Alphabet)
            {
                Tile right = new Tile
                {
                    TN = character.ToString() + "_R",
                    L = character.ToString(),
                    NB = 1,
                    EB = 1,
                    SB = 1,
                    WB = 1,
                    NL = character.ToString(),
                    EL = "R",
                    SL = character.ToString(),
                    WL = "R",
                };
                generateTiles.Add(right);

                Tile left = new Tile
                {
                    TN = character.ToString() + "_L",
                    L = character.ToString(),
                    NB = 1,
                    EB = 1,
                    SB = 1,
                    WB = 1,
                    NL = character.ToString(),
                    EL = "L",
                    SL = character.ToString(),
                    WL = "L",
                };
                generateTiles.Add(left);
            }

            #endregion

            #region Grow Tape Tiles

            Tile farLeftTile = new Tile
            {
                TN = "*-",
                L = "*-",
                NB = 1,
                EB = 2,
                NL = "*-",
                EL = "*-"
            };
            generateTiles.Add(farLeftTile);

            Tile farRightTile = new Tile
            {
                TN = "-*",
                L = "-*",
                NB = 1,
                WB = 2,
                NL = "-*",
                WL = "-*"
            };
            generateTiles.Add(farRightTile);

            Tile middleLeftRow = new Tile
            {
                TN = "-R",
                L = "-",
                NB = 1,
                EB = 2,
                SB = 1,
                WB = 1,
                NL = "-",
                EL = "-*",
                SL = "-*",
                WL = "R",
            };
            generateTiles.Add(middleLeftRow);

            Tile middleRightRow = new Tile
            {
                TN = "-L",
                L = "-",
                NB = 1,
                EB = 1,
                SB = 1,
                WB = 2,
                NL = "-",
                EL = "L",
                SL = "*-",
                WL = "*-",
            };
            generateTiles.Add(middleRightRow);

            #endregion

            return generateTiles;
        }

        #region Helper Methods

        // method that builds the move right tile transition
        private List<Tile> buildMoveRightTiles(KeyValuePair<char, Transition> transition, string state )
        {
            List<Tile> rightTiles = new List<Tile>();

            // tile that starts the next row
            Tile growUpTile = new Tile
            {
                TN = state + "_" + transition.Key.ToString() + "_to_" + transition.Value.NextState.StateName,
                L = state + "_" + transition.Key.ToString(),
                NB = 1,
                EB = 1,
                SB = 2,
                WB = 1,
                NL = transition.Value.WriteChar.ToString(),
                EL = transition.Value.NextState.StateName,
                SL = state + "_" + transition.Key.ToString(),
                WL = "L",
            };
            rightTiles.Add(growUpTile);

            // tiles to start the next grow upward and change state
            // we need to go over each alphabet character to get all cases
            foreach (var character in Alphabet)
            {
                Tile changeState = new Tile
                {
                    TN = transition.Value.NextState.StateName + "_" + character.ToString() + "_from_left",
                    L = transition.Value.NextState.StateName + "_" + character.ToString(),
                    NB = 2,
                    EB = 1,
                    SB = 1,
                    WB = 1,
                    NL = transition.Value.NextState.StateName + "_" + character.ToString(),
                    EL = "R",
                    SL = character.ToString(),
                    WL = transition.Value.NextState.StateName,
                };
                rightTiles.Add(changeState);
            }

            // tile for empty space on far right
            Tile emptyRight = new Tile
            {
                TN = transition.Value.NextState.StateName + "_*-_from_left",
                L = transition.Value.NextState.StateName + "_-",
                NB = 2,
                EB = 2,
                SB = 1,
                WB = 1,
                NL = transition.Value.NextState.StateName + "_-",
                EL = "-*",
                SL = "-*",
                WL = transition.Value.NextState.StateName,
            };
            rightTiles.Add(emptyRight);

            return rightTiles;
        }

        // method that build the move left tile transitions
        private List<Tile> buildMoveLeftTiles(KeyValuePair<char, Transition> transition, string state)
        {
            List<Tile> leftTiles = new List<Tile>();

            // tile that starts the next row
            Tile growUpTile = new Tile
            {
                TN = state + "_" + transition.Key.ToString() + "_to_" + transition.Value.NextState.StateName,
                L = state + "_" + transition.Key.ToString(),
                NB = 1,
                EB = 1,
                SB = 2,
                WB = 1,
                NL = transition.Value.WriteChar.ToString(),
                EL = "R",
                SL = state + "_" + transition.Key.ToString(),
                WL = transition.Value.NextState.StateName,
            };
            leftTiles.Add(growUpTile);

            // tiles to start the next grow upward and change state
            // we need to go over each alphabet character to get all cases
            foreach (var character in Alphabet)
            {
                Tile changeState = new Tile
                {
                    TN = transition.Value.NextState.StateName + "_" + character.ToString() + "_from_left",
                    L = transition.Value.NextState.StateName + "_" + character.ToString(),
                    NB = 2,
                    EB = 1,
                    SB = 1,
                    WB = 1,
                    NL = transition.Value.NextState.StateName + "_" + character.ToString(),
                    EL = transition.Value.NextState.StateName,
                    SL = character.ToString(),
                    WL = "L",
                };
                leftTiles.Add(changeState);
            }

            // tile for empty space on far right
            Tile emptyLeft = new Tile
            {
                TN = transition.Value.NextState.StateName + "_-*_from_left",
                L = transition.Value.NextState.StateName + "_-",
                NB = 2,
                EB = 1,
                SB = 1,
                WB = 2,
                NL = transition.Value.NextState.StateName + "_-",
                EL = transition.Value.NextState.StateName,
                SL = "*-",
                WL = "*-",
            };
            leftTiles.Add(emptyLeft);

            return leftTiles;
        } 

        #endregion


    }
}
