using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandsService
{
    public class CommandsManager
    {
        public void Start()
        {
            string userCommand = Console.ReadLine();
            string[] splitCommand = userCommand.Split(' ');

            EnvironnementExec envExecution = new EnvironnementExec();

            // Merge les paramètres dans une chaine de caractères
            string paramsCommand = "";
            for (int i = 1; i < splitCommand.Length; i++)
                paramsCommand += splitCommand[i] + " ";

            string command = splitCommand[0];
            switch(command)
            {
                case "dir":
                    DirCommand dirCommand = new DirCommand(envExecution);
                    if(splitCommand.Length > 1)
                        dirCommand.Execute(paramsCommand);
                    else
                        dirCommand.Execute();
                    break;
                case "cd":
                    CdCommand cdCommand = new CdCommand(envExecution);
                    if (splitCommand.Length > 1)
                        cdCommand.Execute(paramsCommand);
                    else
                        cdCommand.Execute();
                    break;
                case "del":
                    // TODO :
                    break;
                case "mkdir":
                    // TODO :
                    break;
                case "exit":
                    // TODO :
                    break;
                default:
                    break;
            }
        }
    }
}
