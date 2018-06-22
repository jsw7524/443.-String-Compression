using System;
using _443.String_Compression;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Solution sln = new Solution();
            char[] testData = new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            sln.Compress(testData);
            Assert.AreEqual(JsonConvert.SerializeObject(new char[] { 'a', '2', 'b', '2', 'c', '3','c' }),JsonConvert.SerializeObject(testData));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Solution sln = new Solution();
            char[] testData = new char[] { 'a',  'b', 'c' };
            sln.Compress(testData);
            Assert.AreEqual(JsonConvert.SerializeObject(new char[] { 'a', 'b',  'c' }), JsonConvert.SerializeObject(testData));
        }

    }
}
