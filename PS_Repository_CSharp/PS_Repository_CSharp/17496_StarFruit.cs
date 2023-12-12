using System;
namespace PS_Repository_CSharp
{
	public class _7496_StarFruit
	{
		static void Main(String[] args)
		{
			string[] input = Console.ReadLine().Split(' ');

			int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int sum = int.Parse(input[3]);

			int output = 0;

			if(b%c == 1)
			{
                output = ((a / b) * c) * sum;
            }
			else
			{
                output = ((a / b - 1) * c) * sum;
            }
			

			Console.WriteLine(output);

        }
	}
}

