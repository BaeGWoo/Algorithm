namespace Class4th__Select_Sort_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 선택 정렬
            // 주어진 리스트 중에 최소값을 찾아서 맨 앞에 위치한 결과를 
            // 교체하는 방식으로 정렬하는 알고리즘입니다.

            int[] sel = { 9, 6, 7, 3, 5 };
            int size = sel.Length;
            for (int i = 0; i < size - 1; i++)
            {
                int min = sel[i];
                int position = i;
                for (int j = i; j < size; j++)
                {
                    if (sel[j] < min)
                    {
                        min = sel[j];
                        position = j;
                    }
                }

                int temp = sel[i];
                sel[i] = sel[position];
                sel[position] = temp;

                Console.Write(i + 1 + "회전 => ");
                for (int s = 0; s < sel.Length; s++)
                {
                    Console.Write(sel[s] + " ");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
