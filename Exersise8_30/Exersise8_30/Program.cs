using System;

namespace Exersise8_30
{
    public class Edge
    {
        public int First { get; set; }
        public int Second { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во вершин: ");
            int vertexCount = int.Parse(Console.ReadLine());
            int[] vertexes = new int[vertexCount];
            bool[] used = new bool[vertexCount];

            Console.WriteLine($"Введите {vertexCount} вершин: ");
            for (int i = 0; i < vertexCount; i++)
            {
                vertexes[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введите кол-во ребер: ");
            int edgesCount = int.Parse(Console.ReadLine());
            Edge[] edges = new Edge[edgesCount];

            for (int i = 0; i < edgesCount; i++)
            {
                edges[i] = new Edge();

                Console.WriteLine($"Введите первую вершину {i + 1} ребра: ");
                edges[i].First = int.Parse(Console.ReadLine());

                Console.WriteLine($"Введите вторую вершину {i + 1} ребра: ");
                edges[i].Second = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введите K");
            int k = int.Parse(Console.ReadLine());


            int notEmptyVertexCount = 0;

            for (int i = 0; i < edgesCount; i++)
            {
                for (int j = 0; j < vertexCount; j++)
                {
                    if (edges[i].First == vertexes[j] && !used[j])
                    {
                        used[j] = true;
                        notEmptyVertexCount++;
                    }
                    if (edges[i].Second == vertexes[j] && !used[j])
                    {
                        used[j] = true;
                        notEmptyVertexCount++;
                    }
                }
            }

            if (k <= vertexCount - notEmptyVertexCount)
            {
                for (int i = 0; i < vertexCount; i++)
                {
                    if (k == 0)
                    {
                        break;
                    }
                    if (!used[i])
                    {
                        Console.Write(vertexes[i] + " ");
                        k--;
                    }
                }
            }
            else
            {
                Console.WriteLine("Такого графа не существует");
            }
        }
    }
}
