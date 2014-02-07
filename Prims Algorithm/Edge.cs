using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prims_Algorithm
{
    public class Edge
    {
        public Vertex FromVertex { get; set; }
        public Vertex ToVertex { get; set; }
        public int Distance { get; set; }

        public bool IsFrom { get; set; }
    }
}
