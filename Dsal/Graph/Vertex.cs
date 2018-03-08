using System.Collections.Generic;

namespace Dsal.Graph
{
    public class Vertex
    {
        private List<Edge> neighbors = new List<Edge>();

        public Vertex(string id) => this.Id = id;

        public readonly string Id;

        public IEnumerable<Edge> Neighbors
        {
            get
            {
                return neighbors;
            }
        }
    }
}
