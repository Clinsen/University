using System.Text;

namespace _8._2 {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = Console.InputEncoding = Encoding.Unicode;

            DateUI ConsoleUI = new DateUI();
            ConsoleUI.StartUI();
        }
    }
}
