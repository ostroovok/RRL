using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;

namespace Logic
{
    public class WorkWithFile
    {
        public string TextFromFile { get; set; }
        public int Number { get; set; }

        public WorkWithFile(string textFromFile, int number)
        {
            TextFromFile = textFromFile;
            Number = number;
        }

        public string[] FindWordsOfNLen()
        {
            string[] Words = TextFromFile.Split(new char[8] { ' ', ';', ',', '.', '!', '?', '\r', '\n' }, 
                StringSplitOptions.RemoveEmptyEntries).Where(w => w.Length == Number).ToArray();
            return Words;
        }
    }
}
