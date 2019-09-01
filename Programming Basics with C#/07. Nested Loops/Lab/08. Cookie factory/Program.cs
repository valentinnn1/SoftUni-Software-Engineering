using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Cookie_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int counts = int.Parse(Console.ReadLine());
            string command = string.Empty;
            bool hasFlour = false;
            bool hasEggs = false;
            bool hasSugar = false;
            int i = 1;

            while (counts > 0)
            {
                command = Console.ReadLine();

                switch (command)
                {
                    case "flour":
                        hasFlour = true;
                        break;
                    case "eggs":
                        hasEggs = true;
                        break;
                    case "sugar":
                        hasSugar = true;
                        break;
                }

                if (command == "Bake!")
                {

                    if (hasFlour && hasEggs && hasSugar)
                    {

                        Console.WriteLine("Baking batch number {0}...", i);
                        counts--;
                        i++;
                        hasFlour = hasEggs = hasSugar = false;
                    }
                    else
                    {
                        Console.WriteLine("The batter should contain flour, eggs and sugar!");
                    }
                }
            }

        }

    }
}
