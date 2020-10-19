using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, if you want to start a game, please type Y, else N");
            var result = Console.ReadLine();
            Weapons weapons = new Weapons();
            var counter = 10;
            if (result == "y")
            {
                while (counter != 0)
                {
                    Console.WriteLine("Please choose a shooter, type 1 or 2");
                    var player = Console.ReadLine();

                    if (player == "1")
                    {
                        Weapons.ShootFromWeapon1(weapons);
                        counter--;
                        if(counter == 0)
                        {
                            Weapons.Fight("1");
                        }
                    }
                    else if (player == "2")
                    {
                        Weapons.ShootFromWeapon2(weapons);
                        counter--;
                        if (counter == 0)
                        {
                            Weapons.Fight("2");
                        }
                    }
                }
            }
            else Console.WriteLine("Bye ..... ");
            Console.ReadKey();
        }
    }
}
