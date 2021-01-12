using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Quality
    {
        public string ProcName { get; set; }
        public int Frequency { get; set; }
        public int Ram { get; set; }
        public double Q { get; set; }

        public Quality(string procName, int frequency, int ram)
        {
            ProcName = procName;
            Frequency = frequency;
            Ram = ram;
        }

        public virtual double Calculate()
        {
            Q = (0.1 * Frequency) + Ram;
            return Q;
        }

        public double Calculate(int f, int r)
        {
            double q = (0.1 * f) + r;
            return q;
        }

        public double GetQ() {
            return Calculate();
        }
        
        public string GetInfo()
        {
            string str = $"Имя: {ProcName}, \r\n" + $"Частота: " +
                $"{Frequency} (МГц), \r\n" + 
                $"Объем оперативной памяти: {Ram} (Мб). \r\n" +
                $"Качество: {GetQ()} \r\n";
            return str;
        }
    }
}
