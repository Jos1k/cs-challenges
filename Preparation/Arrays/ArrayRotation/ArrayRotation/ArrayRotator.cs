using System;
using System.Linq;

namespace ArrayRotation
{
    public static class ArrayRotator
    {
        public static int[] RotateArray(int[] array, int rotateNumber)
        {
            int[] shiftArray = array.Take(array.Length - rotateNumber).ToArray();

            for (int i=0;i< rotateNumber; i++)
            {
                array[i] = array[i+ shiftArray.Length];
            }

            for (int i = 0; i < shiftArray.Length; i++)
            {
                array[i + rotateNumber] = shiftArray[i];
            }
            return array;
        }
    }
}
