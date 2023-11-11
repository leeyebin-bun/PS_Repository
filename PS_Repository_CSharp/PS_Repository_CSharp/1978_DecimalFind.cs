//using System;
//namespace PS_Repository_CSharp
//{
//	public class _978_DecimalFind
//	{
//		static void Main(String[] args)
//		{
//			int input = int.Parse(Console.ReadLine());
//			string word = Console.ReadLine();
//			string[] input_2 = word.Split();
//			int answer = input;

//			for(int i = 0; i < input; i++)
//			{
//				if (int.Parse(input_2[i]) == 1) // 1은 소수에서 제외
//				{
//					answer--;
//					continue;
//				}
//				for(int j = 2; j < int.Parse(input_2[i]); j++)
//				{
//					if (int.Parse(input_2[i]) % j == 0) // 나머지가 0이 나오면 소수가 아니므로 0이 나오는 수 제외
//					{
//						answer--;
//						break;
//					}
//				}
//			}
		
//			Console.WriteLine(answer);
//		}
//	}
//}

