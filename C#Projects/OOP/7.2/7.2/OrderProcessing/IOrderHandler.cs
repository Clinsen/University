namespace _7._2.OrderProcessing {
    public interface IOrderHandler {
        void HandleOrder(Order order);
        IOrderHandler HandleNext(IOrderHandler order);
    }
}