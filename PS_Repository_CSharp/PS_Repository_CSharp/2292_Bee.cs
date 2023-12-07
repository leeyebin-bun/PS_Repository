//using System;

//namespace PS_Repository_CSharp
//{
//    public class Bee
//    {
//        static void Main(String[] args)
//        {
//            int input = int.Parse(Console.ReadLine());

//            int a = 1; //몇개의 방을 지나가야 되는지에 대한 변수
//            int b = 0; //값 비교를 위해 곱해줄 수

//            while ((input - (6 * b + 1)) > 0)
//            {
//                b = b + a++;
//            }
//            Console.Write(a);
//        }
//    }
//}

////1 + 6 ( 7 이하일땐 1 )
////7 + 12 ( 7이상 12이하일땐 2 )
////19 + 18 ( 19이상 37이하일땐 3 )