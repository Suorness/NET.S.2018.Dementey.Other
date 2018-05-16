namespace Implementation
{
    using System;
    using Interfaces;

    public class SmallDistillery : IFactory
    {
        public int CalculateCost()
        {
            Console.WriteLine("Calculating ...");
            return -42;
        }

        public void Create()
        {
            Console.WriteLine("Creating ...");
        }

        public void Deliver()
        {
            Console.WriteLine("Delivery...");
        }

        public void WrapUp(string type)
        {
            Console.WriteLine($"Boss, what the ...? {type}");
            Console.WriteLine("Our factory is not engaged in packing!");
            throw new NotImplementedException();
        }
    }
}
