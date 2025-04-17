using System.ComponentModel;

namespace synactics_test
{
    public class InputValidator
    {

        public static bool IsFilePathValid(string filePath)
        {
            return !string.IsNullOrEmpty(filePath) && File.Exists(filePath);
        }

        public static bool IsValidYear(string input)
        {
            return !int.TryParse(input, out int year) || year < 1900 || year > 2100;
        }
    }
}