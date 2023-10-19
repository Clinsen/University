// Реалізація для виразів (операцій)
public class Operation : IExpression
{
    private char _operator;
    private IExpression _left;
    private IExpression _right;

    public Operation(char @operator, IExpression left, IExpression right)
    {
        _operator = @operator;
        _left = left;
        _right = right;
    }

    public int Evaluate()
    {
        switch (_operator)
        {
            case '+':
                return _left.Evaluate() + _right.Evaluate();
            case '-':
                return _left.Evaluate() - _right.Evaluate();
            default:
                throw new InvalidOperationException("Невідомий оператор");
        }
    }
}