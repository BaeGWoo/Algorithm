namespace Class10th__Divide___Conquer_
{
    internal class Program
    {
        static int Divdie_Conquer(int[] arr, int left, int right)
        {
            int pivot = (left + right) / 2;

            if (left == right)
            {
                return arr[pivot];
            }

            else
            {
                int leftSide = Divdie_Conquer(arr, left, pivot);
                int rightSdie = Divdie_Conquer(arr, pivot + 1, right);
                return leftSide > rightSdie ? leftSide : rightSdie;
            }
        }
        static void Main(string[] args)
        {
            #region 분할 정복
            // 주어진 문제를 2개 이상의 부분으로 문제를 나눈 뒤 각 부분
            // 문제에 대한 답을 재귀 호출을 이용해서 계산한 다음, 그 답으로부터
            // 전체 문제의 답을 계산해내는 알고리즘입니다.

            // 분할(Divide) : 주어진 문제를 두 개 혹은 그 이상의 형식으로 나눈다.

            // 정복(Conquer) : 나누어진 문제를 재귀적으로 해결해서 나누어진 문제를 
            // 더 이상 나뉘어 문제를 풀 필요없을때까지 계속 분할합니다.

            // 통합(Combine) : 나누어서 해결한 문제들을 통합해서 원래 문제의 해당을 생성합니다.
            int[] arr = new int[] { 3, 6, 1, 5, 77, 4, 3, 19 };
            int[] test = new int[] { 5, 13, 2, 4 };
            Console.WriteLine(Divdie_Conquer(test, 0, test.Length - 1));
            #endregion
        }
    }
}
