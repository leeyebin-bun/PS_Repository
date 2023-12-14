//using System;
//namespace PS_Repository_CSharp
//{
//	public class _547_Ball
//	{
//		static void Main(String[] args)
//		{
//			int input = int.Parse(Console.ReadLine());

//			// 초기상태에는 balls[1] 에만 공이 들어있다. 
//			int[] balls = { 0, 1, 0, 0 };

//			for(int i = 0; i < input; i++)
//			{
//				string[] cup = Console.ReadLine().Split(' ');

//				int cup_1 = int.Parse(cup[0]);
//				int cup_2 = int.Parse(cup[1]);

//				// 두 컵을 교환한다.
//				// 1 2 일때
//				int temp = balls[cup_1];
//				// temp = 1 , 공이 들어있다.
//				balls[cup_1] = balls[cup_2];
//                // balls[1] = balls[2]
//                // balls[cup_2]의 값을 balls[cup_1]에 할당한다.
//                balls[cup_2] = temp;
//				// balls[2] = 1
//				// balls[] = { 0 , 0 , 1 , 0 }

//            }

//			// 최종적으로 공이 있는 컵의 번호를 출력한다.
//			for(int i = 0; i < 4; i++)
//			{
//				if (balls[i] == 1) // 공이 있다면 (0아 아닌 1일때)
//				{
//                    Console.WriteLine(i);
//                }	
//			}
			
//		}
//	}
//}

//// 문제 난독 .. 8ㅅ8
