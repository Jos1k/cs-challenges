namespace ArrayRotation.Implementation
{
    public class OneByOneArrayRotator:IArrayRotator
    {
        public int[] RotateLeft(int[] inputArray, int rotateTimes)
        {
            rotateTimes = rotateTimes % inputArray.Length;
            for (int i = 0; i < rotateTimes; i++)
            {
                int tempSlot = inputArray[0];
                for (int j = 1; j < inputArray.Length; j++)
                {
                    inputArray[j - 1] = inputArray[j];
                }
                inputArray[inputArray.Length - 1] = tempSlot;
            }
            return inputArray;
        }

        public int[] RotateRight(int[] inputArray, int rotateTimes)
        {
            rotateTimes = rotateTimes % inputArray.Length;
            for (int i = 0; i < rotateTimes; i++)
            {
                int tempSlot = inputArray[inputArray.Length - 1];
                for (int j = inputArray.Length-2; j >= 0; j--)
                {
                    inputArray[j + 1] = inputArray[j];
                }
                inputArray[0] = tempSlot;
            }
            return inputArray;
        }
    }
}
