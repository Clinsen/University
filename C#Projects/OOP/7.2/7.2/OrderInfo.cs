namespace _7._2.OrderProcessing {
    public class Order {
        public string? Customer { get; set; }
        public string? SizeCategory { get; set; }
        public string? ShippingMethod { get; set; }
        public string? Destination { get; set; }

        public override string ToString() {
            return
                $"\nІнформація про замовлення: \nТип клієнта: {Customer}" +
                $"\nРозмір: {SizeCategory}" +
                $"\nСпосіб доставки: {ShippingMethod}" +
                $"\nМісце призначення: {Destination}";
        }
    }
}