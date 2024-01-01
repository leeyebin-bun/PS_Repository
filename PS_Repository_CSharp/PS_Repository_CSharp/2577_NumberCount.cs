//using System;
//namespace PS_Repository_CSharp
//{
//	public class _577_NumberCount
//	{
//		static void Main(String[] args)
//		{
//			int a = int.Parse(Console.ReadLine());
//			int b = int.Parse(Console.ReadLine());
//			int c = int.Parse(Console.ReadLine());

//			int mul = a * b * c;

//			int[] answer = new int[10];
			
//			while (true)
//			{
//				if (mul == 0)
//				{
//					break;
//				}

//				int i = mul % 10; // mul 의 마지막 숫자
//				answer[i]++;  // i 가 7이라고 한다면 answer 배열의 7번째 카운트 +1
//				mul = mul / 10; // 17037300 , 1703730 , 170373 , 17037 , 1703 ....

//			}

//			for (int i = 0; i < answer.Length; i++)
//			{
//				Console.WriteLine(answer[i]);
//			}


//		}
//	}
//}

