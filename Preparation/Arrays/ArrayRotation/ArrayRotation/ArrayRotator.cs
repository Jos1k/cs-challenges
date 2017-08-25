using System;
using System.Linq;

namespace ArrayRotation
{
    public static class ArrayRotator
    {

        public static int[] RotateArrayLeft(int[] array, int rotateNumber)
        {
            rotateNumber = rotateNumber % array.Length;
            int shift = array.Length - rotateNumber;
            int[] shiftArray = array.Take(rotateNumber).ToArray();

            for (int i=0;i< shift; i++)
            {
                array[i] = array[i+ shiftArray.Length];
            }

            for (int i = 0; i < shiftArray.Length; i++)
            {
                array[i + shift] = shiftArray[i];
            }
            return array;
        }

        public static int[] RotateArrayRight(int[]array, int rotateNumber)
        {
            rotateNumber = rotateNumber % array.Length;
            int shift = array.Length - rotateNumber;
            int[] shiftArray = array.Skip(shift).Take(rotateNumber).ToArray();

            for (int i = shift-1; i >=0 ; i--)
            {
                array[i + rotateNumber] = array[i];
            }
            for (int i = 0; i < shiftArray.Length; i++)
            {
                array[i] = shiftArray[i];
            }

            return array;
        }
    }
}
