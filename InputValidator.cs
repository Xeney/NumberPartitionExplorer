using System;
using System.Collections.Generic;
using System.Text;

namespace NumberPartitionExplorer
{
    /// <summary>
    /// Валидация пользовательского ввода
    /// </summary>
    public static class InputValidator
    {
        /// <summary>
        /// Проверяет, является ли введенная строка корректным числом для алгоритма
        /// </summary>
        /// <param name="input">Входная строка из текстового поля</param>
        /// <param name="result">Выходной параметр: распарсенное число</param>
        /// <returns>true если число корректно, иначе false</returns>
        public static bool ValidateNumber(string input, out int result)
        {
            result = 0;
            bool isValid = false;

            if (input != null)
            {
                // Пытаемся преобразовать строку в целое число
                if (int.TryParse(input, out result))
                {
                    // По условию задачи N > 1
                    // (потому что нужно не менее двух натуральных слагаемых)
                    if (result > 1)
                    {
                        isValid = true;
                    }
                }
            }

            return isValid;
        }

        /// <summary>
        /// Возвращает сообщение об ошибке для пользователя
        /// </summary>
        public static string GetErrorMessage()
        {
            return "Ошибка: Введите натуральное число N > 1";
        }
    }
}