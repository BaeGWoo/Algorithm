namespace Class19th__Breath_First_Search_
{
    internal class Program
    {
        public class Graph
        {
            bool[] visited;
            List<int>[] list;
            Queue<int> queue;

            int size;

            public Graph()
            {
                size = 8;
                queue = new Queue<int>();
                visited = new bool[size];
                list = new List<int>[size];

                for (int i = 0; i < size; i++)
                {
                    list[i] = new List<int>();
                }
            }


            public void Insert(int vertex, int edge)
            {
                list[vertex].Add(edge);
                list[edge].Add(vertex);
            }

            public void Show()
            {
                for (int i = 0; i < list.Length; i++)
                {
                    Console.Write("[" + i + "] ");
                    for (int j = 0; j < list[i].Count; j++)
                    {
                        Console.Write(list[i][j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            public void BFS(int root)
            {
                queue.Enqueue(root);
                visited[root] = true;

                while (queue.Count > 0)
                {
                    int cur = queue.Dequeue();
                    Console.Write(cur + " ");

                    for (int i = 0; i < list[cur].Count; i++)
                    {
                        if (visited[list[cur][i]] == false)
                        {
                            queue.Enqueue(list[cur][i]);
                            visited[list[cur][i]] = true;
                        }
                    }

                }//while
            }



        }

        static void Main(string[] args)
        {
            #region 너비 우선 탐색
            // 시작 정점을 방문한 후 시작 정점에 인접한 모든 정점들을
            // 우선 방문하는 방법입니다.

            // 더 이상 방문하지 않은 정점이 없을 때까지 방문하지 
            // 않은 모든 정점들에 대해서도 너비 우선 탐색을 적용합니다.

            Graph graph = new Graph();
            graph.Insert(1, 2);
            graph.Insert(1, 3);

            graph.Insert(2, 3);
            graph.Insert(2, 4);
            graph.Insert(2, 5);

            graph.Insert(3, 6);
            graph.Insert(3, 7);

            graph.Insert(4, 5);

            graph.Insert(6, 7);

            graph.Show();
            Console.WriteLine();
            graph.BFS(1);
            #endregion
        }
    }
}
