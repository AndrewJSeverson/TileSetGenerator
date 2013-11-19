﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileSetGenerator.GlobalClasses
{
    public class Tile
    {
        private static string TN_L = "TILENAME ";
        private static string L_L = "LABEL ";
        private static string NB_L = "NORTHBIND ";
        private static string EB_L = "EASTBIND ";
        private static string SB_L = "SOUTHBIND ";
        private static string WB_L = "WESTBIND ";
        private static string NL_L = "NORTHLABEL ";
        private static string EL_L = "EASTLABEL ";
        private static string SL_L = "SOUTHLABEL ";
        private static string WL_L = "WESTLABEL ";
        private static string C_L = "CREATE ";
        private static string NEW_LINE = " \n";

        public static string TN { get; set; }
        public static string L { get; set; }
        public static int NB { get; set; }
        public static int EB { get; set; }
        public static int SB { get; set; }
        public static int WB { get; set; }
        public static string NL { get; set; }
        public static string EL { get; set; }
        public static string SL { get; set; }
        public static string WL { get; set; }
        public static string C { get; set; }

        public string PrintTile()
        {
            String tile = TN_L + TN + NEW_LINE
                          + L_L + L + NEW_LINE
                          + NB_L + NB + NEW_LINE
                          + EB_L + EB + NEW_LINE
                          + SB_L + SB + NEW_LINE
                          + NB_L + NB + NEW_LINE
                          + NL_L + NL + NEW_LINE
                          + EL_L + EL + NEW_LINE
                          + SB_L + SB + NEW_LINE
                          + WB_L + WB + NEW_LINE
                          + C_L + C + NEW_LINE
                          + NEW_LINE + NEW_LINE;
            return tile;
        }
    }
}
