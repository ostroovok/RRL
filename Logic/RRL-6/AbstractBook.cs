using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public abstract class AbstractBook : IEdition
    {
        public abstract string EditionName { get; set; }
        public abstract string AuthorName { get; set; }
        public abstract string BookName { get; set; }
        public abstract int BookCost { get; set; }
        public abstract int Number { get; set; }
        public string FindPublication(string edName) //--
        {
            if (edName == EditionName)
            {
                return $"Найдена публикация книги: \r\n" + GetInfo();
            }
            return "Публикация не была найдена...";
        }
        public string Publication() //--
        {
            return $"Публикуем книгу '{BookName}', \r\n" +
                $"Издательство: {EditionName},\r\n" +
                $"Автор: {AuthorName},\r\n" +
                $"Номер: {Number}";
        }
        public string RemoveFromPublication() //--
        {
            return $"Снимаем с публикации книгу '{BookName}', \r\n" +
                $"Издательство: {EditionName},\r\n" +
                $"Автор: {AuthorName},\r\n" +
                $"Номер: {Number}";
        }
        public virtual bool EqualsBook(int num)
        {
            if (num == Number)
            {
                return true;
            }
            return false;
        }
        public abstract string DestroyBook();

        public virtual string GetInfo() 
        {
            return $"Название: '{BookName}', \r\n" +
                $"Издательство: {EditionName},\r\n" +
                $"Автор: {AuthorName},\r\n" +
                $"Номер: {Number}";
        }
    }
}
