//using System;
//namespace PS_Repository_CSharp
//{
//	public class _530_Clock
//	{
//		static void Main(String[] args)
//		{
//			string[] input = Console.ReadLine().Split(' ');
//			int time = int.Parse(Console.ReadLine());
//			int duration = 0;
//			int start_sec = 0;
			
//			int start_a = int.Parse(input[0]);
//            int start_b = int.Parse(input[1]);
//            int start_c = int.Parse(input[2]);

//			start_sec += start_a * 3600;
//			start_sec += start_b * 60;
//			start_sec += start_c % 60;

//			duration = time + start_sec;
			
//            Console.WriteLine((duration / 3600) % 24);
//            Console.WriteLine((duration % 3600) / 60);
//            Console.WriteLine(duration % 60);

//        }
//	}
//}

