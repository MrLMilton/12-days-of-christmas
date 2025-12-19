using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Xml;

namespace _12_days_of_christmas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] Items = {"a partridge in a pear tree","turtle doves","french hens","calling birds", "gold rings", "geese a-laying", "swans a-swimming", "maids a-milking", "ladies dancing", "lords a-leaping", "pipers piping", "drummers drumming "};
            string[] days = { "first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth", "ninth", "tenth", "eleventh", "twelfth" };

            Console.WriteLine("Would you like to play the game or see the song? 1=Game 0=Song");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 0)
            {
                Console.WriteLine("what day of Christmas is it?");
                int currentDay = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"your gift today is {Items[currentDay - 1]}");
                Console.WriteLine($"\nOn the {days[currentDay - 1]} day of Christmas my true love sent to me:");
                if (currentDay > 0)
                {
                    for (int j = currentDay - 1; j >= 1; j--)
                    {
                        Console.WriteLine($"{j + 1} {Items[j]}");
                    }
                    Console.Write("And ");
                }
                Console.WriteLine(Items[0]);
                Console.WriteLine();
                for (int day = 0; day < Items.Length; day++)
                {
                    Console.WriteLine($"On the {days[day]} day of Christmas my true love sent to me:");
                    if (day > 0)
                    {
                        for (int j = day; j >= 1; j--)
                        {
                            Console.WriteLine($"{j + 1} {Items[j]}");
                        }
                        Console.Write("And ");
                    }
                    Console.WriteLine(Items[0]);
                    Console.WriteLine();
                }
            }
            else if (choice == 1)
            {
                int score = 3;
                Random rand = new Random();
                int currentDay = rand.Next(0, 11);
                Console.WriteLine($"your gift today is {Items[currentDay]}");
                Console.WriteLine("What day did you recive this gift for the first time?");
                int userDay = Convert.ToInt32(Console.ReadLine()) - 1;
                if (userDay == currentDay)
                {
                    Console.WriteLine("Correct! you got a perfect score");
                }
                else {
                    while (userDay != currentDay && score > 0)
                    {
                        score--;
                        if (score != 0)
                        {
                            Console.WriteLine("Wrong day, try again!");
                            userDay = Convert.ToInt32(Console.ReadLine()) - 1;
                        }

                    } 
                    if (score > 0)
                    {
                        Console.WriteLine($"Correct! you score was {score}");
                    }
                    else
                    {
                        Console.WriteLine("You ran out of guesses");
                        Console.WriteLine($"The correct day was {currentDay + 1}");


                    }
                }
            }
        }
    }
}
