//using System;
//using static System.Net.Mime.MediaTypeNames;

//namespace PS_Repository_CSharp
//{
//    public class _4720_MilkFestival
//    {
//        static void Main(String[] args)
//        {

//            int storeCount = int.Parse(Console.ReadLine());
//            List<int> stores = Console.ReadLine().Split().Select(int.Parse).ToList();
//            int wantToDrink = 0;
//            int didDrink = 0;

//            for (int currentStoreIndex = 0; currentStoreIndex < storeCount; currentStoreIndex++)
//            {
//                int milk = stores[currentStoreIndex];

//                if (milk == didDrink) 
//                {
//                    wantToDrink++;

//                    if (didDrink == 2)
//                    {
//                        didDrink = 0;
//                    }
//                    else 
//                    {
//                        ++didDrink;
//                    }

//                }
//            }

//            Console.WriteLine(wantToDrink);
//        }
//    }
//}

