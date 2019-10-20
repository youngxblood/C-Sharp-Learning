using System;

namespace myapp
{
    class Program
    {
        public static string FormatNum(int num)
        {
            int numberOfCommas;
            char[] charArr = num.ToString().ToCharArray();
            string resultStr = new string(charArr);

            System.Console.WriteLine("The array length is: " + charArr.Length);

            // value = 1234567890;
            //  Console.WriteLine(value.ToString("0,0", CultureInfo.InvariantCulture));	
            //  Console.WriteLine(String.Format(CultureInfo.InvariantCulture, 
            //                                  "{0:0,0}", value));

            // string input = Console.ReadLine();
            // int numOfDigits = input.Count(char.IsDigit);

            int numRes = num.ToString("N3", en - US);
            resultStr = String.Format("{0:0,00}", resultStr);

            // int numOfDigits = input.Count(char.IsDigit);
            // if (charArr.Length >= 4)
            // {
            //     // if ()
            //     numberOfCommas = (charArr.Length / 4);
            //     System.Console.WriteLine("This should need: " + numberOfCommas + " commas.");
            // }
            return resultStr;
        }
        // Main program here
        static void Main(string[] args)
        {
            System.Console.WriteLine(FormatNum(10000));
            System.Console.WriteLine(FormatNum(1002340000));
            System.Console.WriteLine(FormatNum(1000));
            System.Console.WriteLine(FormatNum(1));
            System.Console.WriteLine(FormatNum(10));
        }

    }
}

// public class Tests
// {
//     [Test]
//     [TestCase(1000, Result = "1,000")]
//     [TestCase(1000000, Result = "1,000,000")]
//     [TestCase(20, Result = "20")]
//     [TestCase(0, Result = "0")]
//     [TestCase(12948, Result = "12,948")]
//     public static string FixedTest(int num)
//     {
//         return Program.FormatNum(num);
//     }
// }