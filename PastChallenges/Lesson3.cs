// //  Exercise 3 - Difficulty Level: Intermediate
// /*
//     Set up an array of the following musical instruments:

//     cello
//     guitar
//     violin
//     double bass

//     Loop round and remove the vowels. Display the new words in a textbox, listbox or console.
// */

// using System;

// namespace myapp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//         string[] vowels = new string[5];
//         string[] instruments = new string[4];

//         vowels[0] = "a";
//         vowels[1] = "e";
//         vowels[2] = "i";
//         vowels[3] = "o";
//         vowels[4] = "u";

//         instruments[0] = "cello";
//         instruments[1] = "guitar";
//         instruments[2] = "violin";
//         instruments[3] = "double bass";

//         for (int i = 0; i < instruments.Length; i++)
//         {
//             string instrument = instruments[i];

//             for (int a = 0; a < vowels.Length; a++)
//             {
//                 instrument = instrument.Replace(vowels[a], "");
//             }


//             Console.WriteLine(instrument);

//         }
//             Console.ReadLine();
//         }
//     }
// }
