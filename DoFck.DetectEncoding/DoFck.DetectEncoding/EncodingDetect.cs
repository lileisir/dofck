using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoFck.DetectEncoding
{
    public class EncodingDetect
    {
        public static DetectEncoding Detect(byte[] buffer)
        {
            DetectEncoding encoding = BOMCheck.GetEncoding(buffer);
            if (encoding != DetectEncoding.UnKnow)
            {
                return encoding;
            }

            return Test(buffer);
        }


        private static DetectEncoding Test(byte[] str)
        {
            int iGBK = GBKDetect.countGBK(str);
            int iUTF8 = UTF8Detect.countUTF8(str);
            if (iUTF8 > iGBK)
                return DetectEncoding.UTF8NOBOM;
            return DetectEncoding.GBK;
        }
    }
}
