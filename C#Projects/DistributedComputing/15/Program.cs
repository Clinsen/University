using System.Text;

class Program {
    static void Main(string[] args) {
        Console.OutputEncoding = Console.InputEncoding = Encoding.Unicode;

        // Вершини графа
        var vertex1 = new Vertex(1);
        var vertex2 = new Vertex(2);
        var vertex3 = new Vertex(3);
        var vertex4 = new Vertex(4);
        var vertex5 = new Vertex(5);
        var vertex6 = new Vertex(6);
        var vertex7 = new Vertex(7);

        // Ребра вершин згідно методички
        vertex1.AddEdge(vertex2, 6);
        vertex1.AddEdge(vertex3, 10);
        vertex2.AddEdge(vertex3, 12);
        vertex2.AddEdge(vertex4, 11);
        vertex3.AddEdge(vertex4, 8);
        vertex3.AddEdge(vertex6, 12);
        vertex4.AddEdge(vertex5, 6);
        vertex5.AddEdge(vertex7, 12);
        vertex5.AddEdge(vertex6, 16);
        vertex7.AddEdge(vertex6, 13);

        // Список вершин
        List<Vertex> graph = new List<Vertex> { vertex1, vertex2, vertex3, vertex4, vertex5, vertex6, vertex7 };

        // Мінімальне кістякове дерево
        List<Edge> minimumSpanningTree = PrimsAlgorithm.FindMinimumSpanningTree(graph);

        Console.WriteLine("Ребра мінімального дерева:");
        foreach (var edge in minimumSpanningTree) {
            Console.WriteLine($"Вершина {edge.Source.Id} -> Вершина {edge.Destination.Id}, Вага: {edge.Weight}");
        }
    }
}