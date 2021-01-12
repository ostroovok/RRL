using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class DirectoryBook : AbstractBook
    {
        public string Language { get; set; }
        public override string EditionName { get; set; }
        public override string AuthorName { get; set ; }
        public override string BookName { get; set; }
        public override int BookCost { get; set; }
        public override int Number { get; set; }

        public DirectoryBook(string language, string edName, string auName, string boName, int boCost, int boNumber)
        {
            Language = language;
            EditionName = edName;
            AuthorName = auName;
            BookName = boName;
            BookCost = boCost;
            Number = boNumber;
        }

        public override string DestroyBook() //--
        {
            string str = $"Уничтожаем Словарь '{BookName}', \r\n" +
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

        public new DirectoryBook EqualsBook(int num) 
        {
            if(num == Number) 
            {
                return new DirectoryBook(Language, EditionName, AuthorName, BookName, BookCost, Number);
            }
            return null;
        }

        public string StartReEdition(string language, string edName, string auName, string boName, int boCost, int boNumber) //--
        {
            Language = language;
            EditionName = edName;
            AuthorName = auName;
            BookName = boName;
            BookCost = boCost;
            Number = boNumber;
            return GetInfo();
        }

        public override string GetInfo()
        {
            return $"Словарь '{Language}', \r\n" +  base.GetInfo();
        }
    }
}
