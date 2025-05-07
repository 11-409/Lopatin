namespace Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(1);
            root.Left = new Node(2);
            root.Right = new Node(3);
            root.Left.Left = new Node(4);
            root.Left.Right = new Node(5);
            Console.WriteLine(TraverSal.ElementsCount(root));
        }
    }
    class Node
    {
        public int Data;
        public Node Left;
        public Node Right;
        public Node(int n)
        {
            Data = n;
            Left = null;
            Right = null;
        }
    }

    class TraverSal(Node r)
    {
        public static int ElementsCount(Node r)
        {
            if (r == null) return 0;
            return r.Data + ElementsCount(r.Left) + ElementsCount(r.Right);
        }
    }
}
