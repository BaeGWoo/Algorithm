using System.ComponentModel.DataAnnotations;

namespace Program
{
  
   
    internal class Program
    {
        static public void Test(int n)
        {
            int sum = 0;
            for(int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == n)
            {
                Console.WriteLine("완전수입니다.");
            }

            else
            {
                Console.WriteLine("완전수가 아닙니다.");
            }
        }


        static void Main(string[] args)
        {
            Test(222);
            
        }
    }
}
