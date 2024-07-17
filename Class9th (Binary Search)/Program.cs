namespace Class9th__Binary_Search_
{
    internal class Program
    {
        static int BinarySearch(int target, int left, int right, int[] arr)
        {
            int pivot = (left + right) / 2;
            if (pivot == left)
            {
                if (arr[pivot] != target)
                {
                    return -1;
                }
            }

            if (target < arr[pivot])
            {
                right = pivot;
                return BinarySearch(target, left, right, arr);
            }

            else if (target > arr[pivot])
            {
                left = pivot;
                return BinarySearch(target, left, right, arr);
            }

            else
            {
                return pivot;
            }
        }

        static void Main(string[] args)
        {
            #region 이진 탐색
            // 탐색 범위를 반으로 나누어 찾는 값을 포함하는 범위를
            // 좁혀가는 방식으로 동작하는 탐색 알고리즘입니다.

            int[] arr = new int[] { 5, 6, 8, 11, 22, 33, 44, 50, 51, 79 };
            int pivot = 0, left = 0, right = arr.Length - 1;

            int target = 44;

            while (left < right)
            {
                pivot = (left + right) / 2;
                if (pivot == left)
                {
                    if (arr[pivot] != target)
                    {
                        Console.WriteLine("해당하는 값이 존재하지 않습니다.");
                        break;
                    }
                }

                if (target < arr[pivot])
                {
                    right = pivot - 1;
                }

                else if (target > arr[pivot])
                {
                    left = pivot + 1;
                }

                else
                {
                    Console.WriteLine("해당하는 값(" + target + ")은 " + pivot + "에 위치합니다.");
                    break;
                }
            }

            Console.WriteLine(BinarySearch(target, 0, arr.Length - 1, arr));



            #endregion
        }
    }
}
