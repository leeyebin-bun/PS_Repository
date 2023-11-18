//using System;

//namespace PS_Repository_CSharp
//{
//    public class _460_BinaryNumber
//    {
//        static void Main(String[] args)
//        {
//            int input = int.Parse(Console.ReadLine());

//            for (var i = 0; i < input; i++)
//            {
//                int n = int.Parse(Console.ReadLine()); // for문 밖에 있으면 새로운 n이 입력되고 사용된다.
//                int answer = 0;

//                while (n != 0)
//                {
//                    if (n % 2 == 1)
//                    {
//                        Console.Write(answer + " ");
//                    }

//                    n = n / 2;
//                    answer++;
//                }
//                Console.WriteLine(); // 각 입력 처리 후에 새 줄 추가
//            }
//        }
//    }
//}


////10진수 -> 2진수 : 2로 나누고 거꾸로