namespace _7._2.OrderProcessing {
    public class HandleDestination : IOrderHandler {
        private IOrderHandler? _nextHandler = null;

        public IOrderHandler HandleNext(IOrderHandler handler) {
            _nextHandler = handler;
            return handler;
        }

        public void HandleOrder(Order order) {

            switch (order.Destination) {
                case "за вказаною адресою":
                    Console.WriteLine("Замовлення буде доставлено кур'єром за вказаною вами адресою.");
                    break;
                case "відділення вибраної компанії":
                    Console.WriteLine("Замовлення буде доставлено до відділення вибраної компанії.");
                    break;
                default:
                    Console.WriteLine("Помилка в виборі місця доставки.");
                    break;
            }

            _nextHandler?.HandleOrder(order);
        }
    }
}