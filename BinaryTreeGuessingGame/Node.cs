using System;

//namespace BinaryTreeGuessingGame
//{
    public class Node<T>
    {
        public T value;
        public Node left;
        public Node right;
        public Node prev;
        public Node(T value, Node left, Node right, Node prev)
        {
            this.value = value;
            this.left = left;
            this.right = right;
            this.prev = prev;
        }
        public bool isLeaf()
        {
            if (this.left == null && this.right == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isFull()
        {
            if (this.left != null && this.right != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


//}

