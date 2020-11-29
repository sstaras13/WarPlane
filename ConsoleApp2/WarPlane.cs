using System;

namespace ConsoleApp2
{
    class WarPlane
    {
        int Capacity { get; set; } = 5;
        public int Gun { get; set; } = 0;
        public int Bullets { get; set; } = 15;
        public string action;

        public void GetArmory()
        {
            Console.WriteLine($"You armoury is: {Gun} out of {Capacity} in gun and {Bullets} in bullets");
            Console.WriteLine();
        }

        public void GetAction()
        {
            Console.Write("Choose your action - Charge (C) or Shot (S):");
            action = Console.ReadLine();
            Console.WriteLine();
        }

        public void Charge()
        {
            if (Bullets > 0 & Gun < Capacity)
            {
                do
                {
                    Gun = ++Gun;
                    Bullets = --Bullets;
                }
                while (Bullets > 0 & Gun < Capacity);
                Console.WriteLine($"The gun is fully charged. Available in bullets: {Bullets}");
            }
            else if (Gun == Capacity)
            {
                Console.WriteLine($"The gun is fully charged. You have {Gun} in the gun and {Bullets} in bullets.");
            }
            else
            {
                Console.WriteLine($"You do not have any bullets to charge the gun. You have only {Gun} in the gun.");
            }
        }

        public void Shot()
        {
            if (Gun == 0)
            {
                Console.WriteLine("You need to charge the gun");
                Console.WriteLine();
            }
            else
            {
                Gun = --Gun;
                Console.WriteLine($"Shot is done. {Gun} is in the gun and {Bullets} bullets are left");
            }
        }
    }
} 
