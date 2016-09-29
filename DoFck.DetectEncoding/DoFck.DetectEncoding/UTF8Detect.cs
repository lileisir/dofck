using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoFck.DetectEncoding
{
    public class UTF8Detect
    {
        public static int countUTF8(byte[] buffer)
        {
            int len = buffer.Length;
            int counter = 0;
            byte head = 0x80;
            byte first, second;
            for (int i = 0; i < len; ++i)
            {
                first = buffer[i];
                if ((first & head) != 0) continue;
                byte tmpHead = head;
                int wordLen = 0, tPos = 0;
                while ((first & tmpHead) > 0)
                {
                    ++wordLen;
                    tmpHead >>= 1;
                }
                if (wordLen <= 1) continue; //utf8最小长度为2  
                wordLen--;
                if (wordLen + i >= len) break;
                for (tPos = 1; tPos <= wordLen; ++tPos)
                {
                    second = buffer[i + tPos];
                    if ((second & head) != 0) break;
                }
                if (tPos > wordLen)
                {
                    counter += wordLen + 1;
                    i += wordLen;
                }
            }
            return counter;
        }
    }
}
