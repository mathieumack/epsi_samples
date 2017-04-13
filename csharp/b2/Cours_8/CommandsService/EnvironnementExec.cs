using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandsService
{
    public class EnvironnementExec
    {
        private string currentPath;

        public void SetPath(string path)
        {
            currentPath = path;
        }

        public string GetPath()
        {
            return currentPath;
        }
    }
}
