using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1BaseConversion
{ /* Operații în baza doi
  Ai un număr zecimal transformă-l în baza doi, reprezentat ca și un array de byte (byte[]).
  Pentru un număr transformat implementează operațiile:
  NOT, AND, NOT, OR, XOR
  RightHandShift și LeftHandShift(shiftare de biți la dreapta și la stânga)
  LessThan
  Adunare și scădere
  Înmulțire și împărțire
  Folosește-te de LessThan pentru a implementa și alți operatori de comparare(GraterThan, Equal, NotEqual)
  Doar pentru numere pozitive.
  Poți generaliza transformarea și operațiile de la 3-6 pentru o bază aleatoare (baza fiind între 2 și 255)?
  */
   public class BaseConversion
    {
        static void Main(string[] args)
        {
        }
        
    public static void ConvertToBit(int number,ref byte[] converted)
        {
           int i = 1;
 
            while (number/2!=0 || number%2!=0)
            {
                if (IsShortArray(converted, i)) converted = DoubleBitNumber(converted);
                int index = GetCurrentIndex(converted, i);
                if (number % 2 == 1) converted[index] = 1;
                else converted[index] = 0;
                number = number / 2;
                i++;
            }
        }
       
        private static int GetCurrentIndex(byte[] converted, int i)
        {
            return converted.Length - i;
        }

        private static byte[] DoubleBitNumber(byte[] converted)
        {
            {
                int pos = converted.Length;
                Array.Resize(ref converted, converted.Length * 2);
                RightHandShift(converted, pos);
                            }

            return converted;

        }
        public static void BitwiseNOT(byte[] sourceArray, ref byte[] array)
        {
            array = new byte[sourceArray.Length];
            for (int i = 0; i < sourceArray.Length; i++)
               if (sourceArray[i] == 0) array[i] = 1;
                else array[i] = 0;
            
        }
        public static void BitwiseAND(byte[] firstArray,byte[] secondArray, ref byte[] andArray)
        {
            if (HaveDifferentLengths(firstArray, secondArray))
                MakeEqualLength(ref firstArray, ref secondArray);          
            andArray = new byte[firstArray.Length];
            for (int i = 0; i < firstArray.Length; i++)
                if (firstArray[i] == 1 & secondArray[i] == 1)
                    andArray[i] = 1;
                else andArray[i] = 0;

        }
        public static void BitwiseOR(byte[] firstArray, byte[] secondArray, ref byte[] orArray)
        {
            if (HaveDifferentLengths(firstArray, secondArray))
                MakeEqualLength(ref firstArray, ref secondArray);
            orArray = new byte[firstArray.Length];
            for (int i = 0; i < firstArray.Length; i++)
                if (firstArray[i] == 1 || secondArray[i] == 1)
                    orArray[i] = 1;
                else orArray[i] = 0;

        }
        public static void BitwiseXOR(byte[] firstArray, byte[] secondArray, ref byte[] xorArray)
        {
            if (HaveDifferentLengths(firstArray, secondArray))
                MakeEqualLength(ref firstArray, ref secondArray);
            xorArray = new byte[firstArray.Length];
            for (int i = 0; i < firstArray.Length; i++)
                if (firstArray[i] != secondArray[i])
                    xorArray[i] = 1;
                else xorArray[i] = 0;

        }
        private static void MakeEqualLength(ref byte[] firstArray, ref byte[] secondArray)
        {
            if (firstArray.Length > secondArray.Length)
                secondArray = MakeSameLength(firstArray,ref secondArray);
            else firstArray = MakeSameLength(secondArray,ref firstArray);
        }

        private static bool HaveDifferentLengths(byte[] firstArray, byte[] secondArray)
        {
            return firstArray.Length != secondArray.Length;
        }

        private static byte[] MakeSameLength(byte[] longArray,ref  byte[] shortArray)
        {
            {
                int posToShift = longArray.Length-shortArray.Length;
                Array.Resize(ref shortArray, longArray.Length);
                RightHandShift(shortArray, posToShift);

            }

            return shortArray;
        }

        private static void RightHandShift(byte[] array, int positionsJumped)
        {
            int firstShiftedIndex = array.Length - positionsJumped - 1;
            for (int i = firstShiftedIndex;i>=0;i--)
            {
                array[i + positionsJumped] = array[i];
            }
            FillInZeros(array, positionsJumped);
        }
        private static void FillInZeros(byte[] array,int finishingIndex, int beginingIndex=0)
        {
            for (int i = beginingIndex; i < finishingIndex; i++)
            {
                array[i] = 0;
            }
        }
        private static bool IsShortArray(byte[] converted, int i)
        {
            return i > converted.Length;
        }
    }
}

