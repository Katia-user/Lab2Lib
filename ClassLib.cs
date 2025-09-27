using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Lib
{
    public class ClassLib
    {
        class Processor
        {
            public string Brand;
            public string Model;
            public int Generation;
            public double Frequency;
            public int Cores;
            public bool HasIntegratedGraphics;
            public int Year;
            public int Cache;

            public double CalculatePerformance()
            {
                return Frequency * Cores;
            }
        }

    }
}
