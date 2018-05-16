namespace Implementation
{
    using AlertSystem;
    using Interfaces;
    using System;

    public class SiliconeProductsFactory : IFactory
    {
        private NotificationSystem _notificationSystem;

        public SiliconeProductsFactory()
        {
            _notificationSystem = new NotificationSystem();
        }

        public int CalculateCost()
        {
            Console.WriteLine("Calculating ...");
            return 42;
        }

        public void Create()
        {
            _notificationSystem.Alert("Carefully, the creation of the product began!");
            Console.WriteLine("Creating ...");
            _notificationSystem.Alert("The product creation is complete!");
        }

        public void Deliver()
        {
            _notificationSystem.Alert("Carefully, the delivery started!");
            Console.WriteLine("Delivery...");
            _notificationSystem.Alert("Delivery is complete!");
        }

        public void WrapUp(string type)
        {
            if (string.Equals(type, "fast", StringComparison.Ordinal))
            {
                _notificationSystem.Alert("Careful, fast packaging began!");
                Console.WriteLine("Packaging...");
                _notificationSystem.Alert("Fast packaging is finished!");
            }

            if (string.Equals(type, "slowpoke", StringComparison.Ordinal))
            {
                _notificationSystem.Alert("Careful, slow packaging began!");
                Console.WriteLine("Packaging...");
                _notificationSystem.Alert("Slow packaging is finished!");
            }
        }
    }
}
