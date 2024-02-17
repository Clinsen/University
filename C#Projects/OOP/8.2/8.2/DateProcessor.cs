namespace _8._2 {
    public class DateProcessor {
        public static void ProcessDate(string format, string input) {
            IDateInterpreter interpreter;
            switch (format) {
                case "1":
                    interpreter = new MMDDYYYYInterpreter();
                    break;
                case "2":
                    interpreter = new DDMMYYYYInterpreter();
                    break;
                case "3":
                    interpreter = new YYYYMMDDInterpreter();
                    break;
                default:
                    DateUI.DisplayErrorMessage("Неправильний формат.");
                    return;
            }

            try {
                DateTime date = interpreter.Interpret(input);
                DateUI.DisplayInterpretedDate(date);
            }
            catch (FormatException ex) {
                DateUI.DisplayErrorMessage(ex.Message);
            }
        }
    }
}
