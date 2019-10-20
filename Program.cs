using System;

// Resources:
// String.EndsWith Method: https://docs.microsoft.com/en-us/dotnet/api/system.string.endswith?view=netframework-4.8

namespace myapp
{
    class Program
    {
        // Function that limits the '!' or '?' characters at the end of the last word in a sentence to 1
        // TODO: Figure out a more elegant solution
        public static string NoYelling(string phrase)
        {
            string[] stringArr = phrase.Split(' ');
            string lastWord = stringArr[stringArr.Length - 1].Trim();

            if (lastWord.EndsWith("?"))
            {
                do
                {
                    lastWord = lastWord.Remove(lastWord.Length - 1);
                } while (lastWord.EndsWith("?") || lastWord.EndsWith("!"));

                lastWord = lastWord + "?";
            }

            else if (lastWord.EndsWith("!"))
            {
                do
                {
                    lastWord = lastWord.Remove(lastWord.Length - 1);
                } while (lastWord.EndsWith("?") || lastWord.EndsWith("!"));

                lastWord = lastWord + "!";
            }

            stringArr[stringArr.Length - 1] = lastWord;
            string result = string.Join(" ", stringArr);
            return result;
        }
        // Main program here
        static void Main(string[] args)
        {
            string inputStr1 = "This is a test string.";
            string inputStr2 = "This is a test string!!!!!!";
            string inputStr3 = "This is a test string?????";
            string inputStr4 = "This is a test string!!??!";

            System.Console.WriteLine(NoYelling(inputStr1));
            System.Console.WriteLine(NoYelling(inputStr2));
            System.Console.WriteLine(NoYelling(inputStr3));
            System.Console.WriteLine(NoYelling(inputStr4));

        }

    }
}

// public static string NoYelling(string phrase)
// {
//     string[] stringArr = phrase.Split(' ');
//     string lastWord = stringArr[stringArr.Length - 1].Trim();

//     if (lastWord.EndsWith("?"))
//     {
//         do
//         {
//             lastWord = lastWord.Remove(lastWord.Length - 1);
//         } while (lastWord.EndsWith("?") || lastWord.EndsWith("!"));

//         lastWord = lastWord + "?";
//     }

//     else if (lastWord.EndsWith("!"))
//     {
//         do
//         {
//             lastWord = lastWord.Remove(lastWord.Length - 1);
//         } while (lastWord.EndsWith("?") || lastWord.EndsWith("!"));

//         lastWord = lastWord + "!";
//     }

//     stringArr[stringArr.Length - 1] = lastWord;
//     string result = new string(String.Join(' ', stringArr));
//     return result;
// }