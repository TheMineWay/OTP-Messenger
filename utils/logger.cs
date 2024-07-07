
namespace OTP_Messenger.utils
{
    internal class Logger
    {
        public static void Log(string message, string? scope = null) {
            var scopeTxt = scope == null ? "" : $"[{scope}]: ";
            Console.WriteLine(scopeTxt + message);
        }
    }
}
