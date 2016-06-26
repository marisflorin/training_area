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
            for (int i=0; i < words.Length;i++)
            {
            int index = -1;
                if (ExistingWord(words[i], list,0,list.Length-1, ref index)) ++list[index].instances;
                else AddWord(words[i], ref list); 
            }
            QuickSort(ref list, 0, list.Length - 1);
            
        }
        public static bool ExistingWord(string currentWord, Word[] list,int begining,int end, ref int index)
        {
            if (end < 0 || begining > list.Length - 1) return false;
            int middle = (begining + end) / 2;
            if (currentWord==list[middle].word)
                {
                index = middle;
                return true;
                }
            if (begining == end || end== middle) return false;
            if  (ExistingWord(currentWord, list, begining, middle-1, ref index)) return true;
            else return ExistingWord(currentWord, list, middle+1,end, ref index);
                    
        }

        public static void AddWord(string currentWord, ref Word[] list)
        {
            if (list[0].word!=null) Array.Resize(ref list, list.Length + 1);
            list[list.Length-1].word = currentWord;
            list[list.Length - 1].instances = 1;
        }
        public static void QuickSort(ref Word[] list,int left,int right)
        {
            if (left > -1 && right < list.Length && left < right)
            {
                int pivotIndex = 0;
                if (left < right)
                    pivotIndex = GetIndex(ref list, left, right);
                QuickSort(ref list, left, pivotIndex - 1);
                QuickSort(ref list, pivotIndex + 1, right);
            }
        }

        public static int GetIndex(ref Word[] list, int left, int right)
        {	  	
	    int pivotIndex = left;	
	    if (left>-1 &&right<list.Length)    	
    	while(left!=right)
            {
            while( list[pivotIndex].instances >= list[right].instances && pivotIndex != right) right--;	
            if(pivotIndex == right) break;    		
            else if(list[pivotIndex].instances < list[right].instances) Swap(ref list, right, ref pivotIndex);
            while (list[pivotIndex].instances <= list[left].instances && pivotIndex != left) left++;	
        	if(pivotIndex == left) break;
		    else if(list[pivotIndex].instances > list[left].instances) Swap(ref list, left, ref pivotIndex);
         
	        }
            return pivotIndex;
          }

        private static void Swap(ref Word[] list, int right, ref int pivotIndex)
        {
            Word aux = list[right];
            list[right] = list[pivotIndex];
            list[pivotIndex] = aux;
            pivotIndex = right;
        }
      }
}

