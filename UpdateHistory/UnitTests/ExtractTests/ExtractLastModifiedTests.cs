﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using HtmlAgilityPack;
using NUnit.Framework;

namespace UpdateHistory.UnitTests.ExtractTests
{
    [TestFixture]
    public class ExtractLastModifiedTests
    {
        Extract extract = new Extract();
        HtmlDocument document;

        [SetUp]
        public void InitHtmlDocument()
        {

        }

        [Test]
        [Category("pass")]
        [TestCase("http://www.catalog.update.microsoft.com/ScopedViewInline.aspx?updateid=6e2d3ec0-a14d-4347-a8c3-fa37bf45fe5a", "1/4/2019")]
        [TestCase("http://www.catalog.update.microsoft.com/ScopedViewInline.aspx?updateid=b6dd04cb-e746-4a04-83d4-4b761c784f00", "10/5/2018")]
        public void ExtractLastModifiedPass(string catalogURL, string expectedLastModified)
        {
            string htmlCode;
            using (WebClient client = new WebClient())
            {
                htmlCode = client.DownloadString(catalogURL);
            }
            document = new HtmlDocument();
            document.LoadHtml(htmlCode);

            // Act
            string LastModified = Extract.ExtractLastModified(document);

            // Assert
            Assert.AreEqual(expectedLastModified, LastModified);

        }
    }
}
