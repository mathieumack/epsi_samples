using System;

namespace CommandsService
{
    public class CdCommand : ICommand
    {
        private EnvironnementExec envExecution;
        public CdCommand(EnvironnementExec envExec)
        {
            envExecution = envExec;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void Execute(string args)
        {
            envExecution.SetPath("todo");
        }
    }
}
