namespace DepthFirstSearch
{
    public class Graph
    {
        private int V; // Number of vertices
        private List<int>[] adj; // Adjacency List

        public Graph(int vertices)
        {
            V = vertices;
            adj = new List<int>[V];
            for (int i = 0; i < V; ++i)
                adj[i] = new List<int>();
        }

        // Function to add an edge into the graph
        public void AddEdge(int v, int w)
        {
            adj[v].Add(w); // Add w to v's list
        }

        // DFS traversal of the vertices reachable from v
        private void DFSUtil(int v, bool[] visited)
        {
            // Mark the current node as visited and print it
            visited[v] = true;
            Console.Write(v + " ");

            // Recur for all the vertices adjacent to this vertex
            foreach (int i in adj[v])
            {
                if (!visited[i])
                    DFSUtil(i, visited);
            }
        }

        // DFS traversal starting from all vertices one by one
        public void DFS()
        {
            bool[] visited = new bool[V];

            // Call the recursive helper function for all vertices
            // to print DFS traversal starting from each vertex
            for (int i = 0; i < V; ++i)
            {
                if (!visited[i])
                    DFSUtil(i, visited);
            }
        }
    }
}
