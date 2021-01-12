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
    public partial class Form3 : Form
    {
        private Text text;
        private Sentense sentense;

        public Form3()
        {
            InitializeComponent();
            LinkedList<Word> wordList = new LinkedList<Word>();
            LinkedList<Sentense> senList = new LinkedList<Sentense>();
            sentense = new Sentense(wordList);
            text = new Text(senList);
        }

        private void AddWordBut_Click(object sender, EventArgs e)
        {
            sentense.AddWord(new Word(addWordBox.Text));
        }

        private void AddSentenceBut_Click(object sender, EventArgs e)
        {
            sentenceBox.Text = sentense.ToString();
            text.AddSentense(sentense);
        }

        private void Run_Click(object sender, EventArgs e)
        {
            OutTextBox.Text = " ";
            OutTextBox.Text = text.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            text.Clear();
            sentense.Clear();
            addWordBox.Text = "";
            sentenceBox.Text = "";
            OutTextBox.Text = "";
        }

        private void HeaderBut_Click(object sender, EventArgs e)   // Выводит 2 раза
        {
            LinkedList<Word> wordList = new LinkedList<Word>();
            Sentense newSentense = new Sentense(wordList);
            newSentense.AddWord(new Word(HeaderBox.Text + "\r\n"));
            text.AddHeader(newSentense);
        }
    }
}
