// Реалізація для чисел
public class Number : IExpression
{
    private int _value;

    public Number(int value)
    {
        _value = value;
    }

    public int Evaluate()
    {
        return _value;
    }
}