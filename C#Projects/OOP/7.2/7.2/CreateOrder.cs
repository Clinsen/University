namespace _7._2.OrderProcessing {
    public class OrderMaker {
        public static Order CreateOrder() {
            var order = new Order();

            order.Customer = GetCustomerType();
            order.SizeCategory = GetSizeCategory();
            order.ShippingMethod = GetShippingMethod();
            order.Destination = GetDestination();

            return order;
        }

        private static string? GetCustomerType() {
            string? customerInput;
            do {
                Console.WriteLine("Виберіть тип користувача:");
                Console.WriteLine("1. VIP");
                Console.WriteLine("2. Звичайний");
                Console.WriteLine("3. Постійний");
                customerInput = Console.ReadLine();

                switch (customerInput) {
                    case "1":
                        return "VIP";
                    case "2":
                        return "звичайний";
                    case "3":
                        return "постійний";
                    default:
                        Console.WriteLine("Невірний вибір. Будь ласка, виберіть з доступних варіантів.\n");
                        break;
                }
            } while (true);
        }

        private static string? GetSizeCategory() {
            string? sizeInput;
            do {
                Console.WriteLine("\nВиберіть вагову категорію замовлення:");
                Console.WriteLine("1. Мале (до 5 кг)");
                Console.WriteLine("2. Середнє (до 10 кг)");
                Console.WriteLine("3. Велике (до 20 кг)");
                Console.WriteLine("4. Дуже велике (понад 20 кг)");

                sizeInput = Console.ReadLine();

                switch (sizeInput) {
                    case "1":
                        return "мале (до 5 кг)";
                    case "2":
                        return "середнє (до 10 кг)";
                    case "3":
                        return "велике (до 20 кг)";
                    case "4":
                        return "дуже велике (понад 20 кг)";
                    default:
                        Console.WriteLine("Невірний вибір. Будь ласка, виберіть з доступних варіантів.");
                        break;
                }
            } while (true);
        }

        private static string? GetShippingMethod() {
            string? shippingMethodInput;
            do {
                Console.WriteLine("\nВиберіть метод доставки:");
                Console.WriteLine("1. Нова пошта");
                Console.WriteLine("2. Укр пошта");
                Console.WriteLine("3. Meest");
                Console.WriteLine("4. Інші перевізники");
                shippingMethodInput = Console.ReadLine();

                switch (shippingMethodInput) {
                    case "1":
                        return "Нова пошта";
                    case "2":
                        return "Укр пошта";
                    case "3":
                        return "Meest";
                    case "4":
                        return "інші перевізники";
                    default:
                        Console.WriteLine("Невірний вибір. Будь ласка, виберіть з доступних варіантів.");
                        break;
                }
            } while (true);
        }

        private static string? GetDestination() {
            string? destinationInput;
            do {
                Console.WriteLine("\nВиберіть місце призначення:");
                Console.WriteLine("1. За вказаною адресою");
                Console.WriteLine("2. Відділення вибраної компанії");
                destinationInput = Console.ReadLine();

                switch (destinationInput) {
                    case "1":
                        return "за вказаною адресою";
                    case "2":
                        return "відділення вибраної компанії";
                    default:
                        Console.WriteLine("Невірний вибір. Будь ласка, виберіть з доступних варіантів.");
                        break;
                }
            } while (true);
        }
    }
}