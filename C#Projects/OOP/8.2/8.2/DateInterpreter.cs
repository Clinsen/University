namespace _8._2 {
    public interface IDateInterpreter {
        DateTime Interpret(string date);
    }

    public class MMDDYYYYInterpreter : IDateInterpreter {
        public DateTime Interpret(string date) {
            return DateTime.ParseExact(date, "MM-dd-yyyy", null);
        }
    }

    public class DDMMYYYYInterpreter : IDateInterpreter {
        public DateTime Interpret(string date) {
            return DateTime.ParseExact(date, "dd-MM-yyyy", null);
        }
    }

    public class YYYYMMDDInterpreter : IDateInterpreter {
        public DateTime Interpret(string date) {
            return DateTime.ParseExact(date, "yyyy-MM-dd", null);
        }
    }
}
