using System;
using System.Collections.Generic;
using System.Text;

namespace NumberPartitionExplorer
{
    /// <summary>
    /// Класс для хранения информации о каждом шаге рекурсивного алгоритма
    /// Используется для отображения трассировки в правом текстовом поле
    /// Позволяет визуализировать процесс работы рекурсии
    /// </summary>
    public class TraceEntry
    {
        // Уровень рекурсии (глубина вызова)
        public int Level;
        // Оставшаяся сумма, которую нужно набрать
        public int Remaining;
        // Минимальное значение для следующего слагаемого
        public int MinSummand;
        // Текущее представление числа (уже выбранные слагаемые)
        public string CurrentPartition;
        // Действие, выполняемое на данном шаге
        public string Action;

        /// <summary>
        /// Конструктор записи трассировки
        /// </summary>
        /// <param name="level">Глубина рекурсии</param>
        /// <param name="remaining">Остаток для разбиения</param>
        /// <param name="minSummand">Минимальное допустимое слагаемое</param>
        /// <param name="currentPartition">Текущая сумма слагаемых в виде строки</param>
        /// <param name="action">Описание действия</param>
        public TraceEntry(int level, int remaining, int minSummand,
                         string currentPartition, string action)
        {
            Level = level;
            Remaining = remaining;
            MinSummand = minSummand;
            CurrentPartition = currentPartition;
            Action = action;
        }
    }
}