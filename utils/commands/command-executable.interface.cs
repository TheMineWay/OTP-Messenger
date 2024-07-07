
namespace OTP_Messenger.utils.commands
{
    internal interface ICommandExecutable
    {
        void OnCommandExecuted(Dictionary<string, string> args);
    }
}
