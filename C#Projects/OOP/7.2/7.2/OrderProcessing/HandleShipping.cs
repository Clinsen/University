namespace _7._2.OrderProcessing {
    public class HandleShipping : IOrderHandler {
        private IOrderHandler? _nextHandler = null;

        public IOrderHandler HandleNext(IOrderHandler handler) {
            _nextHandler = handler;
            return handler;
        }

        public void HandleOrder(Order order) {

            switch (order.ShippingMethod) {
                case "Нова пошта":
                    Console.WriteLine("Тип доставки: Нова пошта");
                    break;
                case "Укр пошта":
                    Console.WriteLine("Тип доставки: Укр пошта");
                    break;
                case "Meest":
                    Console.WriteLine("Тип доставки: Meest");
                    break;
                case "інші перевізники":
                    Console.WriteLine("Тип доставки: інші перевізники");
                    break;
                default:
                    Console.WriteLine("Не вдалося визначити метод доставки.");
                    break;
            }

            _nextHandler?.HandleOrder(order);
        }
    }
}