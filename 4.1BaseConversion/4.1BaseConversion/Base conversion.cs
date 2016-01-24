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

        public static void ConvertToBit(int number, ref byte[] converted,byte numeralSystem=2)
        {
            int i = 1;

            while (number / numeralSystem != 0 || number % numeralSystem != 0)
            {
                if (IsShortArray(converted, i)) converted = DoubleBitNumber(ref converted);
                int index = GetCurrentIndex(converted, i);
                converted[index] = (byte)(number%numeralSystem) ;                
                number = number / numeralSystem;
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
            int length = GetBiggestLength(smallArray, bigArray);
            length--;
            for (int i = length; i >= 0; i--)
                if (GetBitAtIndex(bigArray, (ushort)i) > GetBitAtIndex(smallArray, (ushort)i))
                {
                    return true;
                }
                else if (GetBitAtIndex(bigArray, (ushort)i) < GetBitAtIndex(smallArray, (ushort)i)) return false;
            return false;
        }
        public static void Addition(byte[] firstArray, byte[] secondArray,ref byte[] additionArray,byte numeralSystem=2)
            {
            byte carrier=0;
            int length = GetBiggestLength(firstArray, secondArray);
            additionArray = new byte[length];
            for (ushort i=0;i< length;i++)
            {
                if (Getquotient(firstArray, secondArray, carrier, i,numeralSystem) > 0 && i == length - 1)
                {
                    DoubleBitNumber(ref additionArray);
                    length = length * 2;
                }
                additionArray[length - i - 1] = GetRemainder(firstArray, secondArray, carrier, i,numeralSystem);
                carrier = Getquotient(firstArray, secondArray, carrier, i,numeralSystem);
            }
           }

        public static bool CompareOPS(byte[] firstArray, byte[] secondArray, char comp)
        {
            switch (comp)
            {

                case '>':
                   return  LessThan(secondArray, firstArray);           
                case '=':
                    return (!LessThan(firstArray, secondArray) && !LessThan(secondArray, firstArray));
                case '!':
                    return (LessThan(firstArray, secondArray) || LessThan(secondArray, firstArray));
              }
            return false;         
            }
        public static void Substraction(byte[] minuend, byte[] substracted, ref byte[] difference,byte numeralSystem=2)
        {
            difference = new byte[minuend.Length];
            int didBorrow = 0;
            for (ushort i = 0; i < minuend.Length; i++)
            {
                int diff = numeralSystem + GetBitAtIndex(minuend, i) - GetBitAtIndex(substracted, i) - didBorrow;
                difference[minuend.Length - i - 1] = (byte)(diff % numeralSystem);
                didBorrow = diff / numeralSystem == 0 ? 1 : 0;

            }
            difference = DownSize(difference);
        }

        private static byte[] DownSize(byte[] difference)
        {
            while (FindIndexOfFirst1(difference) >= difference.Length / 2 && difference.Length > 8)
            {
                LeftHandShift(ref difference, difference.Length / 2);
                Array.Resize(ref difference, difference.Length / 2);
            }

            return difference;
        }

        public static void Multiply(byte[] multiplicated, byte[] multiplier, ref byte[] product,byte numeralSystem=2)
            {
            byte[] step = { 0, 0, 0, 0, 0, 0, 0, 1 };
            byte[] zero = { 0, 0, 0, 0, 0, 0, 0, 0 };
            product = multiplicated;
            if (CompareOPS(multiplicated, zero, '=') || CompareOPS(multiplier, zero, '=')) product = zero;
            else while (CompareOPS(multiplier, step, '>')) 
             {           
                    Addition(product, multiplicated, ref product,numeralSystem);
                    Substraction(multiplier,step,ref multiplier,numeralSystem);            
             }
            }
        public static void Division(byte[] dividend, byte[] divisor, ref byte[] quotient,byte numeralSystem=2)
        {
            byte[] step = { 0, 0, 0, 0, 0, 0, 0, 1 };
            byte[] start = { 0, 0, 0, 0, 0, 0, 0, 1 };
            byte[] zero = { 0, 0, 0, 0, 0, 0, 0, 0 };
            quotient= start;
            if (CompareOPS(dividend, zero, '=')) { quotient = zero; return; }
            if (CompareOPS(divisor, zero, '='))
                throw new System.ArgumentException("DIVISION BY ZERO, Divisor should not be null !");
            else               
            while (CompareOPS(dividend, divisor, '>'))
                {           
                    Substraction(dividend, divisor, ref dividend,numeralSystem);
                    Addition(quotient, step, ref quotient,numeralSystem);
                }
        }
        private static byte GetRemainder(byte[] firstArray, byte[] secondArray, byte carrier, ushort i,byte numeralSystem)
        {
            return (byte)((AddElements(firstArray, secondArray, i) + carrier) % numeralSystem);
        }
        private static byte Getquotient(byte[] firstArray, byte[] secondArray, byte carrier, ushort i,byte numeralSystem)
        {
            return (byte)((AddElements(firstArray, secondArray, i) + carrier) / numeralSystem);
        }
    }
}

