namespace Class8th__Two_Pointer_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 투 포인터
            // 두 개의 포인터를 두고 값들을 비교하여 
            // 문제를 해결하는 알고리즘입니다.

            // 1. 시작점과 끝점이 첫번째 원소의 인덱스를 가리키게 합니다.
            // 2. 현재 부분합이 M과 같다면 카운트합니다.
            // 3. 현재 부분합이 M보다 작다면 end를 1증가시킵니다.
            // 4. 현재 부분합이 M보다 크거나 같다면 start를 1증가시킵니다.

            int[] arr = new int[] { 1, 2, 5, 2, 3, 5 };
            int count = 0;
            int Start = 0, End = 0;
            int M = 5;
            for (Start = 0; Start < arr.Length;)
            {
                int temp = 0;
                if (Start == End)
                {
                    temp += arr[Start];
                }

                else
                {
                    for (int i = Start; i < End && i < arr.Length; i++)
                    {
                        temp += arr[i];
                    }
                }

                if (temp < M)
                {
                    End++;
                }
                else if (temp == M)
                {
                    Start++;
                    count++;
                }
                else
                    Start++;
            }

            Console.WriteLine(count);

            #endregion
        }
    }
}
