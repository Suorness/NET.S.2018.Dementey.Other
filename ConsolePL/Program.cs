namespace ConsolePL
{
    using Implementation;
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new SiliconeProductsFactory();

            factory.Create();
            factory.WrapUp("fast");
            factory.Deliver();
            var cost = factory.CalculateCost();

            if (cost < 0)
            {
                Console.WriteLine("You're broke!");
            }

            Console.WriteLine();
            factory = new SmallDistillery();

            factory.Create();

            try
            {
                factory.WrapUp("fast");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            factory.Deliver();

            cost = factory.CalculateCost();

            if (cost < 0)
            {
                Console.WriteLine("You're broke!");
            }

            Console.ReadLine();

        }
    }
}
