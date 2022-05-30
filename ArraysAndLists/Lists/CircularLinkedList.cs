using System;
using System.Collections.Generic;
using ArraysAndLists.Lists.Nodes;

namespace ArraysAndLists.Lists
{
    class CircularLinkedList : List
    {
        private SinglePointerNode firstNode;
        private SinglePointerNode lastNode;

        public CircularLinkedList(int value)
        {
            firstNode = new(value);
            lastNode = new(value);
            lastNode.Next = firstNode;
        }
        public override void Add(int value)
        {
            SinglePointerNode newNode = new(value);
            if (firstNode.Next == null)
            {
                firstNode.Next = newNode;
            }
            else
            {
                lastNode.Next = newNode;
            }
            newNode.Next = firstNode;
            lastNode = newNode;

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
                        lastNode.Next = current.Next;
                        return;
                    }
                    else if (current == lastNode)
                    {
                        prev.Next = firstNode;
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

        public override void Swap(int first, int second)
        {
            List<SinglePointerNode> firstElements = new();
            List<SinglePointerNode> secondElements = new();

            var current = firstNode;
            do
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
            } while (current != firstNode);

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
            Console.Write(firstNode.Data);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("->"); // да здравствуют зеленые стрелочки !!!!
            Console.ForegroundColor = ConsoleColor.White;
            var current = firstNode.Next;
            while (current != firstNode)
            {
                Console.Write(current);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("->"); // да здравствуют зеленые стрелочки !!!!
                Console.ForegroundColor = ConsoleColor.White;
                current = current.Next;
            }
            Console.Write(firstNode.Data);
            Console.WriteLine();
        }
    }
}
