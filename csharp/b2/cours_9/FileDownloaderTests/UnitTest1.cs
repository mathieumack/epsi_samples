using System;
using Cours_9;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileDownloaderTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FileDownloader downloader = new FileDownloader();
            downloader.Start(new UserInteractTest());
        }
    }
}
