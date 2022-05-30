using System;
using System.Collections.Generic;
using ArraysAndLists.Lists.Nodes;

namespace ArraysAndLists.Lists
{
    class SortedLinkedList : List
    {
        private SinglePointerNode firstNode;

        public SortedLinkedList(int value)
        {
            firstNode = new SinglePointerNode(value);
        }

        public override void Add(int data)
        {
            SinglePointerNode prev = null;
            SinglePointerNode current = firstNode;

            SinglePointerNode newNode = new(data);

            while (current != null && current.Data < data)
            {
                prev = current;
                current = current.Next;
            }

            if (prev == null) // Ставьте лайки, кто не любит далеко ходить
            {
                newNode.Next = firstNode;
                firstNode = newNode;
                return;
            }

            // вы пришли сюда
            prev.Next = newNode;
            newNode.Next = current;
        }

        public override void Remove(int index)
        {
            var current = firstNode;
            SinglePointerNode prev = null;
            int idx = 0;

            while (current != null)
            {
                if (idx == index)
                {
                    if (prev == null)
                    {
                        firstNode = current.Next;
                        return;
                    }

                    prev.Next = current.Next;
                    Console.WriteLine("Success delete");
                    return;
                }

                idx++;
                prev = current;
                current = current.Next;
            }

            Console.WriteLine("=(");
        }

        public override void SearchByIndex(int index)
        {
            var current = firstNode;
            int idx = 0;

            while (current != null)
            {
                if (idx == index)
                {
                    Console.WriteLine("Found! " + current.Data);
                    return;
                }
                idx++;
                current = current.Next;
            }

            Console.WriteLine("Not found");
        }

        public override void SearchValue(int value)
        {
            var current = firstNode;
            int idx = 0;

            while (current != null)
            {
                if (current.Data == value)
                {
                    Console.WriteLine("Found at: " + idx);
                    return;
                }
                idx++;
                current = current.Next;
            }

            Console.WriteLine("Not found");
        }

        public void ConsoleWrite()
        {
            var current = firstNode;
            while (current != null)
            {
                Console.Write(current);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("->"); // да здравствуют зеленые стрелочки !!!!
                Console.ForegroundColor = ConsoleColor.White;
                current = current.Next;
            }
            Console.Write("null");
            Console.WriteLine();
        }

        public override void Swap(int first, int second)
        {
            List<SinglePointerNode> firstElements = new();
            List<SinglePointerNode> secondElements = new();

            var current = firstNode;
            while (current != null)
            {
                if (current.Data == first)
                {
                    firstElements.Add(current);
                }
                else if (current.Data == second)
                {
                    secondElements.Add(current);
                }
                current = current.Next;
            }

            if (firstElements.Count == 0 || secondElements.Count == 0)
            {
                Console.WriteLine("error");
            }
            while (firstElements.Count > 0 && secondElements.Count > 0)
            {
                var element = firstElements[0];
                var anotherElement = secondElements[0];

                element.Data = second;
                anotherElement.Data = first;

                firstElements.RemoveAt(0);
                secondElements.RemoveAt(0);
            }
        }
    }
}
