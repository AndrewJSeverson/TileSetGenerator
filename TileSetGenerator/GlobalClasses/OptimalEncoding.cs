using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileSetGenerator.GlobalClasses
{
    public class OptimalEncoding
    {
        private List<Tile> tileList;

        public List<Tile> GetCounter(int number)
        {

            return getCounter(number);
        }

        public List<string> GetBitStrings(int n)
        {
            string bitString = this.getBitString(n);
            return getSubstrings(n);
        }

        public int GetSubstringSize(int n)
        {
            return getSubstringSize(n);
        }

        private List<Tile> getCounter(int n)
        {
            
            var substrings = this.getSubstrings(n);


            return this.tileList;
        }

        private List<string> getSubstrings(int n)
        {
            var strings = new List<string>();
            var bitString = this.getBitString(n);
            var bitStringLength = bitString.Length;
            var k = this.getSubstringSize(n);
            var padding = bitStringLength % k;
            var numberOfSubstrings = (bitStringLength + padding) / k;

            for (var i = 0; i < padding; i++)
            {
                bitString = "0" + bitString;
            }

            for (var i = 0; i < numberOfSubstrings; i++)
            {
                strings.Add(bitString.Substring(i, k));
            }

            return strings;
        }

        private int getSubstringSize(int n)
        {
            var logN = Math.Log(n, 2);
            var nOverLogN = n / logN;
            var k = (int)Math.Ceiling(Math.Log(nOverLogN, 2));

            return k;
        }

        private string getBitString(int n)
        {
            int bitNumber;
            var len = (int)Math.Ceiling(Math.Log(n, 2));
            var binaryNumberBuilder = new StringBuilder();

            for (var i = len; i > 0; i--)
            {
                bitNumber = (int)Math.Pow(2, i - 1);

                if (n >= bitNumber)
                {
                    binaryNumberBuilder.Append("1");
                    n -= bitNumber;
                }
                else
                {
                    binaryNumberBuilder.Append("0");
                }
            }

            return binaryNumberBuilder.ToString();
        }
    }
}