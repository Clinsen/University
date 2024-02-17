using System.Text;
using static _10._1.PrintingStrategies;

namespace _10._1 {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = Console.InputEncoding = Encoding.Unicode;

            var printerContext = new PrinterContext();

            printerContext.SetPrintStrategy(new LaserPrinterStrategy());
            printerContext.Print("Звіт");

            printerContext.SetPrintStrategy(new ColorPrinterStrategy());
            printerContext.Print("Ілюстрації");

            printerContext.SetPrintStrategy(new PlotterPrinterStrategy());
            printerContext.Print("Креслення");
        }
    }
}
