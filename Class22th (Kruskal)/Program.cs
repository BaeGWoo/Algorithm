namespace Class22th__Kruskal_
{
    public class Graph
    {
        int size;
        int sum;
        List<Edge> graph;
        int[] parent;

        public class Edge : IComparable<Edge>
        {
            int x, y, distance;

            public Edge(int x, int y, int distance)
            {
                this.x = x;
                this.y = y;
                this.distance = distance;
            }

            public int X
            {
                get { return x; }
                set { x = value; }
            }

            public int Y
            {
                get { return y; }
                set { y = value; }
            }

            public int Distance
            {
                get { return distance; }
                set { distance = value; }
            }

            public int CompareTo(Edge? other)
            {
                return Distance.CompareTo(other.Distance);
            }
        }

        public Graph()
        {
            size = 8;
            sum = 0;
            graph = new List<Edge>();
            parent = new int[size];
            for (int i = 1; i < size; i++)
            {
                parent[i] = i;
            }
        }

        public void Insert(int x, int y, int distance)
        {
            Edge newEdge = new Edge(x, y, distance);
            graph.Add(newEdge);
        }


        public void InsertSort()
        {
            for (int i = 0; i < graph.Count; i++)
            {
                int pivot = graph[i].Distance;
                int temp = i;
                for (int j = i; j < graph.Count; j++)
                {
                    if (graph[j].Distance < pivot)
                    {
                        temp = j;
                        pivot = graph[j].Distance;
                    }
                }

                Edge tempEdge = graph[i];
                graph[i] = graph[temp];
                graph[temp] = tempEdge;
            }
        }




        public void Kruskal()
        {
            //InsertSort();
            graph.Sort();

            for (int i = 0; i < graph.Count; i++)
            {
                if (!Same(graph[i].X, graph[i].Y))
                {
                    sum += graph[i].Distance;
                    Union(graph[i].X, graph[i].Y);
                    Console.WriteLine(graph[i].X + " -> " + graph[i].Y + " : " + graph[i].Distance + "(" + sum + ")");
                }
            }
            Console.WriteLine("SUM : " + sum);

        }

        public void Union(int x, int y)
        {
            x = Find(x);
            y = Find(y);

            if (Same(x, y))
                return;
            else
            {
                int p = x < y ? x : y;
                int c = x > y ? x : y;
                parent[c] = p;
            }

        }

        public int Find(int x)
        {
            if (parent[x] == x)
                return x;
            else
            {
                return parent[x] = Find(parent[x]);
            }
        }

        public bool Same(int x, int y)
        {
            return Find(x) == Find(y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 신장 트리
            // 그래프의 모든 정점을 포함하면서 사이클이 존재하지 않는 그래프로
            // 그래프의 모든 정점을 최소 비용으로 연결하는 트리입니다.

            // 그래프의 정점의 수가 n개일 때, 간선의 수는 n-1개입니다.
            Graph graph = new Graph();
            graph.Insert(1, 7, 12);
            graph.Insert(7, 4, 13);
            graph.Insert(4, 1, 28);
            graph.Insert(4, 2, 24);
            graph.Insert(1, 5, 17);
            graph.Insert(2, 1, 73);
            graph.Insert(2, 5, 62);
            graph.Insert(5, 6, 40);
            graph.Insert(5, 3, 20);
            graph.Insert(3, 6, 35);

            // 최소 비용 신장 트리
            // 그래프의 간선들의 가중치 합이 최소인 신장 트리


            graph.Kruskal();
            #endregion
        }
    }
}
