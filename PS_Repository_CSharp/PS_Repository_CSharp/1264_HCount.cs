//using System;
//namespace PS_Repository_CSharp
//{
//    public class _264_HCount
//    {
//        static void Main(String[] args)
//        {
            
//            while (true) //무한루프
//            {
//                string s = Console.ReadLine().ToUpper();
//                var answer = 0;

//                if (s.Equals("#"))
//                {
//                    return;
//                }
//                else
//                {
//                    for (int i = 0; i < s.Length; i++)
//                    {
//                        if (s[i].Equals('A') || s[i].Equals('E') || s[i].Equals('I') || s[i].Equals('U') || s[i].Equals('O'))
//                        {
//                            answer++;
                            
//                        }
                       
//                    }
                
//                }
//                Console.WriteLine(answer);
//            }
            
//        }
//    }
//}

///*
// *  ' == ' : 객체 자체의 동일성을 비교하는 것. 메모리상에서 주어진 문자열이 위치하는 영역이 동일한지 확인
// *  ' equals ' : 위치는 상관없이 실제 문자열의 각 문자 하나하나가 모두 동일한지 확인
// *  
// *  */