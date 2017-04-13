using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours_9
{
    public class FileDownloader
    {

        private Settings settings;
        private IUserInteract iUserInteract;

        public void Start(IUserInteract userInteract)
        {
            iUserInteract = userInteract;
            settings = new Settings(userInteract);

            UpdateSaveFolderPath();
            StartNewDownload();
        }

        private void UpdateSaveFolderPath()
        {
            settings.UpdatePath();
        }

        private void StartNewDownload()
        {
            FileContent file = new FileContent(settings);
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
