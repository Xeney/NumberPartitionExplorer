using System;

namespace NumberPartitionExplorer.Logic
{
    /// <summary>
    /// Валидация пользовательского ввода
    /// </summary>
    public static class InputValidator
    {
        /// <summary>
        /// Проверяет корректность введённого числа
        /// </summary>
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

        /// <summary>
        /// Возвращает сообщение об ошибке
        /// </summary>
        public static string GetErrorMessage()
        {
            return "Ошибка: Введите натуральное число N > 1";
        }
    }
}