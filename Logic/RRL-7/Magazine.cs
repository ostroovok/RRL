using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Magazine : AbstractBook
    {
        public int Subscribers { get; set; }
        public override string EditionName { get; set; }
        public override string AuthorName { get; set; }
        public override string BookName { get; set; }
        public override int BookCost { get; set; }
        public override int Number { get; set; }

        public Magazine(int subscribers, string editionName, string authorName, string bookName, int bookCost, int number)
        {
            Subscribers = subscribers;
            EditionName = editionName;
            AuthorName = authorName;
            BookName = bookName;
            BookCost = bookCost;
            Number = number;
        }

        public override string DestroyBook()
        {
            string str = $"Уничтожаем Журнал '{BookName}', \r\n" +
                $"Издательство: {EditionName},\r\n" +
                $"Автор: {AuthorName},\r\n" +
                $"Номер: {Number}";
            BookCost = 0;
            BookName = "";
            EditionName = "";
            AuthorName = "";
            Number = 0;

            return str;
        }
        public string PublicNewMagazine(int subscribers, string editionName, string authorName, string bookName, int bookCost)
        {
            Subscribers = subscribers;
            AuthorName = authorName;
            BookCost = bookCost;
            BookName = bookName;
            EditionName = editionName;
            return Publication();
        }
        public override string GetInfo()
        {
            return $"Журнал с кол-вом читателей: '{Subscribers}', \r\n" + base.GetInfo();
        }
    }
}
