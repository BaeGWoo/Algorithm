namespace Class23th__Prefix_Sum_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 누적합
            // 특정한 배열이 있을 때 해당 배열까지의 합을 의미합니다.

            int[] arr = new int[] { 7, 3, 4, 5, 1 };
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] += arr[i - 1];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int cur = arr[i];
                if (i != 0)
                    cur -= arr[i - 1];
                Console.WriteLine("누적합 : " + arr[i] + " (Original -> " + cur + ")");
            }

            #endregion
        }
    }
}
