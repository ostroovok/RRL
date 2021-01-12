using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Library
    {
        public List<IEdition> List { get; set; }
        private int i;

        public Library(List<IEdition> list)
        {
            List = list;
            i = List.Count();
        }

        public void AddBook(string type, string edName, string auName, string boName, int boCost)
        {
            IEdition book = new DirectoryBook(type, edName, auName, boName,
                boCost, i);
            i++;
            List.Add(book);
        }

        public void DestroyBook(int number)
        {
            foreach (AbstractBook book in List)
            {
                if (book.EqualsBook(number))
                {
                    List.Remove(book);
                    break;
                }
            }
        }

        public AbstractBook FindBook(int number)
        {
            foreach (AbstractBook book in List)
            {
                if (book.EqualsBook(number))
                {
                    return book;
                }
            }
            return null;
        }

        public void ReEdition(AbstractBook newBook, int number)
        {
            AbstractBook book = FindBook(number);
        }

        public new string ToString()
        {
            int number = 0;
            string str = "";
            foreach (DirectoryBook book in List)
            {
                str += $"{{{number}: Книга: '{book.BookName}', \r\n" +
                               $"Издательство: {book.EditionName}, \r\n" +
                               $"Тип:{book.EditionName},\r\n" + //------------------ ИСПРАВЬ
                               $"Автор: {book.AuthorName}, \r\n" +
                               $"Номер: {book.Number} }} \r\n \r\n";
                number += 1;
            }
            return str;
        }
    }
}
