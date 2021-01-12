using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Word
    {
        public string OneWord { get; set; }
        public Word(string word) 
        {
            OneWord = word + " ";
        }  
    }
}
