public class PrimsAlgorithm {
    public static List<Edge> FindMinimumSpanningTree(List<Vertex> graph) {
        HashSet<Vertex> visitedVertices = new HashSet<Vertex>();
        List<Edge> minimumSpanningTree = new List<Edge>();

        var startVertex = graph.First();
        visitedVertices.Add(startVertex);

        while (visitedVertices.Count < graph.Count) {
            Edge minEdge = null;
            foreach (var vertex in visitedVertices) {
                var edge = vertex.AdjacentEdges.OrderBy(e => e.Weight)
                                                .FirstOrDefault(e => !visitedVertices.Contains(e.Destination));
                if (edge != null && (minEdge == null || edge.Weight < minEdge.Weight)) {
                    minEdge = edge;
                }
            }

            if (minEdge == null) {
                throw new InvalidOperationException("Відсутні ребра дерева.");
            }

            minimumSpanningTree.Add(minEdge);
            visitedVertices.Add(minEdge.Destination);
        }

        return minimumSpanningTree;
    }
}
        
