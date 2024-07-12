namespace Class2th__Sleave_of_Eratostenes_
{
    internal class Program
    {
        static public bool CheckNumber(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        static public bool CheckPrime(int num)
        {
            double pivot = Math.Sqrt(num) + 1;
            for (int i = 2; i < pivot; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        static public bool IsPrime(int num)
        {
            bool[] pivot = new bool[num + 1];
            int size = (int)Math.Sqrt(num) + 1;
            for (int i = 2; i < size; i++)
            {
                if (!pivot[i])
                {
                    for (int j = 2; ; j++)
                    {
                        if (i * j > num)
                            break;
                        pivot[i * j] = true;//합성수는 true 기본은 false
                    }
                }
            }


            for (int i = 2; i < num + 1; i++)
            {
                if (!pivot[i])
                    Console.Write(i + " ");
            }
            Console.WriteLine();

            return !pivot[num];

        }

        static void Main(string[] args)
        {
            #region 소수 판별
            int number;

            Console.WriteLine("number를 입력해 주세요\n");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckPrime(number));
            Console.WriteLine(IsPrime(number));

            #region 에라토스테네스의 체
            // 소수를 판정하는 방법으로, 자연수를 순서대로
            // 늘어놓은 표에서 합성수를 차례대로 지워나가면서
            // 소수의 목록을 얻어내는 방법입니다.


            #endregion


            #endregion
        }
    }
}
