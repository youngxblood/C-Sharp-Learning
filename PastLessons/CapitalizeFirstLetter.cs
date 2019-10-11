// using System;
// using System.Text;

// // SECTION 
// // Capitalize the First Letter of Each Word
// // https://edabit.com/challenge/uz4r69EHHSQMosT8D

// namespace myapp
// {
//     class Program
//     {
//         static string ForceFirstCharToUpper(string word)
//         {
//             char[] letters = word.ToCharArray();
//             if (Char.IsNumber(letters[0]))
//                 return word;
//             else
//             {
//                 letters[0] = Char.ToUpper(letters[0]);
//                 string resultStr = new string(letters);
//                 return resultStr;
//             }

//         }

//         public static string MakeTitle(string str)
//         {
//             string[] strArr = str.Split(" ");

//             for (int i = 0; i < strArr.Length; i++)
//             {
//                 strArr[i] = ForceFirstCharToUpper(strArr[i]);
//             }

//             string resultStr = string.Join(" ", strArr);
//             return resultStr;
//         }

//         // public static string MakeTitle(string str)
//         // {
//         //     string[] strArr = str.Split(" ");
//         //     StringBuilder sb = new StringBuilder(); 

//         //     for (int i = 0; i < strArr.Length; i++)
//         //     {
//         //         strArr[i] = strArr[i].ToLower();
//         //         sb = strArr[i].ToString();
//         //     }
//         // }

//         // Main program here
//         static void Main(string[] args)
//         {
//             string testStr = "test TeEEst";
//             System.Console.WriteLine(MakeTitle(testStr));
//         }

//     }
// }