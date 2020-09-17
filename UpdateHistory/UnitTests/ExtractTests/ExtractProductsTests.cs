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
    public class ExtractProductsTests
    {
        Extract extract = new Extract();
        HtmlDocument document;

        [SetUp]
        public void InitHtmlDocument()
        {

        }

        [Test]
        [Category("pass")]
        [TestCase("http://www.catalog.update.microsoft.com/ScopedViewInline.aspx?updateid=6e2d3ec0-a14d-4347-a8c3-fa37bf45fe5a", "Windows 10")]
        [TestCase("http://www.catalog.update.microsoft.com/ScopedViewInline.aspx?updateid=bfdf4b49-a42b-4b00-a875-73a3de727854", "Windows 10, Windows 10 LTSB, Windows 8, Windows 8.1, Windows Server 2012, Windows Server 2012 R2, Windows Server 2016")]
        public void ExtractProductsPass(string catalogURL, string expectedProducts)
        {
            string htmlCode;
            using (WebClient client = new WebClient())
            {
                htmlCode = client.DownloadString(catalogURL);
            }
            document = new HtmlDocument();
            document.LoadHtml(htmlCode);

            // Act
            string Products = Extract.ExtractProducts(document);

            // Assert
            Assert.AreEqual(expectedProducts, Products);

        }
    }
}
