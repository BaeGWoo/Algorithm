namespace Program
{
   
    internal class Program
    {
      
        static void Main(string[] args)
        {
            #region 계수 정렬
            // 데이터의 값을 직접 비교하지 않고, 단순하게
            // 각 숫자가 몇 개 있는 지 개수를 세어 저장한 다음
            // 정렬하는 알고리즘입니다.
            int[] number = new int[] { 1, 6, 6,6, 5, 1, 2, 3, 1, 2, 3, 6, 5, 4 };
            int[] count = new int[6];
            for(int i=0;i<number.Length; i++)
            {
                count[number[i]-1]++;
            }

            for(int i = 0; i < count.Length; i++)
            {
                Console.WriteLine(count[i]);
            }

            #endregion
        }
    }
}
