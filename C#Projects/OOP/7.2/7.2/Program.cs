namespace _7._2.OrderProcessing {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;

            var customerHandler = new HandleCustomerType();
            var sizeOrderHandler = new HandleSize();
            var shippingMethodOrderHandler = new HandleShipping();
            var destinationHandler = new HandleDestination();

            customerHandler
                .HandleNext(sizeOrderHandler)
                .HandleNext(shippingMethodOrderHandler)
                .HandleNext(destinationHandler);

            var order = OrderMaker.CreateOrder();

            customerHandler.HandleOrder(order);

            Console.WriteLine(order.ToString());
            Console.ReadLine();
        }
    }
}