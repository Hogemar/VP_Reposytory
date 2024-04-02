using System.Collections;
using System.Xml.Linq;

namespace TreesLogic
{

    /// Класс - бинарное дерево
    public class Tree<T> : IEnumerable
        where T : IComparable
    {

        // Корень дерева
        private Node<T>? _root = null;


        // Поиск элемента в дереве
        public bool Find(T element)
        {
            //if (_root == null) throw new Exception("Tree is empty!");

            return FindRecursive(_root, element);
        }

        // Вставка элемента в дерево
        public void Insert(T element) => _root = InsertRecursive(_root, element);

        // Удаление элемента из дерева
        public void Remove(T element)
        {
            if (_root == null) throw new Exception("Tree is empty!");

            RemoveRecursive(null, _root, element);
        }

        // Реализация интерфейса
        public IEnumerator<T> GetEnumerator() => PreOrderTraversal().GetEnumerator();

        // Реализация интерфейса
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();


        // Рекурсивный центрированный обход дерева
        private IEnumerable<T> CentralTraversal(Node<T>? node)
        {
            if (node == null) yield break;

            foreach (var item in CentralTraversal(node.Left))
                yield return item;

            yield return node.Data;

            foreach (var item in CentralTraversal(node.Right))
                yield return item;
        }

        // Итеративный прямой обход дерева
        private IEnumerable<T> PreOrderTraversal()
        {
            if (_root == null) yield break;

            Stack<Node<T>> nodeStack = new();
            Node<T> node = _root;
            while (nodeStack.Count > 0 || node != null)
            {
                if (node != null)
                {
                    nodeStack.Push(node);
                    node = node.Left;
                }
                else
                {
                    node = nodeStack.Pop();
                    yield return node.Data;
                    node = node.Right;
                }
            }

        }

        // Рекурсивный поиск элемента
        private bool FindRecursive(Node<T>? node, T element)
        {
            if (node == null)
                return false;

            // Поиск в левом поддереве
            if (element.CompareTo(node.Data) < 0)
                return FindRecursive(node.Left, element);

            // Поиск в правом поддереве
            else if (element.CompareTo(node.Data) > 0)
                return FindRecursive(node.Right, element);

            // Узел найден
            else return true;
        }

        // Рекурсивная вставка элемента
        private Node<T>? InsertRecursive(Node<T>? node, T element)
        {
            if (node == null)
                return new Node<T>(element);

            if (element.CompareTo(node.Data) < 0)
                node.Left = InsertRecursive(node.Left, element);

            else if (element.CompareTo(node.Data) > 0)
                node.Right = InsertRecursive(node.Right, element);

            return node;
        }

        // Рекурсивное удаление элемента
        private Node<T>? RemoveRecursive(Node<T>? parent, Node<T>? node, T element)
        {
            if (node == null)
                return null;


            if (element.CompareTo(node.Data) < 0)
                node.Left = RemoveRecursive(node, node.Left, element);

            else if (element.CompareTo(node.Data) > 0)
                node.Right = RemoveRecursive(node, node.Right, element);

            else // Найден узел для удаления
            {
                if (node.Left == null)
                    return node.Right;

                else if (node.Right == null)
                    return node.Left;

                // Если у узла есть два потомка
                Node<T> temp = node.Right;

                while (temp.Left != null)
                    temp = temp.Left;

                if(parent?.Left == node)
                    parent.Left = new Node<T>(temp.Data, node.Left, RemoveRecursive(node, node.Right, temp.Data));
                
                if(parent?.Right == node)
                    parent.Right = new Node<T>(temp.Data, node.Left, RemoveRecursive(node, node.Right, temp.Data));

                // Удаление корня
                if (parent == null)
                    _root = new Node<T>(temp.Data, node.Left, RemoveRecursive(node, node.Right, temp.Data));

                //node.Data = temp.Data;
                //node.Right = RemoveRecursive(node.Right, temp.Data);
            }

            return node;
        }
    }

}
