using System;

namespace Exersise9_22
{
    public class Node
    {
        int Data;
        Node Next;
        Node Previous;

        public Node(int capacity, int index = 1)
        {
            if (capacity == 0)
                return;

            Data = index;
            Next = new Node(capacity - 1, index + 1);
            Next.Previous = this;

            if (index == 1)
                Previous = null;
        }

        public void Print()
        {
            if (Next == null)
                return;
            Console.Write(Data + " ");
            Next.Print();
        }

        public void Contains(int data)
        {
            if (Next == null)
            {
                Console.WriteLine("Элемент не найден");
                return;
            }
            if (Data == data)
            {
                Console.WriteLine("Элемент найден");
                return;
            }
            Next.Contains(data);
        }

        public static void Remove(ref Node node, int data)
        {
            if (node.Data == data)
            {
                if (node.Previous == null)
                {
                    node = node.Next;
                    node.Previous = null;
                }
                else
                {
                    node = node.Next;
                }
                Console.WriteLine("Элемент найден и удален");
                return;
            }
            if (node.Next == null)
            {
                Console.WriteLine("Элемент не найден");
                return;
            }
            Node.Remove(ref node.Next, data);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(int.Parse(Console.ReadLine()));
            node.Print();
            Console.WriteLine();
            node.Contains(10);
            Node.Remove(ref node, 11);
            node.Print();
        }
    }
}
