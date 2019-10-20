// using System;
// using System.Linq;

// namespace myapp
// {
//     class Program
//     {
//         public static double AverageWordLength(string str)
//         {
//             // Strips punctuation
//             str = new string(str.Where(c => !char.IsPunctuation(c)).ToArray());

//             string[] strArr = str.Split(' ');
//             double[] intArr = new double[strArr.Length];

//             for (int i = 0; i < strArr.Length; i++)
//             {
//                 intArr[i] = strArr[i].Length;
//             }

//             // Gets and returns total average of length divided by number of strings
//             double resultAverage = intArr.Sum() / intArr.Length;
//             resultAverage = Math.Round(resultAverage, 2);
//             return resultAverage;
//         }
//         // Main program here
//         static void Main(string[] args)
//         {
//             string inputStr = "A B Cccc.";
//             System.Console.WriteLine(AverageWordLength(inputStr));
//         }

//     }
// }