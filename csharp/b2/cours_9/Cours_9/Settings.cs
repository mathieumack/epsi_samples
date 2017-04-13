using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours_9
{
    public class Settings
    {
        private IUserInteract userInteractObject;
        public string SavePath { get; internal set; }

        public Settings(IUserInteract userInteract)
        {
            userInteractObject = userInteract;
        }
        public void UpdatePath()
        {
            userInteractObject.WriteLine("Please enter a folder path :");
            SavePath = userInteractObject.ReadLine();
        }
    }
}
