//using System;
//namespace PS_Repository_CSharp
//{
//	public class _501_Measure
//	{
//		static void Main(String[] args)
//		{
//            string[] input = Console.ReadLine().Split();

//            int n = int.Parse(input[0]);
//            int k = int.Parse(input[1]);

//            List<int> answer = new List<int>();

//            for (var i = 1; i <= n; i++)
//            {
//                if (n % i == 0)
//                {
//                    answer.Add(i);
//                }

//                if (answer.Count >= k)
//                {
//                    Console.WriteLine(answer[k - 1]); 
//                    return;
//                }
//            }

//            Console.WriteLine(0); 
//        }
//	}
//}

