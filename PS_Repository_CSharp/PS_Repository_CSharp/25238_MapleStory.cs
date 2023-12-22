using System;
namespace PS_Repository_CSharp
{
	public class _5238_MapleStory
	{
		static void Main(String[] args)
		{
			string[] input = Console.ReadLine().Split(' ');

			int a = int.Parse(input[0]);
			int b = int.Parse(input[1]);

			int damage = 100 * a - a * b;


            if (damage > 100)
				Console.WriteLine(0);
			else
				Console.WriteLine(1);
		}
	}
}

