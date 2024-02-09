namespace _7.Commands {
    public class CommandsImplementation {
        public class AddOrderCommand : ICommand {
            private readonly Restaurant _restaurant;

            public AddOrderCommand(Restaurant restaurant) {
                _restaurant = restaurant;
            }

            public void Execute() {
                Console.WriteLine("Введіть назву замовлення, яке ви хочете додати:");
                string? order = Console.ReadLine();

                _restaurant.ordersList.Add(order);

                Console.WriteLine($"Замовлення '{order}' успішно додане.");
            }
        }

        public class DeleteOrderCommand : ICommand {
            private readonly Restaurant _restaurant;

            public DeleteOrderCommand(Restaurant restaurant) {
                _restaurant = restaurant;
            }

            public void Execute() {
                Console.WriteLine("Введіть індекс замовлення, яке ви хочете видалити:");
                int index;
                if (int.TryParse(Console.ReadLine(), out index)) {
                    if (index >= 0 && index < _restaurant.ordersList.Count) {
                        _restaurant.ordersList.RemoveAt(index);
                        Console.WriteLine($"Замовлення за індексом {index} було видалено.");
                    }
                    else {
                        Console.WriteLine("Помилка: Неправильний індекс для видалення замовлення.");
                    }
                }
                else {
                    Console.WriteLine("Помилка: Введений індекс не є цілим числом.");
                }
            }
        }

        public class ShowOrdersCommand : ICommand {
            private readonly Restaurant _restaurant;

            public ShowOrdersCommand(Restaurant restaurant) {
                _restaurant = restaurant;
            }

            public void Execute() {
                Console.WriteLine(_restaurant.ToString());
            }
        }

        public class ExitCommand : ICommand {
            public void Execute() {
                Console.WriteLine("Завершення виконання програми...");
                Environment.Exit(0);
            }
        }
    }
}
