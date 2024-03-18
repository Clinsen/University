
class AddExpression : IExpression {
    public int Interpret(int operand1, int operand2) {
        return operand1 + operand2;
    }
}

class SubtractExpression : IExpression {
    public int Interpret(int operand1, int operand2) {
        return operand1 - operand2;
    }
}
class MultiplyExpression : IExpression {
    public int Interpret(int operand1, int operand2) {

        return operand1 * operand2;
    }
}

class DivideExpression : IExpression {
    public int Interpret(int operand1, int operand2) {
        if (operand2 == 0)
            throw new DivideByZeroException("Ділення на нуль.");

        return operand1 / operand2;
    }
}