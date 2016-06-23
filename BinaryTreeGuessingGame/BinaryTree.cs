using System;

//namespace BinaryTreeGuessingGame
//{
    public class BinaryTree<T>
    {
        Node<T> head;
        public int nodeCount;
        public BinaryTree()
        {
           
        }

        public void addNode(T value, Node<T> parent, bool right)
        {
            if (nodeCount == 0)
            {
                head = new Node(value, null, null, null);
            }
            else
            {
                if (!parent.isFull())
                {
                    if (parent.isLeaf())
                    {
                        if (right)
                        {
                            parent.right = new Node(value, null, null, parent);
                        }
                        else
                        {
                            parent.left = new Node(value, null, null, parent);
                        }
                    }
                    else
                    {
                        if (parent.right != null)
                        {
                            parent.right = new Node(value, null, null, parent);
                        }
                        else
                        {
                            parent.left = new Node(value, null, null, parent);
                        }
                    }
                    nodeCount++;
                }
            }
        }

        public Node getNode(Node<T> parent, bool right)
        {
            if(parent == null)
            {
                return head;
            }
            else if (right)
            {
                return parent.right;
            }
            else
            {
                return parent.right;
            }
        }
    }
//}


//sort Binary Tree
/*
public BinaryTree(Array<int> initialArray)
{
    if (initialArray != null)
    {
        head = new Node(initialArray[0], null, null);
        Node temp = head;
        bool duplicate = false;
        for (int i = 1; i < initialArray.Length(); i++)
        {
            while (!temp.isLeaf())
            {
                if (initialArray[i] > temp.value)
                {
                    temp = temp.right;
                }
                else if (initialArray[i] < temp.value)
                {
                    temp = temp.left;
                }
                else
                {
                    duplicate = true;
                    break;
                }
            }
            if (!duplicate)
            {
                if (initialArray[i] > temp.value)
                {
                    temp.right = new Node(initialArray[i], null, null);
                }
                else if (initialArray[i] < temp.value)
                {
                    temp.left = new Node(initialArray[i], null, null);
                }
            }
            else
            {
                duplicate = false;
            }
        }
    }
}
*/


