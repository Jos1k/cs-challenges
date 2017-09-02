using System;

namespace FIrstMinMaxElements.Implementation
{
    public class TempArrayFirstMinMaxFinder : IFirstMinMaxFinder
    {
        public int[] FindFirstMaxElements(int[] input, int k)
        {
            int[] result = new int[k];
            Array.Copy(input, 0, result, 0, k);

            for (int i = k; i < input.Length; i++)
            {
                for (int j = 0; j < result.Length; j++)
                {
                    if (result[j] < input[i])
                    {
                        result[j] = input[i];
                        break;
                    }
                }
            }

            return result;
        }

        public int[] FindFirstMinElements(int[] input, int k)
        {
            throw new System.NotImplementedException();
        }
    }
}