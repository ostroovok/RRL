using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logic;
using Forms;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRL_7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form7 form = new Form7();
            Application.Run(form);
        }
    }
}
