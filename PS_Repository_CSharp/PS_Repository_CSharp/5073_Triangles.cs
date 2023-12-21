//using System;
//namespace PS_Repository_CSharp
//{
//	public class _073_Triangles
//	{
//		static void Main(String[] args)
//		{
//			for (int i = 0; i < 5; i++)
//			{
//				string[] input = Console.ReadLine().Split(' ');

//				int a = int.Parse(input[0]);
//				int b = int.Parse(input[1]);
//				int c = int.Parse(input[2]);

//				if (a == 0 && b == 0 && c == 0)
//				{
//					return;
//				}

//				if (a >= b + c || b >= a + c || c >= a + b)
//				{
//					Console.WriteLine("Invalid");
//				}
//				else if (a == b && b == c)
//				{
//					Console.WriteLine("Equilateral");
//				}
//				else if (a == b || b == c || a == c)
//				{
//					Console.WriteLine("Isosceles");
//				}
//				else if (a != b && b != c || a != c)
//				{
//					Console.WriteLine("Scalene");
//				}

//			}
//		}
//	}
//}

