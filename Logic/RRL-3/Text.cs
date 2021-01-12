using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Text
    {
        public LinkedList<Sentense> OneText { get; set; }

        public Text(LinkedList<Sentense> oneText)
        {
            OneText = oneText;
        }

        public void Clear()
        {
            OneText = new LinkedList<Sentense>();
        }

        public void AddSentense(Sentense sentense)
        {
            OneText.AddLast(sentense);
        }
        public void AddHeader(Sentense sentense)
        {
            OneText.AddFirst(sentense);
        }
        public new string ToString()
        {
            string oneStringText = "";
            foreach (Sentense sen in OneText)
            {
                oneStringText += sen.ToString();
            }
            return oneStringText;
        }
    }
}
