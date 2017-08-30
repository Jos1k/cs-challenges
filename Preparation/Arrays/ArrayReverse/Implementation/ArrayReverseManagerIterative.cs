namespace ArrayReverse.Implementation
{
    public class ArrayReverseManagerIterative: IArrayReverseManager
    {
        public int[] Reverse(int[] array)
        {
            int n = array.Length;
            int i = 0;
            int j = n - 1;
            while (i < j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
            return array;
        }
    }
}
