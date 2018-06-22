using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _443.String_Compression
{
    public class Solution
    {
        public int Compress(char[] chars)
        {
            char previousChar = chars.First();
            int count = 1;
            int  charPtr = 0;
            foreach (var c in chars.Skip(1))
            {
                if (previousChar == c)
                {
                    count++;
                }
                else
                {
                    chars[charPtr++] = previousChar;
                    if (count > 1)
                    {
                        Array.Copy(count.ToString().ToCharArray(),0, chars, charPtr, count.ToString().Length);
                        charPtr += count.ToString().Length;
                    }
                    previousChar = c;
                    count = 1;

                }
            }
            chars[charPtr++] = previousChar;
            if (count > 1)
            {
                Array.Copy(count.ToString().ToCharArray(), 0, chars, charPtr, count.ToString().Length);
                charPtr += count.ToString().Length;
            }
            return charPtr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
