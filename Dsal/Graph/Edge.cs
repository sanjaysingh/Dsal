using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal.Graph
{
    public class Edge
    {
        public Edge(Vertex from, Vertex to)
        {
            From = from;
            To = to;
        }

        public readonly Vertex From;
        public readonly Vertex To;
    }
}
