using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    public class Weapons
    {
        //თითოეულ იარაღს აქვს 10 ტყვია.
        public int Weapon1 { get; set; } = 10;
        public  int Weapon2 { get; set; } = 10;

        public static void Fight(string player)
        {
            Console.WriteLine($"Player {player} winned!!!");
        }
        public static int counter = 10;
        public static void ShootFromWeapon1(Weapons weapons)
        {
            counter-- ;
            weapons.Weapon1 = counter;
            Console.WriteLine("Shoot from weapon 1 !!!");
        }
        public static void ShootFromWeapon2(Weapons weapons)
        {
            counter--;
            weapons.Weapon2 = counter;
            Console.WriteLine("Shoot from weapon 2 !!!");
        }
    }
}
