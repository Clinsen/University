/*using FunctionCalculator;

public class CustomTimer
{
    private Timer timer;
    private int interval;
    private Calculator calculator;

    public CustomTimer(int interval, Calculator calculator)
    {
        this.interval = interval;
        this.calculator = calculator;
    }

    public void Start()
    {
        timer = new Timer(TimerCallback, null, 0, interval);
    }

    public void Stop()
    {
        timer.Change(Timeout.Infinite, Timeout.Infinite);
    }

    private void TimerCallback(object state)
    {
        calculator.IncrementArgument();
    }
}
*/