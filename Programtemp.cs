// using System;

// namespace myapp
// {
//     class Program
//     {

//         public static int[] IndexOfCapitals (string str)
//         {
//             // capitalIndex = a character array of the user's input string
//             char[] capitalIndex = str.ToCharArray ();
//             // capitalResult is used to hold
//             string resultString = "";
//             // int[] capitalResult = new int[1];  MIGHT HAVE TO BRING BACK
//             // int arrCounter = 0; MIGHT HAVE TO BRING BACK

//             for (int i = 0; i < capitalIndex.Length; i++)
//             {
//                 bool isUpper = Char.IsUpper (capitalIndex[i]);

//                 if (isUpper == true)
//                 {
//                     int a = Array.IndexOf (capitalIndex, capitalIndex[i]); // This is working correctly!
//                     // Array.Resize(ref capitalResult, capitalResult.Length + arrCounter); MIGHT HAVE TO BRING BACK
//                     // capitalResult[arrCounter] = a;  MIGHT HAVE TO BRING BACK
//                     resultString = resultString + a + " ";
//                     // arrCounter++;
//                 }
//                 else
//                 {
//                     isUpper = false;
//                 }
//             }

//             resultString = resultString.Trim();
//             string[] stringArr = resultString.Split(" ");
//             int[] resultArr = new int[stringArr.Length];

//             for (int i = 0; i < stringArr.Length; i++)
//             {
//                 resultArr[i] = stringArr[i];
//             }
            
//             return capitalResult;
//         }
//         // Main program here
//         static void Main (string[] args)
//         {
//             string str = "TestStringGGG";
//             int[] result = IndexOfCapitals (str);
//             Console.ReadLine ();
//         }

//     }
// }