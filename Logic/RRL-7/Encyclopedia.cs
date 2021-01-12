using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Encyclopedia : AbstractBook
    {
        public string Theme { get; set; }
        public override string EditionName { get; set; }
        public override string AuthorName { get; set; }
        public override string BookName { get; set; }
        public override int BookCost { get; set; }
        public override int Number { get; set; }

        public Encyclopedia(string theme, string editionName, string authorName, string bookName, int bookCost, int number)
        {
            Theme = theme;
            EditionName = editionName;
            AuthorName = authorName;
            BookName = bookName;
            BookCost = bookCost;
            Number = number;
        }

        public override string DestroyBook()
        {
            string str = $"Уничтожаем Энциклопедию '{BookName}', \r\n" +
                $"Издательство: {EditionName},\r\n" +
                $"Автор: {AuthorName},\r\n" +
                $"Номер: {Number}";
            Theme = "";
            BookCost = 0;
            BookName = "";
            EditionName = "";
            AuthorName = "";
            Number = 0;

            return str;
        }

        public string PublicNewEnciclopedia(string theme, string editionName, string authorName, string bookName, int bookCost)
        {
            Theme = theme;
            AuthorName = authorName;
            BookCost = bookCost;
            BookName = bookName;
            EditionName = editionName;
            return Publication();
        }
        public override string GetInfo()
        {
            return $"Энциклопедия '{Theme}', \r\n" + base.GetInfo();
        }
    }
}
