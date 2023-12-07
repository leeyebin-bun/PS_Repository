//using System;
//namespace PS_Repository_CSharp
//{
//	public class _525_OvenTime
//	{
//		static void Main(String[] args)
//		{
//			string[] input = Console.ReadLine().Split(' ');

//			int a = int.Parse(input[0]);
//			int b = int.Parse(input[1]);

//			int time = int.Parse(Console.ReadLine());

//			// 분 끼리만 더한다
//            int min = b + time;
//			// 60분이 넘어가지 않으면 그냥 hour 그대로 출력한다
//			int hour = a;

//			// 60분이면
//			if(min == 60)
//			{
//				hour++;
//				min = 0;
//			}

//			// 60분이 넘어가면
//			if(min > 60)
//			{
//				hour = (a + (min / 60)) % 24;
//				min = (b + time) % 60;
//			}

//			if(hour == 24)
//			{
//				hour = 0;
//			}

//            Console.WriteLine(hour + " " + min);
//		}
//	}
//}


//// 너...무 지저분하..ㄴㅐ..