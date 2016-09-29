using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DoFck.DetectEncoding.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\test-gbk.txt";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            DetectEncoding encoding = EncodingDetect.Detect(buffer);
            Assert.AreEqual(encoding, DetectEncoding.GBK);

            string text = Encoding.GetEncoding("GBK").GetString(buffer);
            StringAssert.Matches(text, new Regex("联通"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\test-utf8.txt";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            DetectEncoding encoding = EncodingDetect.Detect(buffer);
            Assert.AreEqual(encoding, DetectEncoding.UTF8BOM);

            string text = Encoding.UTF8.GetString(buffer);
            StringAssert.Matches(text, new Regex("联通"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\test-unicode.txt";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            DetectEncoding encoding = EncodingDetect.Detect(buffer);
            Assert.AreEqual(DetectEncoding.UTF16LittleEndian, encoding);

            string text = Encoding.Unicode.GetString(buffer);
            StringAssert.Matches(text, new Regex("联通"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\test-unicode-big-endian.txt";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            DetectEncoding encoding = EncodingDetect.Detect(buffer);
            Assert.AreEqual(DetectEncoding.UTF16BigEndian, encoding);

            string text = Encoding.BigEndianUnicode.GetString(buffer);
            StringAssert.Matches(text, new Regex("联通"));
        }
    }
}
