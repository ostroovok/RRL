using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class QualityWithHdd : Quality
    {
        public int P { get; set; }
        public QualityWithHdd(string procName, int frequency, int ram, int P) : base(procName, frequency, ram)
        {
            this.P = P;
        }

        public override double Calculate()
        {
            return base.Calculate() + (0.5*P);
        }

        public new string GetInfo()
        {
            string info = base.GetInfo();
            //info += "Качетсво с учетом объема памяти винчестера: " + GetQ();
            return info;
        }
    }
}
