class Context {
    private Dictionary<string, IExpression> expressions = new Dictionary<string, IExpression>();

    public Context() {
        expressions.Add("+", new AddExpression());
        expressions.Add("-", new SubtractExpression());
        expressions.Add("*", new MultiplyExpression());
        expressions.Add("/", new DivideExpression());
    }

    public int Evaluate(string expression) {
        string[] elements = expression.Split(' ');

        if (elements.Length != 3)
            throw new FormatException("Неправильний формат виразу.");

        int operand1;
        int operand2;

        if (!int.TryParse(elements[0], out operand1) || !int.TryParse(elements[2], out operand2))
            throw new FormatException("Операнди повинні бути цілими числами.");

        string operation = elements[1];

        if (!expressions.ContainsKey(operation))
            throw new NotSupportedException("Операція не підтримується.");

        return expressions[operation].Interpret(operand1, operand2);
    }
}
