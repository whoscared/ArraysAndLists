using System;
using System.Collections.Generic;
using ArraysAndLists.Lists.Nodes;

namespace ArraysAndLists.Lists
{
    class DoubleLinkedList : List
    {
        private DoublePointerNode firstNode;
        private DoublePointerNode lastNode;

        public DoubleLinkedList(int value)
        {
            firstNode = new(value) { Previous = null };
            lastNode = new(value) { Next = null };
        }

        public override void Add(int value)
        {
            DoublePointerNode newNode = new(value);
            if (firstNode.Next == null)
            {
                firstNode.Next = newNode;
            }
            else
            {
                lastNode.Next = newNode;
            }

            newNode.Previous = lastNode;
            lastNode = newNode;

        }

        public override void Remove(int index)
        {
            var current = firstNode;
            DoublePointerNode prev = null;
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
                    current.Next.Previous = prev;
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

        public override void Swap(int first, int second)
        {

            List<DoublePointerNode> firstElements = new();
            List<DoublePointerNode> secondElements = new();

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

        public void ConsoleWrite()
        {
            var current = firstNode;
            while (current != null)
            {
                Console.Write(current);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("<->"); // да здравствуют зеленые стрелочки !!!!
                Console.ForegroundColor = ConsoleColor.White;
                current = current.Next;
            }
            Console.Write("null");
            Console.WriteLine();
        }
    }
}
