//using System;
//namespace PS_Repository_CSharp
//{
//	public class _884_AlarmClock
//	{
//		static void Main(String[] args)
//		{
//			string[] input = Console.ReadLine().Split(' ');

//			int h = int.Parse(input[0]);
//			int m = int.Parse(input[1]);

//			if (h <= 23 && m <= 59)
//			{
//				//if (h == 0)
//				//	h = 24;

//				int time_h = h * 60;
//				int allTime = (time_h + m) - 45;

//				int early_h = allTime / 60;
//				int early_m = allTime % 60;

//				if (allTime < 0) //음수일때
//				{
//                    early_h = 23;
//                    early_m = 60 + allTime;
//                }
					
//				Console.Write(early_h + " ");
//				Console.Write(early_m);
//			}

//		}
//	}
//}

////어려워따 . .
