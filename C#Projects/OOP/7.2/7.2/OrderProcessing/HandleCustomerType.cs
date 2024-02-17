namespace _7._2.OrderProcessing {
    public class HandleCustomerType : IOrderHandler {
        private IOrderHandler? _nextHandler = null;

        public IOrderHandler HandleNext(IOrderHandler handler) {
            _nextHandler = handler;
            return handler;
        }

        public void HandleOrder(Order order) {
            Console.WriteLine();

            switch (order.Customer) {
                case "звичайний":
                    Console.WriteLine("Замовлення оброблено для звичайного клієнта.");
                    break;
                case "постійний":
                    Console.WriteLine("Замовлення оброблено для постійного клієнта.");
                    break;
                case "VIP":
                    Console.WriteLine("Замовлення оброблено для VIP-клієнта.");
                    break;
                default:
                    Console.WriteLine("Не вдалося визначити тип користувача.");
                    break;
            }

            _nextHandler?.HandleOrder(order);
        }
    }
}