using System.Linq;

namespace OTP_Messenger.utils.commands
{
    internal class CommandDefinition
    {
        public readonly string[] command;
        public readonly ICommandExecutable commandExecutable;
        public CommandDefinition(string command, ICommandExecutable commandExecutable) {
            this.command = command.Split(' ');
            this.commandExecutable = commandExecutable;
        }

        public bool TryRunCommand(string[] inputCommand)
        {
            var filteredInputCommand = RemoveInputCommandFlags(inputCommand);

            if (filteredInputCommand.Length < command.Length) return false;

            Dictionary<string, string> args = new();

            for(byte i = 0; i < command.Length; i++)
            {
                if (command[i].StartsWith('%'))
                {
                    args.Add(GetParamName(command[i]), filteredInputCommand[i]);
                    continue;
                }


                if (command[i] != filteredInputCommand[i]) return false;
            }


            return true;
        }

        private string[] RemoveInputCommandFlags(string[] inputCommand)
        {
            return (from part in inputCommand where !part.StartsWith("--") select part).ToArray();
        }

        private string GetParamName(string name) => name.Substring(1);
    }
}
