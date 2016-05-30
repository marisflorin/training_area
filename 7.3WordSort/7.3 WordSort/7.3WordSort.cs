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
    public class WordSort
    {
        static void Main(string[] args)
        {
        }
        public static void SortWords(string textSequence, ref Word[] list)
        {
            string[] words = textSequence.Split(new string[] { " ", ",", "/", ".", ":"},StringSplitOptions.RemoveEmptyEntries);
            if (words.Length > 0)
            {
                Word currentWord = new Word() { word = words[0], instances = Count(words[0], ref words) };
                list[0] = currentWord;
            }

            int insertIndex;

            while (words.Length > 0) 
            {
                Word currentWord = new Word() { word = words[0], instances = Count(words[0], ref words) };
                insertIndex= FindIndex(currentWord, list, 0, list.Length - 1);
                InsertWord(currentWord, ref list, insertIndex);
            }
            
        }

        public static int FindIndex(Word currentWord, Word[] list,int start, int end)
        {
            int half = (start + end) / 2;
            if (half == 0)
                if (currentWord.instances > list[0].instances) return 0;
                else return 1; 
            if (half == list.Length-1)
                if (currentWord.instances > list[list.Length-1].instances) return list.Length-1;
                else return list.Length;          
            if (currentWord.instances > list[half].instances) return FindIndex(currentWord, list, start, half - 1);
            else if (currentWord.instances < list[half - 1].instances) return FindIndex(currentWord, list, half + 1, end);
                 else return half;
        }

        public static void InsertWord(Word currentWord, ref Word[] list,int insertIndex)
        {
            Array.Resize(ref list, list.Length + 1);
            if (insertIndex!=list.Length-1) ShiftRight(ref list, insertIndex);
            list[insertIndex] = currentWord;
        }       

        public static int Count(string currentWord, ref string[] words)
        {
            int i = 0, k = 0;
            while (i < words.Length)
            {
                if (words[i] == currentWord)
                {
                    ShiftLeft(ref words, i);
                    Array.Resize(ref words, words.Length - 1);
                    k++;
                }
                else i++;
            }
            return k;
        }

        public static void ShiftLeft(ref string[] words, int start)
        {
            for (int i = start; i < words.Length - 1; i++)
                words[i] = words[i + 1];
        }

        public static void ShiftRight(ref Word[] list, int start)
        {
            for (int i = start; i < list.Length - 1; i++)
                list[i+1] = list[i];
        }
    }
}

