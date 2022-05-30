namespace ArraysAndLists.Arrays
{
    class ConsistentArray : ArrayProcessing
    {
        private readonly int[] array;

        public ConsistentArray(int size)
        {
            array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
        }

        public int BinarySearch(int value)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (array[mid] == value)
                {
                    return mid;
                }

                if (array[mid] < value)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }

        public int[] GetArray()
        {
            return array;
        }
    }
}
