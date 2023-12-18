//using System;
//namespace PS_Repository_CSharp
//{
//	public class _152_WordsCount
//	{
//		static void Main(String[] args)
//		{
//			//방법 1.
//			string[] word = Console.ReadLine().Split(' ');	
//			int answer = word.Length;

//			if (word[0] == "") // 맨앞이 공백일때
//			{
//				answer--;
//			}

//			if (word[word.Length-1] == "") // 맨뒤가 공백일때
//			{
//				answer--;
//			}

//			Console.Write(answer);

//			//방법 2.			
//			List<string> input = new List<string>(Console.ReadLine().Split(' '));

//			input.RemoveAll(string.IsNullOrEmpty); //빈 문자열 제거

//			Console.WriteLine(input.Count);
			
			
//		}
//	}
//}
