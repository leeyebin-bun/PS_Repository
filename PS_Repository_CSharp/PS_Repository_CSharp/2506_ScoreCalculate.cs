using System;

namespace PS_Repository_CSharp
{
    public class _506_ScoreCalculate
    {
        static void Main(String[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int total = 0;
            int score = 0;

            string[] inputNumbers = Console.ReadLine().Split(' ');

            for (int i = 0; i < input; i++)
            {
                int b = int.Parse(inputNumbers[i]);

                if (b == 1)
                {
                    score++;
                    total += score;
             
                }
                else
                {
                    score = 0;
                }
            }

            Console.WriteLine(total);
        }
    }
}
