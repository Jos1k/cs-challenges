using System.Linq;

namespace ArrayRotation.Implementation
{
    public class TempArrayRotator:IArrayRotator
    {
        public int[] RotateLeft(int[] inputArray, int rotateTimes)
        {
            rotateTimes = rotateTimes % inputArray.Length;
            int shift = inputArray.Length - rotateTimes;
            int[] shiftArray = inputArray.Take(rotateTimes).ToArray();

            for (int i = 0; i < shift; i++)
            {
                inputArray[i] = inputArray[i + shiftArray.Length];
            }

            for (int i = 0; i < shiftArray.Length; i++)
            {
                inputArray[i + shift] = shiftArray[i];
            }
            return inputArray;
        }

        public int[] RotateRight(int[] inputArray, int rotateTimes)
        {
            rotateTimes = rotateTimes % inputArray.Length;
            int shift = inputArray.Length - rotateTimes;

            int[] shiftArray = inputArray.Skip(shift).Take(rotateTimes).ToArray();

            for (int i = shift - 1; i >= 0; i--)
            {
                inputArray[i + rotateTimes] = inputArray[i];
            }
            for (int i = 0; i < shiftArray.Length; i++)
            {
                inputArray[i] = shiftArray[i];
            }

            return inputArray;
        }
    }
}
