using System;

namespace Personality_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            // SIsesta lemmikvärv
            //Kui punane siis "Oled romatiniline"
            //Kui sinine, oled "oled töökas"
            //Kui roheline, "oled looduse sõber"
            //Kui midagi muud siis "oled {userColor} ükssarvik" ;

            Console.WriteLine("Sisesta oma lemmikvärv");
            string userColor = Console.ReadLine().ToLower; //muudab kõik suurtähed väikseks koguaeg

            switch (userColor)
            {
                case "punane": //if(userColor == "punane")
                    Console.WriteLine("Oled romantiline");
                    break;
                case "sinine": //if(userColor == "punane")
                    Console.WriteLine("Oled töökas");
                    break;
                case "roheline": //if(userColor == "punane")
                    Console.WriteLine("Oled loodussõbralik");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} ükssarvik");
                    break;
            }

            Console.WriteLine("Head päeva!");
        }
    }
}
