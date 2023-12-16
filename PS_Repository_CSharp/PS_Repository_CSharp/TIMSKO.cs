using System;
namespace PS_Repository_CSharp
{
	public class TIMSKO
	{
		static void Main(String[] args)
		{
			string[] input = Console.ReadLine().Split(' ');

			int girl = int.Parse(input[0]);
			int boy = int.Parse(input[1]);
			int intern = int.Parse(input[2]);

			int team = 0;

			team = (girl % 2) + (boy % 1) - intern;

			Console.WriteLine(team);
		}
	}
}

