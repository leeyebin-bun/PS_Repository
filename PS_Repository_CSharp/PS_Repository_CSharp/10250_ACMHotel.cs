//using System;
//using System.Drawing;

//namespace PS_Repository_CSharp
//{
//    public class _0250_ACMHotel
//    {
//        static void Main(String[] args)
//        {
//            //            int testInput = int.Parse(Console.ReadLine());
//            //            string[] hwn = Console.ReadLine().Split(' ');
//            //            string[] hwn_2 = Console.ReadLine().Split(' ');


//            //            int h = int.Parse(hwn[0]);
//            //            int w = int.Parse(hwn[1]);
//            //            int n = int.Parse(hwn[2]);

//            //            int h_2 = int.Parse(hwn_2[0]);
//            //            int w_2 = int.Parse(hwn_2[1]);
//            //            int n_2 = int.Parse(hwn_2[2]);

//            //            int answer_h = n % h; // 층수
//            //            int answer_w = (n / h) + 1; // 호수

//            //            int answer_h_2 = n_2 % h_2;
//            //            int answer_w_2 = (n_2 / h_2) + 1;

//            //            // 꼭대기층 예외처리
//            //            if (answer_h == 0)
//            //            {
//            //                answer_h = h;
//            //                answer_w -= 1;
//            //            }

//            //            if (answer_h_2 == 0)
//            //            {
//            //                answer_h_2 = h_2;
//            //                answer_w_2 -= 1;
//            //            }


//            //            Console.WriteLine(answer_h + "0" + answer_w);
//            //            Console.WriteLine(answer_h_2 + "0" + answer_w_2);
//            //        }
//            //    }
//            //}
//            var inputTest = int.Parse(Console.ReadLine()!);

//            for (int i = 0; i < inputTest; i++)
//            {
//                var input = Console.ReadLine()!.Split(' ');
//                var h = int.Parse(input[0]);
//                var w = int.Parse(input[1]);
//                var n = int.Parse(input[2]);

//                var floor = n % h;
//                var numRoom = n / h + 1;

//                if (n % h == 0)
//                {
//                    floor = h;
//                    numRoom -= 1;
//                }

//                Console.Write(floor);
//                if (numRoom < 10)
//                    Console.Write("0");
//                Console.WriteLine(numRoom);
//            }

//        }
//    }
//}



