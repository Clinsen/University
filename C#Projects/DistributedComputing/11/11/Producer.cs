using System.Collections.Concurrent;

public class Producer {
    private readonly ConcurrentQueue<int> queue;
    private readonly ManualResetEvent producerEvent;
    private readonly ManualResetEvent consumerEvent;

    public Producer(ConcurrentQueue<int> queue, ManualResetEvent producerEvent, ManualResetEvent consumerEvent) {
        this.queue = queue;
        this.producerEvent = producerEvent;
        this.consumerEvent = consumerEvent;
    }

    public void StartProducing() {
        Task.Run(() => {
            for (int i = 0; i < 6; i++) {
                Thread.Sleep(1000); // імітація виробництва
                queue.Enqueue(i);
                Console.WriteLine($"Виробник: {i}");
                consumerEvent.Set();
                producerEvent.WaitOne();
            }
        });
    }
}
