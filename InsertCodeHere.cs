using System;

namespace RolePlayV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            Random RNG = new Random();
            Warrior warriorA = new Warrior("Ragnar", 100 + RNG.Next(50));
            Warrior warriorB = new Warrior("Lagertha", 100);

            Console.WriteLine("Press a Key to Start"); Console.ReadKey();
                Console.WriteLine("\n");
            Console.WriteLine($"Warrior A is called {warriorA.Name + " Health = " + warriorA.Start_Hitpoints}");
            Console.WriteLine($"Warrior B is called {warriorB.Name + " Health = " + warriorB.Start_Hitpoints}");
                Console.WriteLine("\n");
            
            //Levelup Tester
            Console.WriteLine("Press a Key to Start LevelUP" + "\n"); Console.ReadKey();
            Console.WriteLine(warriorA.level);
                warriorA.levelUP(); Console.ReadKey();
            Console.WriteLine(warriorA.level);
                warriorA.levelUP(); Console.ReadKey();
            Console.WriteLine(warriorA.level);
                warriorA.levelUP(); Console.ReadKey();
            Console.WriteLine(warriorA.level);
                warriorA.levelUP(); Console.ReadKey();


            //DMG Tester
                Console.WriteLine("\n");
            Console.WriteLine($"Warrior A TEST {warriorA.Name + " DMG = " + warriorA.DealDMG()}");
            Console.WriteLine($"Warrior B TEST {warriorB.Name + " DMG = " + warriorB.DealDMG()}");

            // The LAST line of code should be ABOVE this line
        }
    }
}