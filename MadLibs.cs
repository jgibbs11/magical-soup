using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun1 = "School Bus";

            string noun2 = "Banana";

            string noun3 = "Pizza";

            string adj1 = "hairy";

            string adj2 = "fat";

            string adj3 = "smelly";

            string adj4 = "long";

            string verb = "fall";

            string vpt1 = "swung";

            string vpt2 = "ran";

            string adv = "quickly";

            string adv2 = "quietly";

            Console.WriteLine("Today I went to the zoo.");Console.WriteLine("I saw a " + adj1 + " " + noun1 + " jumping up and down in its tree.");Console.WriteLine("He " + vpt1 + " " + adv + " through the large tunnel that led to its " + adj2 + " " + noun2 + ".");
            Console.WriteLine("I got some peanuts and past them through the cage to a gigantic gray " + noun3 + " towering over my head.");
            Console.WriteLine("feeding that animal made me hungry"); Console.WriteLine("I went to get a " + adj3 + " " + "scoop of ice cream.");
            Console.WriteLine("It filled my stomach."); Console.WriteLine("Afterwards I had to " + verb + " " + adv2 + " to catch our bus.");
            Console.WriteLine("When I got home I " + vpt2 + " my mom for a " + adj4 + " day at the zoo.");

            Console.ReadLine();

        }

    }
}
