using System;

namespace Lab2App
{
    internal class Processor
    {
        public string Brand { get; internal set; }
        public string Model { get; internal set; }
        public int Cores { get; internal set; }
        public double Frequency { get; internal set; }
        public int Generation { get; internal set; }
        public bool HasGraphics { get; internal set; }
        public object Technology { get; internal set; }
        public int Year { get; internal set; }
        public int CacheSize { get; internal set; }

        internal object CalculatePerformance()
        {
            throw new NotImplementedException();
        }
    }
}