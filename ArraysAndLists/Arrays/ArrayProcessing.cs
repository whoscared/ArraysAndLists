using System;

namespace ArraysAndLists.Arrays
{
    public abstract class ArrayProcessing
    {
        public int SearchValue(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        public int[] Insert(int[] old, int index, int value)
        {
            int[] newArray = new int[old.Length + 1];
            newArray[index + 1] = value;
            int inserted = 0;

            for (int i = 0; i < old.Length + 1; i++)
            {
                if (i == index + 1)
                {
                    inserted++;
                    continue;
                }

                newArray[i] = old[i - inserted];
            }

            return newArray;
        }

        public void Remove(int[] old, int index)
        {
            int[] newArray = new int[old.Length - 1];
            int deleted = 0;
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i == index)
                {
                    deleted++;
                    continue;
                }
                else
                {
                    newArray[i] = old[i - deleted];
                }
            }
        }

        public void ConsoleWrite(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
