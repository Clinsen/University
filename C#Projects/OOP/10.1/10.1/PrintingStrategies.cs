namespace _10._1 {
    public static class PrintingStrategies {
        public class LaserPrinterStrategy : IPrintStrategy {
            public void Print(string document) {
                Console.WriteLine("Друк на лазерному принтері: " + document);
            }
        }

        public class ColorPrinterStrategy : IPrintStrategy {
            public void Print(string document) {
                Console.WriteLine("Друк на кольоровому принтері: " + document);
            }
        }

        public class PlotterPrinterStrategy : IPrintStrategy {
            public void Print(string document) {
                Console.WriteLine("Друк на плотері: " + document);
            }
        }

    }
}
