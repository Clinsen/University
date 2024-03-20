public class Edge {
    public Vertex Source { get; }
    public Vertex Destination { get; }
    public int Weight { get; }

    public Edge(Vertex source, Vertex destination, int weight) {
        Source = source;
        Destination = destination;
        Weight = weight;
    }
}

