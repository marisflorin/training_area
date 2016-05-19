using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3WordSort
{
  public struct Word
    {
    public string word;
    public int instances;
    }
  public  class WordSort
    {
        static void Main(string[] args)
        {
        }
        public static void SortWords(string textSequence,ref Word[] list)
        {
            string[] words = textSequence.Split(' ', ',', '/', '.',':');
            int i = 0;
            while (words.Length>0)
            {
                Word currentWord = new Word() { word = words[0], instances = Count(words[0], ref words) };
               

            }  
        }
        public static int ReturnInsIndex();
        public static int Count(string currentWord,ref string[] words )
        {
            int i = 0,k=0;
            while (i<words.Length)
            {
                if (words[i] == currentWord)
                {
                    ShiftLeft(words, i);
                    Array.Resize(ref words, words.Length - 1);
                    k++;
                }
                else i++;
            }
            return k;
        }
        public static void ShiftLeft(string[] words,int start)
        {
            for (int i = start; i< words.Length - 1; i++)
                words[i] = words[i + 1];
        }
    }
}
