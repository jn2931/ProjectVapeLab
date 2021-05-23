using System;

namespace ProjectVapeLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Project Vape Lab!");
            Console.WriteLine("Please enter the number of aromas you are going to use, and press 'enter'");
            int aromaNumber = Convert.ToInt32(Console.ReadLine());
            Aroma[] aromas = new Aroma[aromaNumber];
            for (int i = 0; i < aromas.Length; i++)
            {
                aromas[i] = new Aroma();
            }

                for (int i = 0; i < aromas.Length; i++)
            {
                Console.WriteLine("Please enter the name of aroma nr." + (i + 1));
                aromas[i].name = Console.ReadLine();
                Console.WriteLine("Please enter the sugested percentage of aroma nr." + (i + 1));
                aromas[i].percentage = Convert.ToInt32(Console.ReadLine());
            }
            Eliquid finalProduct = new Eliquid();
            Console.WriteLine("Please enter the volume of final product you want to obtain (ml).");
            finalProduct.volume = Convert.ToInt32(Console.ReadLine());
            NeutralBase nbase = new NeutralBase();
            float aromaSumPercentage = 0;
        }
    }
}
