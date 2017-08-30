namespace ArrayReverse.Implementation
{
    public class ArrayReverseManagerRecursively : IArrayReverseManager
    {
        public int[] Reverse(int[] array)
        {
            return ReverseRecursively(array,0,array.Length-1);
        }

        private static int[] ReverseRecursively(int[] array, int i, int j)
        {
            if (i >= j) return array;

            array[i] = array[j] + array[i];
            array[j] = array[i] - array[j];
            array[i] = array[i] - array[j];

            return ReverseRecursively(array, i + 1, j - 1);
        }
    }
}
