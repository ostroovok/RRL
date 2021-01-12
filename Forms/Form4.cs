using System;
using Logic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void QHBut_Click(object sender, EventArgs e)
        {
            QualityWithHdd Q = new QualityWithHdd(NameBox.Text, int.Parse(FrequencyBox.Text), 
                int.Parse(RAMBox.Text), int.Parse(PBox.Text));
            OutPanel.Text = Q.GetInfo();
        }

        private void QBut_Click(object sender, EventArgs e)
        {
            Quality Q = new Quality(NameBox.Text, int.Parse(FrequencyBox.Text),
                int.Parse(RAMBox.Text));
            OutPanel.Text = Q.GetInfo();
        }
    }
}
