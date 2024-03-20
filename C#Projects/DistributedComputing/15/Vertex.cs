public class Vertex {
    public int Id { get; }
    public List<Edge> AdjacentEdges { get; }

    public Vertex(int id) {
        Id = id;
        AdjacentEdges = new List<Edge>();
    }

    public void AddEdge(Vertex destination, int weight) {
        AdjacentEdges.Add(new Edge(this, destination, weight));
    }
}