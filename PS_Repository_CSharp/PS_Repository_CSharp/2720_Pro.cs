using System;
namespace PS_Repository_CSharp
{
	public class _720_Pro
	{
		static void Main(String[] args)
		{
			int test = int.Parse(Console.ReadLine());

			for(int i =0; i < test; i++)
			{

				int money = int.Parse(Console.ReadLine());

                int q = money / 25;
				money -= q * 25;
				int d = money / 10;
				money -= d * 10;
				int n = money / 5;
				money -= n * 5;
				int p = money / 1;

				Console.WriteLine(q + " " + d + " " + n + " " + p);
			}
		}
	}
}

