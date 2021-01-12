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
    public partial class Form6 : Form
    {
        private Library library;
        public Form6()
        {
            library = new Library(new List<IEdition>());
            InitializeComponent();
        }

        private void CreateBut_Click(object sender, EventArgs e)
        {
            PreOutBox.Text = "";

            //library.AddBook(EdNameBox.Text, AuNameBox.Text, BoNameBox.Text,
                //int.Parse(BoCostBox.Text));
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            PreOutBox.Text = "";
            int number = int.Parse(boNumber.Text);
            AbstractBook book = library.FindBook(int.Parse(boNumber.Text));
            PreOutBox.Text = book.RemoveFromPublication();
            library.DestroyBook(number);
        }

        private void FindBut_Click(object sender, EventArgs e)
        {
            PreOutBox.Text = "";
            AbstractBook book = library.FindBook(int.Parse(boNumber.Text));
            PreOutBox.Text = book.Publication();
        }

        private void ReEditionBut_Click(object sender, EventArgs e)
        {
            PreOutBox.Text = "";
            DirectoryBook book = (DirectoryBook)library.FindBook(int.Parse(boNumber.Text));
            //DirectoryBook newBook = new DirectoryBook(EdNameBox.Text, AuNameBox.Text, BoNameBox.Text,
                        //int.Parse(BoCostBox.Text), book.Number);
            //PreOutBox.Text = book.StartReEdition(newBook);
        }

        private void CreateListBut_Click(object sender, EventArgs e)
        {
            OutBox.Text = library.ToString();
        }
    }
}
