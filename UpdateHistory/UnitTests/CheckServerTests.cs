using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using WUApiLib;

namespace UpdateHistory.UnitTests
{
    [TestFixture]
    public class CheckServerTests
    {
        [SetUp]
        public void Init()
        {

        }
        [Test]
        [Category("pass")]
        [TestCase("wcbuildapp02.intellig.local", false)]
        [TestCase("wcswapp01.intellig.local", false)]
        [TestCase("labqademctl01.labmasoh.local", true)]
        [TestCase("labengdemctl00.labmasoh.local", true)]
        [TestCase("OH0KLT733D7S2.global.ds.honeywell.com", false)]
        public void CheckServerTest(string servername, bool expectedReturnValue)
        {
            // Act
            bool returnValue = Models.CheckServer.CheckLocation(servername);

            // Assert
            Assert.AreEqual(expectedReturnValue, returnValue);

        }
    }
}
