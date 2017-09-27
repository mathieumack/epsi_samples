using System;
using Cours_9;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FileDownloaderTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FileDownloader downloader = new FileDownloader();

            // Mocks :
            Mock<IUserInteract> userInteractMock = new Mock<IUserInteract>();
            Mock<ISettings> settingsMock = new Mock<ISettings>();

            downloader.Start(userInteractMock.Object, settingsMock.Object);
        }
    }
}
