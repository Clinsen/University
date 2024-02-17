namespace _8._2 {
    public class DateUI {
        public void StartUI() {

            string? userInput;
            do {
                DateUI.DisplayFormatSelection();
                string? format = DateUI.GetDateFormat();

                Console.Write("Введіть дату за вибраним форматом: ");
                string? input = Console.ReadLine();

                DateProcessor.ProcessDate(format, input);

                do {
                    Console.WriteLine("\nСпробувати знову? (yes/no)");
                    userInput = Console.ReadLine()?.ToLower();
                    Console.WriteLine();
                } while (userInput != "yes" && userInput != "no");

            } while (userInput == "yes");

            Console.WriteLine("Програма закінчила свою роботу.");
        }


        public static void DisplayFormatSelection() {
            Console.WriteLine("Доступні формати дати:");
            Console.WriteLine("1. MM-DD-YYYY");
            Console.WriteLine("2. DD-MM-YYYY");
            Console.WriteLine("3. YYYY-MM-DD");
        }


        public static string GetDateFormat() {
            string? format;
            do {
                Console.Write("Оберіть опцію: ");
                format = Console.ReadLine();
            } while (format != "1" && format != "2" && format != "3");

            return format;
        }


        public static void DisplayInterpretedDate(DateTime date) {
            Console.WriteLine($"Інтерпретована дата: {date}");
        }


        public static void DisplayErrorMessage(string message) {
            Console.WriteLine($"Помилка: {message}");
        }
    }
}
