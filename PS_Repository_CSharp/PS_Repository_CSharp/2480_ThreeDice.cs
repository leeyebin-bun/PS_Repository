//using System;
//using System.Linq;
//namespace PS_Repository_CSharp
//{
//	public class _480_ThreeDice
//	{
//		static void Main(String[] args)
//		{
//			string input = Console.ReadLine();
//			string[] strArr = input.Split(' ');

//			var a = int.Parse(strArr[0]);
//			var b = int.Parse(strArr[1]);
//			var c = int.Parse(strArr[2]);

//			var money = 0;

//			if (a == b && b == c)
//			{
//				money = 10000 + c * 1000;
//			}
//			else if (a == b)
//			{
//				money = 1000 + a * 100;
//            }
//            else if (b == c)
//            {
//                money = 1000 + b * 100;
//            }
//            else if (a == c)
//            {
//                money = 1000 + a * 100;
//            }
//            else
//			{
//				money = int.Parse(strArr.Max()) * 100;
//			}

//			Console.WriteLine(money);
//		}
//	}
//}

///*
// * else if 를 저렇게 많이 쓰는 방법 .. 밖에 없나 . . .
// */