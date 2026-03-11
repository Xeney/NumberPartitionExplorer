using System;
using System.Collections.Generic;
using System.Text;

namespace NumberPartitionExplorer
{
    public static class InputValidator
    {
        public static bool ValidateNumber(string input, out int result)
        {
            result = 0;
            bool isValid = false;

            if (input != null)
            {
                if (int.TryParse(input, out result))
                {
                    if (result > 1)
                    {
                        isValid = true;
                    }
                }
            }

            return isValid;
        }

        public static string GetErrorMessage()
        {
            return "Ошибка: Введите натуральное число N > 1";
        }
    }
}
