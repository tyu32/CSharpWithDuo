using System;
using Microsoft.VisualBasic;

namespace HelloWorld
{
    class Car
    {
        string color = "red";

        

        static void Main(string[] args)
        {
            int a = Math.Max(5, 10);
            Console.WriteLine(a);
            //string is char[]
            char[] carray = { 'D', 'U', 'O', 'N', 'G' };
            Console.Write("ha\nha");
            string s = "DUONG";
            string test = "My name \\ is \"Duong\"!";
            //My name \ is "Duong"!
            Console.WriteLine(test);



            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);






            int day = 12;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine($"Wrong number {day}");
                    break;
            }
        }

    }

    //class Score
    //{
    //    double math = 96.5, english = 64.8;
    //}
}

