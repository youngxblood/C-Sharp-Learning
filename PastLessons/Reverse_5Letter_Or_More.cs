// using System;

// namespace myapp
// {
//     class Program
//     {

//         // Method to reverse a string, then return it as a new string
//         public string ReverseString (string input, int charCap)
//         {

//             string s;
//             input = input.Trim ();
//             string[] inputSentence = input.Split (' ');
//             string[] outputSentence = new string[inputSentence.Length];

//             for (int i = 0; i < inputSentence.Length; i++)
//             {
//                 char[] charArray = inputSentence[i].ToCharArray ();

//                 if (inputSentence[i].Length >= charCap)
//                 {
//                     Array.Reverse (charArray);
//                     s = new string (charArray);
//                 }
//                 else
//                 {
//                     s = new string (charArray);
//                 }
//                 outputSentence[i] = s;
//             }

//             string result = "";

//             for (int i = 0; i < outputSentence.Length; i++)
//             {
//                 result = result + outputSentence[i] + " ";
//             }
//             return result.Trim ();
//         }

//         // Main program here
//         static void Main (string[] args)
//         {
//             Program P = new Program ();
//             string userInput = Console.ReadLine();

//             System.Console.WriteLine ("The app is running:");
//             userInput = P.ReverseString (userInput, 5);
//             System.Console.WriteLine (userInput);
//             System.Console.ReadLine ();
//         }

//     }
// }