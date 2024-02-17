namespace _10._1 {
    public class PrinterContext {
        private IPrintStrategy? _printStrategy;

        public void SetPrintStrategy(IPrintStrategy printStrategy) {
            _printStrategy = printStrategy;
        }

        public void Print(string document) {
            _printStrategy?.Print(document);
        }
    }

}
