using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandsService
{
    public class DirCommand : ICommand
    {
        private EnvironnementExec envExecution;
        public DirCommand(EnvironnementExec envExec)
        {
            envExecution = envExec;
        }

        public void Execute()
        {
            InternalExecute();
        }

        public void Execute(string args)
        {
            InternalExecute();
        }

        public int InternalExecute()
        {
            string currentPath = envExecution.GetPath();
        }
    }
}
