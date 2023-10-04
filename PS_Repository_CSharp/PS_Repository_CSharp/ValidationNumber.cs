using System;
namespace PS_Repository_CSharp
{
	public class ValidationNumber
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string[] inputArr = input.Split(' ');

			int a = int.Parse(inputArr[0]);
            int b = int.Parse(inputArr[1]);
            int c = int.Parse(inputArr[2]);
            int d = int.Parse(inputArr[3]);
            int e = int.Parse(inputArr[4]);

			Console.WriteLine((Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2) + Math.Pow(d, 2) + Math.Pow(e, 2)) % 10);
        }
	}
}

