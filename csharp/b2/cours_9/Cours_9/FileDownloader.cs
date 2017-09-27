using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours_9
{
    public class FileDownloader
    {

        private ISettings iSettings;
        private IUserInteract iUserInteract;

        public void Start(IUserInteract userInteract, ISettings settings)
        {
            iUserInteract = userInteract;
            iSettings = settings;

            UpdateSaveFolderPath();
            StartNewDownload();
        }

        private void UpdateSaveFolderPath()
        {
            iSettings.UpdatePath();
        }

        private void StartNewDownload()
        {
            FileContent file = new FileContent(iSettings);
            iUserInteract.WriteLine("Please enter the file name :");
            file.Name = iUserInteract.ReadLine();
            iUserInteract.WriteLine("Please enter the file uri :");
            file.Uri = iUserInteract.ReadLine();

            iUserInteract.WriteLine("Download in progress :");
            file.Download();

            iUserInteract.WriteLine("Downloaded. Informations :");
            FileContentInfos infos = file.GetInfos();
            iUserInteract.WriteLine("             Name :" + infos.FileName);
            iUserInteract.WriteLine("             Length :" + infos.Length);
        }
    }
}
