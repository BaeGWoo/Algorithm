namespace Program
{
   
    internal class Program
    {
        static public bool CheckNumber(int num)
        {
            for(int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        static public bool CheckPrime(int num)
        {
            double pivot=Math.Sqrt(num);
            for(int i = 2; i < pivot; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        static public bool IsPrime(int num)
        {
            bool[] pivot= new bool[(int)(Math.Sqrt(num))];
            for(int i = 2; i < pivot.Length; i++)
            {
                for(int j=1; ; j++)
                {
                    int temp = i;

                }
            }


            return true;
        }

        static void Main(string[] args)
        {
            #region 소수 판별
            int number;

            Console.WriteLine("number를 입력해 주세요\n");
            number=int.Parse(Console.ReadLine());
            Console.WriteLine(CheckPrime(number));

            #region 에라토스테네스의 체
            // 소수를 판정하는 방법으로, 자연수를 순서대로
            // 늘어놓은 표에서 합성수를 차례대로 지워나가면서
            // 소수의 목록을 얻어내는 방법입니다.


            #endregion

            #endregion
        }
    }
}
