using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4ElectionResults
{
    public struct Candidate
    {
        public string name;
        public int numberOfVotes;
        public Candidate(string name,int numberOfVotes)
        {
            this.name = name;
            this.numberOfVotes = numberOfVotes;
        }
    }
    public class ElectionResults
    {
        static void Main(string[] args)
        {
        }
        public static void CentralizeVotes(string[] candidateNames, Candidate[,] resultList, ref Candidate[] list)
        {
            GenerateCandidates(candidateNames, ref list);
            int numberOfCandidates = resultList.GetLength(0);
            int numberOfLocations = resultList.GetLength(1);
            for (int i=0;i<numberOfLocations-1;i++)
                for (int j=0;j<numberOfLocations;j++)
                {
                    int index=GetIndex(resultList[i,j], list, 0, numberOfCandidates);
                    list[index].numberOfVotes += resultList[i,j].numberOfVotes;

                }
            QuickSort(ref list, 0, list.Length - 1);

        }
       public static void GenerateCandidates(string[] candidateNames,ref Candidate[] list)
        {
            Array.Resize(ref list, candidateNames.Length);
            for (int i = 0; i < candidateNames.Length; i++) list[i] = new Candidate(candidateNames[i], 0);                                  
        }
        public static int GetIndex(Candidate currentCandidate,Candidate[] list,int begining, int end)
        {
            int mid = (begining + end) / 2;
            if (begining > end) return -1;
            if (currentCandidate.name == list[mid].name) return mid;
            if (String.Compare(currentCandidate.name,list[mid].name,true)>0) return GetIndex(currentCandidate, list, mid + 1, end);
            else return GetIndex(currentCandidate, list, begining, mid-1);
        }
        public static void QuickSort(ref Candidate[] list, int left, int right)
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

        public static int GetIndex(ref Candidate[] list, int left, int right)
        {
            int pivotIndex = left;
            if (left > -1 && right < list.Length)
                while (left != right)
                {
                    while (list[pivotIndex].numberOfVotes >= list[right].numberOfVotes && pivotIndex != right) right--;
                    if (pivotIndex == right) break;
                    else if (list[pivotIndex].numberOfVotes < list[right].numberOfVotes) Swap(ref list, right, ref pivotIndex);
                    while (list[pivotIndex].numberOfVotes <= list[left].numberOfVotes && pivotIndex != left) left++;
                    if (pivotIndex == left) break;
                    else if (list[pivotIndex].numberOfVotes > list[left].numberOfVotes) Swap(ref list, left, ref pivotIndex);                }
            return pivotIndex;
        }
        private static void Swap(ref Candidate[] list, int right, ref int pivotIndex)
        {
            Candidate aux = list[right];
            list[right] = list[pivotIndex];
            list[pivotIndex] = aux;
            pivotIndex = right;
        }
    }
}
