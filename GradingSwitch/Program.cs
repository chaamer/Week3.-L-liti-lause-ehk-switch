using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma tulemus");
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper()); //muudab kõik suurtähed väikseks koguaeg

            switch (userResult)
            {
                case 'A': //if(userColor == "punane")
                    Console.WriteLine("Suurepärane");
                    break;
                case 'B': //if(userColor == "punane")
                    Console.WriteLine("Väga hea");
                    break;
                case'C': //if(userColor == "punane")
                    Console.WriteLine("Hea");
                    break;
                case 'D': //if(userColor == "punane")
                    Console.WriteLine("Rahuldav");
                    break;
                case 'E': //if(userColor == "punane")
                    Console.WriteLine("Kasin");
                    break;
                case 'F': //if(userColor == "punane")
                    Console.WriteLine("Puudulik");
                    break;
                default:
                    Console.WriteLine($"Vale väärtus");
                    break;
            }
        }
    }
}
