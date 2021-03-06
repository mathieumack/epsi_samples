﻿using System.IO;
using System.Net;

namespace Cours_9
{
    public class FileContent
    {
        private ISettings settingsObject;

        public string Name { get; set; }

        public string Uri { get; set; }

        private string LocalFilePath
        {
            get
            {
                return Path.Combine(settingsObject.SavePath, Name);
            }
        }

        public FileContent(ISettings settings)
        {
            settingsObject = settings;
        }

        public void Download()
        {
            WebClient client = new WebClient();
            client.DownloadFile(Uri, LocalFilePath);
        }

        public FileContentInfos GetInfos()
        {
            FileInfo fileInfos = new FileInfo(LocalFilePath);
            FileContentInfos result = new FileContentInfos()
            {
                FileName = Name,
                Length = fileInfos.Length
            };
            return result;
        }
    }
}
