using System;
namespace PS_Repository_CSharp
{
	public class _750_NumSort
	{
		static void Main(String[] args)
		{
			int input = int.Parse(Console.ReadLine());
			List<int> answer = new List<int>();

			for(int i = 0; i < input; i++)
			{
                int sortNum = int.Parse(Console.ReadLine());
				answer.Add(sortNum);

					answer.Sort();
                
            }
            Console.WriteLine(answer);


        }
	}
}

