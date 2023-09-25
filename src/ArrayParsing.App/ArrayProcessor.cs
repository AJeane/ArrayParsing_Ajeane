using System;

namespace ArrayParsingApp
{
    public static class ArrayProcessor
    {
        public static string ProcessInput(string input, char delimiter)
        {
            string[] values = input.Split(delimiter);
            string validatedResult = "";

            foreach (var value in values)
            {
                if (IsValidNumeric(value))
                {
                    if (validatedResult != "")
                        validatedResult += ",";
                    validatedResult += value;
                }
            }

            return validatedResult;
        }

        private static bool IsValidNumeric(string value)
        {
            return double.TryParse(value, out _);
        }
    }
}