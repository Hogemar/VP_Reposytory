namespace TreesLogic
{

    /// Класс - узел бинарного дерева
    public class Node<T> : IComparable
        where T : IComparable
    {
        public Node<T>? Left;

        public Node<T>? Right;

        public T Data { get; }


        public Node(T data, Node<T>? left = null, Node<T>? right = null)
        {
            this.Data = data;
            this.Left = left;
            this.Right = right;
        }


        public int CompareTo(object? obj)
        {
            return Data.CompareTo(obj);
        }
    }

}



/*
namespace TreesLogic
{
	public class Node<T> : IComparable
		where T : IComparable
	{
		public Node<T>? Left { get; private set; }

		public Node<T>? Right { get; private set; }

		public T Data { get; private set; }


		public Node(T data, Node<T>? left = null, Node<T>? right = null)
		{
			Data = data;
			Left = left;
			Right = right;
		}

		public void AddLeft(Node<T> node)
		{
			if (Left != null) throw new Exception("Node already have left subtree!");

			Left = node;
		}

        public void AddRight(Node<T> node)
        {
            if (Right != null) throw new Exception("Node already have right subtree!");

            Right = Left;
        }

        public int CompareTo(object? obj)
		{
			return Data.CompareTo(obj);
		}
	}
}
*/