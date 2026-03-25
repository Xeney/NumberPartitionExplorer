using System;

namespace NumberPartitionExplorer.Logic
{
    /// <summary>
    /// Класс для хранения информации о каждом шаге рекурсивного алгоритма
    /// </summary>
    public class TraceEntry
    {
        public int Level;
        public int Remaining;
        public int MinSummand;
        public string CurrentPartition;
        public string Action;

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