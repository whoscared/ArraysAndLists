using System;

namespace ArraysAndLists.Arrays
{
    class RandomArray : ArrayProcessing
    {
        private int[] array;
        public RandomArray(int size)
        {
            array = new int[size];
            Random random = new();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }
        }

        public int[] GetArray()
        {
            return array;
        }
    }
}
