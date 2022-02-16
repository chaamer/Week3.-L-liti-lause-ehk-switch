using System;

namespace Personality_Test
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
            string userColor = Console.ReadLine();

            if(userColor == "punane")
            {
                Console.WriteLine("Oled romantiline");
            }
            else if (userColor == "sinine")
            {
                Console.WriteLine("Oled töökas");
            }
            else if (userColor == "roheline")
            {
                Console.WriteLine("Oled loodussõbralik");
            }
            else
            {
                Console.WriteLine($"Oled {userColor} ükssarvik");
            }

            Console.WriteLine("Head päeva!");
        }
    }
}
