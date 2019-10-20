// using System;

// namespace myapp
// {
//     class Program
//     {

//         public static bool DoubleLetters(string word)
//         {
//             char[] charArr = word.ToCharArray();

//             for (int i = 0; i < charArr.Length - 1; i++)
//             {
//                 if (charArr[i] == charArr[i + 1])
//                     return true;
//             }

//             return false;
//         }
//         // Main program here
//         static void Main(string[] args)
//         {
//             string inputString1 = "Teststriing";
//             string inputString2 = "Teststring";
//             System.Console.WriteLine(DoubleLetters(inputString1));
//             System.Console.WriteLine(DoubleLetters(inputString2));
//         }
//     }
// }