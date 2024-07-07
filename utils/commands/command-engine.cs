namespace OTP_Messenger.utils.commands
{
    internal class CommandEngine
    {
        private readonly CommandDefinition[] commands;
        public CommandEngine(CommandDefinition[] commands) {
            this.commands = commands;
        }

        public void Ask()
        {
            Console.WriteLine();
            Console.Write("> ");
            var input = Console.ReadLine();
            
        }

        private string[] ProcessInputCommand(string input)
        {

        }
    }
}
