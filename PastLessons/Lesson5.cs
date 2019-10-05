// Exercise 5 - Difficulty Level: Beginner
/*
For every number on a dartboard (1 to 20), work out the possible single, double and treble scores. (For example, the number 20 has the possible score 20, 40 and 60.)
*/

using System;


    class Lesson5 {
        // Main program here
        static void CalculateDartScore () 
        {

            for (int i = 1; i < 21; i++) 
            {
                // int singleValue = i;
                // int doubleValue = i *2;
                // int tripleValue = i *3;

                // Console.WriteLine("------------");
                Console.WriteLine("The possible score value of " + i + " is: ");
                Console.WriteLine("First: " + i);
                Console.WriteLine("Second: " + i*2);
                Console.WriteLine("Third: " + i*3);
                Console.WriteLine("------------");
            }

        }
    }
