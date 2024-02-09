namespace _7 {
    public class ConsoleUI {
        private readonly ICommand _addCommand;
        private readonly ICommand _deleteCommand;
        private readonly ICommand _showOrdersCommand;
        private readonly ICommand _exitCommand;

        public ConsoleUI(ICommand addCommand, ICommand deleteCommand, ICommand showOrdersCommand, ICommand exitCommand) {
            _addCommand = addCommand;
            _deleteCommand = deleteCommand;
            _showOrdersCommand = showOrdersCommand;
            _exitCommand = exitCommand;
        }

        public void Run() {

            while (true) {
                Console.WriteLine("Виберіть дію:");
                Console.WriteLine("A. Добавити замовлення");
                Console.WriteLine("B. Видалити замовлення");
                Console.WriteLine("C. Показати список замовлень");
                Console.WriteLine("D. Закінчити роботу");

                Console.Write(">> ");
                ConsoleKey action = Console.ReadKey().Key;
                Console.WriteLine("\n");

                switch (action) {
                    case ConsoleKey.A:
                        _addCommand.Execute();
                        Console.WriteLine();
                        break;
                    case ConsoleKey.B:
                        _deleteCommand.Execute();
                        Console.WriteLine();
                        break;
                    case ConsoleKey.C:
                        _showOrdersCommand.Execute();
                        Console.WriteLine();
                        break;
                    case ConsoleKey.D:
                        _exitCommand.Execute();
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Такої опції не існує.\n");
                        break;
                }
            }
        }
    }
}
