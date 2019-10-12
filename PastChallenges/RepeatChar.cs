// using System;
// using System.Text;

// namespace myapp
// {
//     /// <summary>
//     /// This program was for a challenge to parse an input string
//     ///  and return it with characters multiplied by an int.
//     /// </summary>

//     class Program
//     {
//         // REVIEW:  The function below was something I saw online.
//         //          I would like to study it a bit.
//         //          in: string[]
//         //          out: string
//         static string ConvertStringArrayToString(string[] inputArr)
//         {
//             // Concatenate all the elements into a StringBuilder.
//             StringBuilder sb = new StringBuilder();
//             foreach (string value in inputArr)
//             {
//                 sb.Append(value);
//                 // sb.Append('.');
//             }
//             return sb.ToString();
//         }

//         // SECTION: Function that takes two params and returns a string.
//         //          in: string str
//         //          in: int num
//         //          out: string
//         public static string Repeat(string str, int num)
//         {
//             string charMultiplied = "";
//             StringBuilder sb = new StringBuilder(charMultiplied);
//             char[] charArr = str.ToCharArray();
//             string[] strArr = new string[str.Length];

//             for (int i = 0; i < charArr.Length; i++)
//             {

//                 for (int a = 0; a < num; a++)
//                 {
//                     sb.Append(charArr[i]);
//                     charMultiplied = sb.ToString();
//                 }

//                 if (string.IsNullOrWhiteSpace(charMultiplied))
//                 {
//                     strArr[i] = " ";
//                     sb.Clear();
//                 }
//                 else
//                 {
//                     strArr[i] = charMultiplied;
//                     sb.Clear();
//                 }
//             }

//             string finalResult = ConvertStringArrayToString(strArr).Trim();
//             return finalResult;
//         }

//         // Main program here
//         static void Main(string[] args)
//         {
//             string input = "Test repeat.";
//             string output = Repeat(input, 5);

//             System.Console.WriteLine("The program has started!");
//             System.Console.WriteLine(output);
//             Console.ReadLine();
//         }
//     }
// }