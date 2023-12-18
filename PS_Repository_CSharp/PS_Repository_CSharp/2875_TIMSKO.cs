//using System;
//namespace PS_Repository_CSharp
//{
//	public class _2875_TIMSKO
//	{
//		static void Main(String[] args)
//		{
//			string[] input = Console.ReadLine().Split(' ');

//			int girl = int.Parse(input[0]);
//			int boy = int.Parse(input[1]);
//			int intern = int.Parse(input[2]);

//			int team = 0;

//            // 인턴을 뺄 수 있으면서 여학생이 2명이상이어야 하고 남학생도 1명 이상일때만 최소 한팀이 나온다.
//            while (((girl-2)+(boy-1) >= intern) && (girl >= 2) && (boy >= 1)) 
//			{
//				team++;
//				girl -= 2;
//				boy -= 1;
//			}
			
//			Console.WriteLine(team);
//		}
//	}
//}

 