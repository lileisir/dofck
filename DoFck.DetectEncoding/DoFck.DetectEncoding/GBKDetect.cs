using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoFck.DetectEncoding
{
    public class GBKDetect
    {
        public static int countGBK(byte[] buffer)
        {
            int len = buffer.Length;
            int counter = 0;
            byte head = 0x80;
            byte firstChar, secondChar;

            for (int i = 0; i < len - 1; ++i)
            {
                firstChar = (byte)buffer[i];
                if ((firstChar & head) != 0) continue;
                secondChar = (byte)buffer[i];
                if (firstChar >= 161 && firstChar <= 247 && secondChar >= 161 && secondChar <= 254)
                {
                    counter += 2;
                    ++i;
                }
            }
            return counter;
        }
    }
}
