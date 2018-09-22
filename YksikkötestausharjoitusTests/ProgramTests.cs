using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yksikkötestausharjoitus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Yksikkötestausharjoitus.Program;

namespace Yksikkötestausharjoitus.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void HeTuOkTest()
        {            
            string hetu = "121288-1233";
            bool expected = true;
            bool actual = HeTuOk(hetu);
            Assert.AreEqual(expected, actual, "Joku pielessä, pitäisi olla ok hetu");
        }
        [TestMethod()]
        public void HeTuOkTest2()
        {
            string hetu = "120177-1A22";
            bool expected = false;
            bool actual = HeTuOk(hetu);
            Assert.AreEqual(expected, actual, "Joku pielessä, pitäisi olla ok hetu");
        }
    }
}