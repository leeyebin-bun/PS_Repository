using System;
namespace PS_Repository_CSharp
{
	public class Strange
	{
		static void Main(String[] args)
		{
			string input = Console.ReadLine();
			string[] strArr = input.Split(' ');

			var a = long.Parse(strArr[0]);
			var b = long.Parse(strArr[1]);

			if (a >= 1 && b <= 100000)
			{
                Console.WriteLine((a + b) * (a - b));
            }
			 
		}
	}
}

// @ 를 써야 되는 줄 알았다 . ..