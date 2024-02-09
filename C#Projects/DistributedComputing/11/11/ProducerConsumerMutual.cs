using System.Collections.Concurrent;

public class ProducerConsumer {
    private ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
    private ManualResetEvent producerEvent = new ManualResetEvent(false);
    private ManualResetEvent consumerEvent = new ManualResetEvent(true);

    public void Start() {
        var producer = new Producer(queue, producerEvent, consumerEvent);
        var consumer = new Consumer(queue, producerEvent, consumerEvent);

        producer.StartProducing();
        consumer.StartConsuming();
    }
}
