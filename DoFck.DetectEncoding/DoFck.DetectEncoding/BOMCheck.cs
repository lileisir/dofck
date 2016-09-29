using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoFck.DetectEncoding
{
    public class BOMCheck
    {
        public static DetectEncoding GetEncoding(byte[] buffer)
        {
            DetectEncoding encoding = DetectEncoding.UnKnow;

            if (IsUTF8BOM(buffer))
                encoding = DetectEncoding.UTF8BOM;

            if (IsUTF32BigEndian(buffer))
                encoding = DetectEncoding.UTF32BigEndian;

            if (IsUTF32LittleEndian(buffer))
                encoding = DetectEncoding.UTF32LittleEndian;

            if (IsUTF16BigEndian(buffer))
                encoding = DetectEncoding.UTF16BigEndian;

            if (IsUTF16LittleEndian(buffer))
                encoding = DetectEncoding.UTF16LittleEndian;

            return encoding;
        }


        public static bool IsUTF8BOM(byte[] buffer)
        {
            byte[] BOM = new byte[] { 0xEF, 0xBB, 0xBF };
            return buffer[0] == BOM[0] && buffer[1] == BOM[1] && buffer[2] == BOM[2];
        }

        public static bool IsUTF16BigEndian(byte[] buffer)
        {
            byte[] BOM = new byte[] { 0xFE, 0xFF };
            return buffer[0] == BOM[0] && buffer[1] == BOM[1];
        }

        public static bool IsUTF16LittleEndian(byte[] buffer)
        {
            byte[] BOM = new byte[] { 0xFF, 0xFE };
            return buffer[0] == BOM[0] && buffer[1] == BOM[1];
        }

        public static bool IsUTF32BigEndian(byte[] buffer)
        {
            byte[] BOM = new byte[] { 0xFF, 0xFE, 0x00, 0x00 };
            return buffer[0] == BOM[0] && buffer[1] == BOM[1] && buffer[2] == BOM[2] && buffer[3] == BOM[3];
        }

        public static bool IsUTF32LittleEndian(byte[] buffer)
        {
            byte[] BOM = new byte[] { 0x00, 0x00, 0xFE, 0xFF };
            return buffer[0] == BOM[0] && buffer[1] == BOM[1] && buffer[2] == BOM[2] && buffer[3] == BOM[3];
        }
    }
}
