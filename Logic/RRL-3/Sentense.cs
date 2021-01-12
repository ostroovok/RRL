using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Sentense
    {
        public LinkedList<Word> OneSentense { get; set; }

        public Sentense(LinkedList<Word> oneSentense)
        {
            OneSentense = oneSentense;
        }

        public void AddWord(Word word) 
        {
            OneSentense.AddLast(word);
        }
        public void RemoveWord(Word firstWord)
        {
            foreach(Word secondWord in OneSentense)
            {
                if(secondWord == firstWord)
                {
                    OneSentense.Remove(secondWord);
                    break;
                }
            }
        }
        public new string ToString()
        {
            string str = "";
            foreach(Word word in OneSentense)
            {
                str += word.OneWord;
            }
            return str;
        }
        public void Clear()
        {
            OneSentense = new LinkedList<Word>();
        }
    }
}
