namespace Class3th__Bubble_Sort_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 버블 정렬
            // 서로 인접한 두 원소를 검사하여 정렬하는 알고리즘 입니다.

            int[] bubble = new int[] { 5, 32, 7, 1, 29 };

            int size = bubble.Length - 1;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i; j++)
                {
                    if (bubble[j] > bubble[j + 1])
                    {
                        int temp = bubble[j];
                        bubble[j] = bubble[j + 1];
                        bubble[j + 1] = temp;
                    }
                }

                Console.Write(i + 1 + "회전 => ");
                for (int s = 0; s < bubble.Length; s++)
                {
                    Console.Write(bubble[s] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < bubble.Length; i++)
            {
                Console.Write(bubble[i] + " ");
            }

            #endregion
        }
    }
}
