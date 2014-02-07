using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prims_Algorithm
{
    public class Vertex
    {
        public string Name { get; set; }

        public int Key { get; set; }
        public Vertex Parent { get; set; }

        public LocationVertex LocationVertex { get; set; }



    }
}
