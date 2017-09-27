using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours_9
{
    public interface ISettings
    {
        string SavePath { get; }


        void UpdatePath();
    }
}
