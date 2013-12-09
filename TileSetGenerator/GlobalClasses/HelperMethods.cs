using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileSetGenerator.GlobalClasses
{
    public static class HelperMethods
    {
        public static List<Tile> FlipTileSetVertically(List<Tile> tiles)
        {
            foreach (var tile in tiles)
            {
                // to flip a tile set vertically we need to swap all East and West
                // glue strengths and labels

                // temp store of east glue and label
                var eastGlue = tile.EB;
                var eastLabel = tile.EL;

                // swap west glue and label to east glue and label
                tile.EB = tile.WB;
                tile.EL = tile.WL;

                // replace west glue and label with temp east labels
                tile.WB = eastGlue;
                tile.WL = eastLabel;

            }
            return tiles;
        }

        public static List<Tile> FlipTileSetVHorizontally(List<Tile> tiles)
        {
            foreach (var tile in tiles)
            {
                // to flip a tile set horizontally we need to swap all south and north
                // glue strengths and labels

                // temp store of north glue and label
                var northGlue = tile.NB;
                var northLabel = tile.NL;

                // swap south glue and label to north glue and label
                tile.NB = tile.SB;
                tile.NL = tile.SL;

                // replace south glue and label with temp north labels
                tile.SB = northGlue;
                tile.SL = northLabel;

            }
            return tiles;
        }

        public static List<Tile> FlipTileSet90Degrees(List<Tile> tiles)
        {
            foreach (var tile in tiles)
            {
                // to flip a tile 90 degrees clockwise we need to just replace each glue/label
                // with the next glue/label in the NESW rotation

                // temp store of north glue and label
                var northGlue = tile.NB;
                var northLabel = tile.NL;

                // swap north with west
                tile.NB = tile.WB;
                tile.NL = tile.WL;

                // swap west with south
                tile.WB = tile.SB;
                tile.WL = tile.SL;

                //swap south with east
                tile.SB = tile.EB;
                tile.SL = tile.EL;

                // swap east with north
                tile.EB = northGlue;
                tile.EL = northLabel;
            }
            return tiles;
        } 
    }
}
