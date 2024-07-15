namespace Class5th__Insert_Sort_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 삽입 정렬
            // 데이터를 하나씩 확인하면서 이미 정렬된 부분과 비교하여 
            // 자신의 위치를 찾아 삽입하는 방식으로 정렬하는 알고리즘입니다.

            int[] insertArr = new int[] { 8, 5, 6, 2, 4 };
            int keyValue;

            for (int i = 1; i < insertArr.Length; i++)
            {
                keyValue = insertArr[i];

                for (int j = i; j > 0; j--)
                {
                    if (keyValue < insertArr[j - 1])
                    {
                        insertArr[j] = insertArr[j - 1];

                        if (j - 1 == 0)
                        {
                            insertArr[j - 1] = keyValue;
                        }
                    }

                    else
                    {
                        insertArr[j] = keyValue;
                        break;
                    }
                }
                Console.Write(i + "회전 => ");
                for (int s = 0; s < insertArr.Length; s++)
                {
                    Console.Write(insertArr[s] + " ");
                }
                Console.WriteLine();
            }


            for (int i = 0; i < insertArr.Length; i++)
            {
                Console.Write(insertArr[i] + " ");
            }
            #endregion
        }
    }
}
