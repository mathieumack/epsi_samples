using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandsService;

namespace Cours_8
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandsManager manager = new CommandsManager();
            manager.Start();
        }
    }
}
