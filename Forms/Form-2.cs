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
using System.CodeDom;

namespace Forms
{
    public partial class Form2 : Form
    {
        private string toOpenPath;

        private string toSavePath;
        public Form2()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    toOpenPath = openFileDialog.FileName;
                }
            }
            OpenBox.Text = toOpenPath;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    toSavePath = openFileDialog.FileName;
                }
            }
            SaveBox.Text = toSavePath;
        }

        private void Run_Click(object sender, EventArgs e)
        {
            Сonversion conv = new Сonversion(toOpenPath);
            string textFromFile = conv.TextFromFile();
            int number = int.Parse(NumBox.Text);
            WorkWithFile wwf = new WorkWithFile(textFromFile, number);
            conv.TextWriteToFile(wwf.FindWordsOfNLen());
            OutBox.Text = "Выполнено";
        }

        private void CheangeBut_Click(object sender, EventArgs e)
        {
            ChangeBox.Text = toOpenPath;
            Сonversion conv = new Сonversion(toSavePath);
            string textFromFile = conv.TextFromFile();
            int number = int.Parse(NumBox.Text);
            WorkWithFile wwf = new WorkWithFile(textFromFile, number);
            conv.TextWriteToFile(wwf.FindWordsOfNLen());
            OutBox.Text = "Выполнено";
        }
    }
}
