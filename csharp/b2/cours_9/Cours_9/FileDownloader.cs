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
            userInteract.WriteLine("Please enter the file name :");
            file.Name = Console.ReadLine();
            userInteract.WriteLine("Please enter the file uri :");
            file.Uri = userInteract.ReadLine();

            userInteract.WriteLine("Download in progress :");
            file.Download();

            userInteract.WriteLine("Downloaded. Informations :");
            FileContentInfos infos = file.GetInfos();
            userInteract.WriteLine("             Name :" + infos.FileName);
            userInteract.WriteLine("             Length :" + infos.Length);
        }
    }
}
