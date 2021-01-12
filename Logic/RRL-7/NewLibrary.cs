using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class NewLibrary
    {
        public List<dynamic> List { get; set; }

        public NewLibrary(List<dynamic> list)
        {
            List = list;
        }

        public void AddBook(object book)
        {
            List.Add(book);
            foreach (dynamic v in List)
            {
                Console.WriteLine(v.Class.BookName);
            }
        }

        public void RemoveBook(object book)
        {
            Console.WriteLine(2);
            List.Remove(book);
        }

        public ClassExample FindBook(int number)
        {
            foreach (dynamic book in List)
            {
                if (book.Class.EqualsBook(number) != null)
                {
                    Console.WriteLine(3);
                    book.Class.GetInfo();
                    return book;
                }
            }
            return null;
        }

        public string LibToString()
        {
            Console.WriteLine(4);
            int number = 0;
            string str = "";
            foreach (dynamic book in List)
            {
                str += $"{{{number}: Книга: '{book.Class.BookName}', \r\n" +
                               $"Издательство: {book.Class.EditionName}, \r\n" +
                               $"Тип:{book.Class.GetType().Name},\r\n" + 
                               $"Автор: {book.Class.AuthorName}, \r\n" +
                               $"Номер: {book.Class.Number} }} \r\n \r\n";
                number += 1;
            }
            return str;
        }
    }
}
