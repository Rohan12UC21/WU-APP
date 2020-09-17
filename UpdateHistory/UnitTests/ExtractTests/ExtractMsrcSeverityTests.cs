using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using HtmlAgilityPack;
using NUnit.Framework;

namespace UpdateHistory.UnitTests.ExtractTests
{
    [TestFixture]
    public class ExtractMsrcSeverityTests
    {
        Extract extract = new Extract();
        HtmlDocument document;

        [SetUp]
        public void InitHtmlDocument()
        {

        }

        [Test]
        [Category("pass")]
        [TestCase("http://www.catalog.update.microsoft.com/ScopedViewInline.aspx?updateid=6e2d3ec0-a14d-4347-a8c3-fa37bf45fe5a", "Critical")]
        [TestCase("http://www.catalog.update.microsoft.com/ScopedViewInline.aspx?updateid=bfdf4b49-a42b-4b00-a875-73a3de727854", "Unspecified")]
        public void ExtractMsrcSeverityPass(string catalogURL, string expectedMsrcSeverity)
        {
            string htmlCode;
            using (WebClient client = new WebClient())
            {
                htmlCode = client.DownloadString(catalogURL);
            }
            document = new HtmlDocument();
            document.LoadHtml(htmlCode);

            // Act
            string MsrcSeverity = Extract.ExtractMsrcSeverity(document);

            // Assert
            Assert.AreEqual(expectedMsrcSeverity, MsrcSeverity);

        }
    }
}
