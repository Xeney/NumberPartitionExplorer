using System;
using System.Text;

namespace NumberPartitionExplorer.Logic
{
    /// <summary>
    /// Рекурсивный алгоритм разбиения числа на слагаемые
    /// Вариант 16
    /// </summary>
    public class PartitionLogic
    {
        private StringBuilder _resultBuffer;
        private TraceEntry[] _traceLog;
        private int _traceIndex;
        private int _maxTraceSize;

        public PartitionLogic(int maxTraceSize)
        {
            _resultBuffer = new StringBuilder();
            _maxTraceSize = maxTraceSize;
            _traceLog = new TraceEntry[maxTraceSize];
            _traceIndex = 0;
        }

        /// <summary>
        /// Очищает буферы результатов
        /// </summary>
        public void Clear()
        {
            _resultBuffer.Clear();
            _traceIndex = 0;
        }

        /// <summary>
        /// Возвращает результаты разбиения
        /// </summary>
        public string GetResults()
        {
            return _resultBuffer.ToString();
        }

        /// <summary>
        /// Возвращает массив трассировки
        /// </summary>
        public TraceEntry[] GetTrace()
        {
            return _traceLog;
        }

        /// <summary>
        /// Возвращает количество записей в трассе
        /// </summary>
        public int GetTraceCount()
        {
            return _traceIndex;
        }

        /// <summary>
        /// Запускает алгоритм разбиения числа N
        /// </summary>
        public void FindPartitions(int n)
        {
            int[] buffer = new int[n];
            int depth = 0;

            Clear();
            FindPartitionsRecursive(n, 1, buffer, depth);
        }

        /// <summary>
        /// Рекурсивный метод разбиения
        /// </summary>
        private void FindPartitionsRecursive(int remaining, int minSummand,
                                           int[] buffer, int depth)
        {
            bool isBaseCase = (remaining == 0);
            bool hasEnoughParts = (depth >= 2);

            if (isBaseCase)
            {
                if (hasEnoughParts)
                {
                    LogTrace(depth, remaining, minSummand, buffer, depth, "FOUND");
                    AppendResult(buffer, depth);
                }
                else
                {
                    LogTrace(depth, remaining, minSummand, buffer, depth, "BASE_INVALID");
                }
            }
            else
            {
                LogTrace(depth, remaining, minSummand, buffer, depth, "ENTER");

                int i = minSummand;
                while (i <= remaining)
                {
                    buffer[depth] = i;
                    FindPartitionsRecursive(remaining - i, i, buffer, depth + 1);
                    i = i + 1;
                }

                LogTrace(depth, remaining, minSummand, buffer, depth, "EXIT");
            }
        }

        /// <summary>
        /// Добавляет результат в буфер
        /// </summary>
        private void AppendResult(int[] buffer, int depth)
        {
            int i = 0;
            while (i < depth)
            {
                _resultBuffer.Append(buffer[i]);

                bool isLast = (i == depth - 1);
                if (!isLast)
                {
                    _resultBuffer.Append(" + ");
                }

                i = i + 1;
            }
            _resultBuffer.AppendLine();
        }

        /// <summary>
        /// Записывает шаг в трассировку
        /// </summary>
        private void LogTrace(int level, int remaining, int minSummand,
                            int[] buffer, int depth, string action)
        {
            bool hasSpace = (_traceIndex < _maxTraceSize);

            if (hasSpace)
            {
                string bufferStr = BuildBufferString(buffer, depth);
                TraceEntry entry = new TraceEntry(level, remaining, minSummand,
                                                 bufferStr, action);
                _traceLog[_traceIndex] = entry;
                _traceIndex = _traceIndex + 1;
            }
        }

        /// <summary>
        /// Преобразует буфер в строку
        /// </summary>
        private string BuildBufferString(int[] buffer, int depth)
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            while (i < depth)
            {
                sb.Append(buffer[i]);
                bool isLast = (i == depth - 1);
                if (!isLast)
                {
                    sb.Append(",");
                }
                i = i + 1;
            }
            return sb.ToString();
        }
    }
}