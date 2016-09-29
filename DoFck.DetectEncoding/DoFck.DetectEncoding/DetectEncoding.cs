using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoFck.DetectEncoding
{
    public enum DetectEncoding
    {
        UnKnow,

        UTF8BOM,
        UTF16BigEndian,
        UTF16LittleEndian,
        UTF32BigEndian,
        UTF32LittleEndian,

        UTF8NOBOM,
        GBK,
        ASCII,
        Unicode
    }
}
