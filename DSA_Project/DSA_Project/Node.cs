using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    public class Node
    {
        public double SGPA {  get; set; }
        public int REGNO { get; set; }
        public Node? Next { get; set; }

        public Node? Prev { get; set; }

        public Node(double SGP, int reg)
        { 
            SGPA = SGP;
            REGNO = reg;
        }

    }
}
