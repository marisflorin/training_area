﻿using System;
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

        public static void ConvertToBit(int number, ref byte[] converted)
        {
            int i = 1;

            while (number / 2 != 0 || number % 2 != 0)
            {
                if (IsShortArray(converted, i)) converted = DoubleBitNumber(ref converted);
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

        private static byte[] DoubleBitNumber(ref byte[] converted)
        {
            {
                int pos = converted.Length;
                Array.Resize(ref converted, converted.Length * 2);
                RightHandShift(ref converted, pos);
            }

            return converted;

        }
        public static void BitwiseNOT(byte[] sourceArray, ref byte[] array)
        {
            array = new byte[sourceArray.Length];
            for (int i = 0; i < sourceArray.Length; i++)
                array[i] = sourceArray[i] == 0 ? (byte)1 : (byte)0;
        }
        public static void BitwiseOPS(byte[] firstArray, byte[] secondArray, ref byte[] andArray, char op)
        {
            int length = GetBiggestLength(firstArray, secondArray);
            andArray = new byte[length];
            for (ushort i = 0; i < length; i++)
            {
                int pos = length - i - 1;
                switch (op)
                {
                    case '&':
                        andArray[pos] = AddElements(firstArray, secondArray, i) == 2 ? (byte)1 : (byte)0;
                        break;
                    case '|':
                        andArray[pos] = AddElements(firstArray, secondArray, i) != 0 ? (byte)1 : (byte)0;
                        break;
                    case '^':
                        andArray[pos] = AddElements(firstArray, secondArray, i) == 1 ? (byte)1 : (byte)0;
                        break;
                }
            }
        }

        private static int AddElements(byte[] firstArray, byte[] secondArray, ushort i,sbyte sign=1)
        {
            return GetBitAtIndex(firstArray, i) + GetBitAtIndex(secondArray, i)*sign;
        }

        private static int GetBiggestLength(byte[] firstArray, byte[] secondArray)
        {
            return firstArray.Length >= secondArray.Length ? firstArray.Length : secondArray.Length;
        }

        public static byte GetBitAtIndex(byte[] arrayOfBits, ushort index)
        {
            byte bit = index < arrayOfBits.Length ? arrayOfBits[arrayOfBits.Length - index - 1] : (byte)0;
            return bit;
        }

        public static void RightHandShift(ref byte[] array, int positionsJumped)
        {
            int firstShiftedIndex = array.Length - positionsJumped - 1;
            if (firstShiftedIndex >= 0)
            {
                for (int i = firstShiftedIndex; i >= 0; i--)
                {
                    array[i + positionsJumped] = array[i];
                }
                FillInZeros(array, positionsJumped);
            }
            else FillInZeros(array, array.Length);
        }
        public static void LeftHandShift(ref byte[] array, int positionsJumped)
        {
            while (IsShortToShift(array, positionsJumped)) DoubleBitNumber(ref array);
            for (int i = 0; i < array.Length - positionsJumped; i++)
                array[i] = array[i + positionsJumped];
            FillInZeros(array, array.Length, array.Length - positionsJumped);
        }

        private static bool IsShortToShift(byte[] array, int positionsJumped)
        {
            return FindIndexOfFirst1(array) < positionsJumped;
        }
        public static int FindIndexOfFirst1(byte[] array)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == 1) return i;
            return -1;
        }

        private static void FillInZeros(byte[] array, int finishingIndex, int beginingIndex = 0)
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
        public static bool LessThan(byte[] smallArray, byte[] bigArray)
        {
            bool isLessThan = false;
            int length = GetBiggestLength(smallArray, bigArray);
            length--;
            for (int i = length; i >= 0; i--)
                if (GetBitAtIndex(bigArray, (ushort)i) > GetBitAtIndex(smallArray, (ushort)i))
                {
                    isLessThan = true;
                    break;
                }
                else if (GetBitAtIndex(bigArray, (ushort)i) < GetBitAtIndex(smallArray, (ushort)i)) break;
            return isLessThan;

        }
        public static void Addition(byte[] firstArray, byte[] secondArray,ref byte[] additionArray)
            {
            byte carrier=0;
            int length = GetBiggestLength(firstArray, secondArray);
            additionArray = new byte[length];
            for (ushort i=0;i< length;i++)
            {
                if (Getquotient(firstArray, secondArray, carrier, i) > 0 && i == length - 1)
                {
                    DoubleBitNumber(ref additionArray);
                    length = length * 2;
                }
                additionArray[length - i - 1] = GetRemainder(firstArray, secondArray, carrier, i);
                carrier = Getquotient(firstArray, secondArray, carrier, i);
            }
           }

        public static bool CompareOPS(byte[] firstArray, byte[] secondArray, char comp)
        {
            bool isTrue=false;
            switch (comp)
            {

                case '>':
                    isTrue = (!LessThan(firstArray, secondArray) && LessThan(secondArray, firstArray));
                    break;
                case '=':
                    isTrue = (!LessThan(firstArray, secondArray) && !LessThan(secondArray, firstArray));
                    break;
                case '!':
                    isTrue = (LessThan(firstArray, secondArray) || LessThan(secondArray, firstArray));
                    break;
            }
                    return isTrue;
            }
        public static void Substraction(byte[] minuendArray, byte[] substractedArray, ref byte[] differenceArray)
        {
            differenceArray = new byte[minuendArray.Length];
            if (CompareOPS(minuendArray, substractedArray, '>') || CompareOPS(minuendArray, substractedArray, '='))
                for (ushort i = 0; i < minuendArray.Length; i++)
                {
                    if (GetBitAtIndex(minuendArray, i) < GetBitAtIndex(substractedArray, i))
                    {
                        ushort k = 1;
                        while (GetBitAtIndex(minuendArray, (ushort)(i+k)) < 1) k++;
                        minuendArray[minuendArray.Length - i - k - 1]--;                      
                        while (k > 0)
                        {
                            k--;
                            minuendArray[minuendArray.Length - i - k - 1] = 2 - 1;              
                        }
                        minuendArray[minuendArray.Length - i - k - 1]++;

                    }
                    differenceArray[minuendArray.Length - i - 1] = (byte)AddElements(minuendArray, substractedArray, i, -1);
                }
            while (FindIndexOfFirst1(differenceArray) >= differenceArray.Length/2 && differenceArray.Length > 8)
            {
                LeftHandShift(ref differenceArray, differenceArray.Length / 2);
                Array.Resize(ref differenceArray, differenceArray.Length / 2);
            } 
        }
        byte[] productArray = new byte[8];
        public static void Multiply( byte[] multiplicated,byte[] multiplier,ref byte product)
            {
            byte[] step = { 0, 0, 0, 0, 0, 0, 0, 1 };
            byte[] zero = { 0, 0, 0, 0, 0, 0, 0, 0 };
            if 
             i<multiplier;i++)            
                    Addition(multiplicatedArray, multiplicatedArray, ref productArray);            
            
}

    private static byte GetRemainder(byte[] firstArray, byte[] secondArray, byte carrier, ushort i)
        {
            return (byte)((AddElements(firstArray, secondArray, i) + carrier) % 2);
        }
        private static byte Getquotient(byte[] firstArray, byte[] secondArray, byte carrier, ushort i)
        {
            return (byte)((AddElements(firstArray, secondArray, i) + carrier) / 2);
        }
    }
}

