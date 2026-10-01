using System.Threading.Tasks;

namespace AISettingsWindow
{
    // Minimal static AI settings helper used by the form.
    internal static class AISettings
    {
        public static string ErrorMessage { get; private set; }
        public static string ModelName { get; set; }
        public static string Key { get; set; }
        public static string EndPoint { get; set; }

        public static async Task ValidateCredentials()
        {
            await Task.Delay(600); // simulate validation

            ErrorMessage = null;

            if (string.IsNullOrWhiteSpace(EndPoint) || string.IsNullOrWhiteSpace(Key))
            {
                ErrorMessage = "Endpoint or Key cannot be empty.";
                return;
            }

            // In a real implementation, perform network validation here and set ErrorMessage on failure.
        }
    }
}
