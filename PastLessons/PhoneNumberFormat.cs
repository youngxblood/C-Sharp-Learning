// using System;

// namespace myapp
// {
//     class Program
//     {

//         public static void FormatPhoneNumber (int[] input)
//         {
//             string firstSet = "";
//             string secondSet = "";
//             string thirdSet = "";

//             for (int i = 0; i < 3; i++)
//             {
//                 firstSet = firstSet + input[i];
//             }
//             for (int i = 0; i < 3; i++)
//             {
//                 secondSet = secondSet + input[i];
//             }
//             for (int i = 0; i < 4; i++)
//             {
//                 thirdSet = thirdSet + input[i];
//             }

//             Console.WriteLine ("(" + firstSet + ") " + secondSet + "-" + thirdSet);
//         }

//         // Main program here
//         static void Main (string[] args)
//         {
//             int[] firstNumber = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
//             FormatPhoneNumber (firstNumber);
//         }

//     }
// }