namespace Class_16th__Euclidean_Algorithm_
{
    internal class Program
    {
        static int Euclid(int num1, int num2)
        {
            int A = num1 > num2 ? num1 : num2;
            int B = num1 == A ? num2 : num1;
            int C = A % B;

            if (C == 0)
            {
                return B;
            }

            else
                return Euclid(B, C);
        }

        static void Main(string[] args)
        {
            #region 유클리드 호제법
            // 2개의 자연수 또는 정식의 최대공약수를 구하는 알고리즘으로,
            // 두 수가 서로 상대방 수를 나누어서 원하는 수를 얻어내는 알고리즘입니다.

            Console.WriteLine(Euclid(78696, 19332));

            // 두 수 중에서, 큰 수(A)를 작은수(B)로 나눈 다음
            // 작은 수(B)를 큰 수를 작은 수로 나눈 나머지(C) 로 나눠서
            // 나머지가 0일때까지 반복합니다.
            #endregion
        }
    }
}
