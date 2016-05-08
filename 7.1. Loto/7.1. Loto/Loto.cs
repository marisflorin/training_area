using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1.Loto
{
    public class Loto
    {
        static void Main(string[] args)
        {
        }
        public static void PrintOut(int[] extractedSeq, ref int[][] sequence)
        {
            for (int i = 0; i < extractedSeq.Length; i++)
            {
                sequence[i] = new int[i+1];
                if (i == 0)
                {
                    sequence[0][0] = extractedSeq[0];
                }
                else CopyInsert(extractedSeq[i], ref sequence[i], sequence[i - 1]);
            }
        }
        public static void CopyInsert(int inserted, ref int[] resultArray, int[] sourceArray)
            {
            int i = 0, k = 0;
            while ((i + k) < resultArray.Length)
            {
                if (i == resultArray.Length - 1 && k == 0)
                {
                    k = 1;
                    resultArray[i] = inserted;
                }
                else
                if (sourceArray[i] > inserted && k==0 )
                {
                    resultArray[i] = inserted;
                    k = 1;
                }                
                if ((i + k) < resultArray.Length) resultArray[i + k] = sourceArray[i];
                i++;
            }
                     
            }
            }

    }

