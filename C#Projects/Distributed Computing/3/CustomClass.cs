public class CustomClass : IComparable<CustomClass?>
{
    public int Value { get; set; }

    public CustomClass(int value)
    {
        Value = value;
    }

    public CustomClass()
    {
    }

    public int CompareTo(CustomClass? other)
    {
        if (other == null)
        {
            return 1;
        }

        return Value.CompareTo(other.Value);
    }
}
