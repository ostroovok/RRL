using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Сonversion
    {
        public string OpenFilePath { get; set; }
        public Сonversion(string openFilePath)
        {
            OpenFilePath = openFilePath;
        }

        public string TextFromFile()
        {
            string textFromFile;
            FileStream file1 = new FileStream(OpenFilePath, FileMode.Open);
            StreamReader reader = new StreamReader(file1);
            textFromFile = reader.ReadToEnd();
            reader.Close();
            return textFromFile;
        }

        public void TextWriteToFile(string[] words)
        {
            string outWords = string.Join(" ", words);
            using (StreamWriter sw = new StreamWriter(OpenFilePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(outWords);
            }
        }
    }
}
