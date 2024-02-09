using System.Text;
using static _7.Commands.CommandsImplementation;

namespace _7 {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = Console.InputEncoding = Encoding.Unicode;

            Restaurant restaurant = new Restaurant();

            ConsoleUI cmdUI = new ConsoleUI(
                new AddOrderCommand(restaurant),
                new DeleteOrderCommand(restaurant),
                new ShowOrdersCommand(restaurant),
                new ExitCommand()
            );

            cmdUI.Run();
        }
    }
}
