using BinaryTreeDemo;
using System.Collections;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        Node a = new Node("A",1);
        Node b = new Node("B",2);
        Node c = new Node("C",2);
        Node d = new Node("D",3);
        Node e = new Node("E",3);
        Node f = new Node("F",3);
        Node g = new Node("G", 3);
        Node h = new Node("H",4);
        Node i = new Node("I",4);
        Node j = new Node("J", 4);
        Node k = new Node("K", 5);



        a.left = b;
        a.right = c;
        b.left = d;
        c.left = e;
        c.center = f;
        c.right = g;
        e.left = h;
        f.left = i;
        f.right = j;
        i.left = k;

        depthFirstAlg(a);
        
    }   
    public static void depthFirstAlg(Node root)
    {
        if(root == null)
        {
            Console.WriteLine("***There is no node available at the moment.***");
            return;
        }
        Stack<Node> stack = new Stack<Node>();
        stack.Push(root);
        List<Node> values = new List<Node>();

        while (stack.Any())
        {
            Node current = stack.Pop();
            //Console.WriteLine(current.value);

            values.Add(current);
            if (current.right != null)
            {
                stack.Push(current.right);
            }
            if(current.center != null)
            {
                stack.Push(current.center);
            }
            if(current.left != null)
            {
                stack.Push(current.left);
            }
        }
        
        foreach (Node v in values)
        {
            Console.WriteLine($"Values are: '{v.value}'. Depth level is {v.depthLevel}.");

        }
        /*What should it look like
          1         a
                   /  \
          2       b    c
                 /   / | \  
          3     d   e  f  g
                   /  /  \ 
          4       h  i     j
                     |
          5          k
         */

    }
}