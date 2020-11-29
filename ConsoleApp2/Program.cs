using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            WarPlane warplane = new WarPlane();
            warplane.GetArmory();

            do
            {
                warplane.GetAction();
            
                switch (warplane.action)
                {
                    case "s":
                        warplane.Shot();
                        break;

                    case "c":
                        warplane.Charge();
                        break;

                    default:
                        break;
                }
            }
            while (warplane.Bullets + warplane.Gun > 0);
        }
    }
}
