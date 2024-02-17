namespace _7._2.OrderProcessing {
    public class HandleSize : IOrderHandler {
        private IOrderHandler? _nextHandler = null;

        public IOrderHandler HandleNext(IOrderHandler handler) {
            _nextHandler = handler;
            return handler;
        }

        public void HandleOrder(Order order) {

            switch (order.SizeCategory) {
                case "дуже велике (понад 20 кг)":
                    Console.WriteLine("Замовлення оброблено як дуже велике.");
                    break;
                case "велике (до 20 кг)":
                    Console.WriteLine("Замовлення оброблено як велике.");
                    break;
                case "середнє (до 10 кг)":
                    Console.WriteLine("Замовлення оброблено як середнє.");
                    break;
                case "мале (до 5 кг)":
                    Console.WriteLine("Замовлення оброблено як мале.");
                    break;
                default:
                    Console.WriteLine("Недійсна вагова категорія.");
                    break;
            }

            _nextHandler?.HandleOrder(order);
        }
    }
}