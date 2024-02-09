using System.Collections.Concurrent;

public class Consumer {
    private readonly ConcurrentQueue<int> queue;
    private readonly ManualResetEvent producerEvent;
    private readonly ManualResetEvent consumerEvent;

    public Consumer(ConcurrentQueue<int> queue, ManualResetEvent producerEvent, ManualResetEvent consumerEvent) {
        this.queue = queue;
        this.producerEvent = producerEvent;
        this.consumerEvent = consumerEvent;
    }

    public void StartConsuming() {
        Task.Run(() => {
            while (true) {
                consumerEvent.WaitOne();
                if (queue.TryDequeue(out int item)) {
                    Console.WriteLine($"Споживач: {item}");
                    producerEvent.Set();
                }
                else {
                    Console.WriteLine("Споживач: Очікування нових елементів...");
                    consumerEvent.Reset();
                }
            }
        });
    }
}
