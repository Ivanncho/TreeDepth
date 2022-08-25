using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDemo
{
    public class Node
    {
        public int depthLevel;
        public string value;
        public Node? left;
        public Node? right;
        public Node? center;

        public Node(string value)
        {
            this.value = value;
        }
        public Node(string value, int depth)
        {
            this.value = value;
            depthLevel = depth;
        }
    }
}
