// using System;

// namespace myapp
// {
//     class Program
//     {
//         public static string RemoveFirstLast (string input)
//         {
//             if (input.Trim ().Length <= 2)
//             {
//                 return input;
//             }
//             else
//             {
//                 char[] inputChars = input.ToCharArray ();
//                 int arrLength = inputChars.Length;

//                 inputChars[arrLength - 1] = ' ';
//                 inputChars[0] = ' ';
//                 string outputString = new string (inputChars);
//                 return outputString.Trim ();
//             }
//         }
//         // Main program here
//         static void Main (string[] args)
//         {
//             string input = "Test";
//             System.Console.WriteLine (RemoveFirstLast (input));
//         }

//     }
// }