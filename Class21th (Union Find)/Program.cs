namespace Class21th__Union_Find_
{
    public class Graph
    {
        private int[] parent;
        private int size;

        public Graph()
        {
            size = 7;
            parent = new int[size];
            for (int i = 0; i < size; i++)
            {
                parent[i] = i;
            }
        }

        public void Union(int x, int y)
        {
            x = Find(x);
            y = Find(y);

            // 부모가 같다면 이미 합쳐져 있으니 바로 반환
            if (Same(x, y))
                return;

            // 부모가 같지 않다면 작은 값이 큰 값의 부모로 설정
            else
            {
                int p = x > y ? x : y;
                int c = x < y ? x : y;

                parent[p] = c;
            }
        }

        public int Find(int child)
        {
            // 인덱스 값과 부모값이 일치한다면 현재 인덱스를 루트로 반환
            if (parent[child] == child)
                return child;

            // 인덱스 값이 부모값과 다르다면 루트를 찾아 재귀
            else
                return parent[child] = Find(parent[child]);
        }

        public bool Same(int c1, int c2)
        {
            return Find(c1) == Find(c2);
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 유니온 파인드
            // 여러 노드가 존재할 때 어떤 두 개의 노드를 같은 집합으로
            // 묶은 다음 어떤 두 노드가 같은 집합에 있는 지 확인하는 알고리즘입니다.

            Graph graph = new Graph();
            graph.Union(2, 3);
            graph.Union(1, 3);



            Console.WriteLine(graph.Same(2, 1));
            Console.WriteLine(graph.Same(2, 3));
            Console.WriteLine(graph.Same(1, 3));

            #endregion

        }
    }
}
