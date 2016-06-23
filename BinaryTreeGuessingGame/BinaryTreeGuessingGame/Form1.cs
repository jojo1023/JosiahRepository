using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryTreeGuessingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public BinaryTree<string> tree = new BinaryTree<string>();
        public List<string> awnsers = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            tree.addNode("Does it have fur?", null, false);
            tree.addNode("Does it have claws?", tree.head, false);
            tree.addNode("Is it a type of pet?", tree.getNode(tree.head, "Does it have claws?"), false);
            Question.Text = tree.head.value;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            if (tree.getNode(tree.head, Question.Text).left != null)
            {
                Question.Text = tree.getNode(tree.head, Question.Text).left.value;
            }
            else
            {
                bool awnser = false;
                for (int i = 0; i < awnsers.Count(); i++)
                {
                    if (Question.Text == awnsers[i])
                    {
                        awnser = true;
                    }
                }
                if (!awnser)
                {
                    Form2 form;
                    if (tree.getNode(tree.head, Question.Text).Height >= 3)
                    {
                        form = new Form2(true);
                    }
                    else
                    {
                        form = new Form2(false);
                    }
                    form.ShowDialog();


                    tree.addNode(form.Text, tree.getNode(tree.head, Question.Text), false);
                    Question.Text = form.Text;
                    if (form.isAnswer)
                    {
                        awnsers.Add(form.Text);
                    }

                }
                else
                {
                    Close();
                }
            }
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            if (tree.getNode(tree.head, Question.Text).right != null)
            {
                Question.Text = tree.getNode(tree.head, Question.Text).right.value;
            }
            else
            {
                Form2 form;
                if (tree.getNode(tree.head, Question.Text).Height >= 3)
                {
                    form = new Form2(true);
                }
                else
                {
                    form = new Form2(false);
                }
                form.ShowDialog();


                tree.addNode(form.Text, tree.getNode(tree.head, Question.Text), true);
                Question.Text = form.Text;
                if (form.isAnswer)
                {
                    awnsers.Add(form.Text);
                }
            }
        }

        private void seeTree_Click(object sender, EventArgs e)
        {
            //Form4OLD form;
            //form = new Form4OLD(tree.getArray());
            Form4 form;
            form = new Form4(tree);
            form.ShowDialog();
        }
    }








    public class BinaryTree<T> where T : IComparable
    {
        public Node<T> head;
        public int nodeCount;
        public BinaryTree()
        {
        }

        public T[] getArray()
        {
            T[] temp = new T[(int)Math.Pow(2, HighestNode(head).Height) * 2 - 1];
            if (head != null)
            {
                temp[0] = head.value;
            }
            addNodesToArray(this.head, temp);
            return temp;
        }

        public Node<T> HighestNode(Node<T> head)
        {
            if (head != null)
            {
                Node<T> height = head;
                if (head.left != null)
                {
                    if (HighestNode(head.left) != null && HighestNode(head.left).Height > height.Height)
                    {
                        height = HighestNode(head.left);
                    }
                }
                if (head.right != null)
                {
                    if (HighestNode(head.right) != null && HighestNode(head.right).Height > height.Height)
                    {
                        height = HighestNode(head.right);
                    }
                }
                return height;
            }
            else
            {
                return null;
            }

        }

        public void addNodesToArray(Node<T> head, T[] array)
        {
            if (head != null)
            {
                if (head.left != null)
                {
                    int temp = getIndex(head.left);
                    array[getIndex(head.left)] = head.left.value;
                    addNodesToArray(head.left, array);
                }
                if (head.right != null)
                {
                    array[getIndex(head.right)] = head.right.value;
                    addNodesToArray(head.right, array);
                }
            }
        }

        public int getIndex(Node<T> node)
        {
            return (int)Math.Pow(2, (double)node.Height) + node.Column - 1;
        }

        public Node<T> getNode(Node<T> root, T value)
        {
            if (root.value != null)
            {
                if (root.value.CompareTo(value) == 0)
                {
                    return root;
                }
                Node<T> foundNode = null;
                if (root.left != null)
                {
                    foundNode = getNode(root.left, value);
                }
                if (foundNode != null && foundNode.value.CompareTo(value) == 0)
                {
                    return foundNode;
                }
                if (root.right != null)
                {
                    foundNode = getNode(root.right, value);
                }

                return foundNode;
            }
            else
            {
                return null;
            }
        }

        public void addNode(T value, Node<T> parent, bool right)
        {
            if (nodeCount == 0 || parent == null)
            {
                head = new Node<T>(value, null, null, null);
                nodeCount++;
            }
            else
            {
                if (!parent.isFull())
                {
                    if (parent.isLeaf())
                    {
                        if (right)
                        {
                            parent.right = new Node<T>(value, null, null, parent);
                        }
                        else
                        {
                            parent.left = new Node<T>(value, null, null, parent);
                        }
                    }
                    else
                    {
                        if (parent.right == null)
                        {
                            parent.right = new Node<T>(value, null, null, parent);
                        }
                        else
                        {
                            parent.left = new Node<T>(value, null, null, parent);
                        }
                    }
                    nodeCount++;
                }
            }
        }

    }
    public class Node<T>
    {
        public int Height
        {
            get
            {
                int count = 0;
                Node<T> temp = this;
                while (temp.prev != null)
                {
                    temp = temp.prev;
                    count++;
                }
                return count;
            }
        }
        public int Column
        {
            get
            {
                if (prev != null)
                {
                    if (isLeftChild())
                    {
                        return prev.Column * 2;
                    }
                    else
                    {
                        return prev.Column * 2 + 1;
                    }
                }
                else
                {
                    return 0;
                }
            }
        }
        public T value;
        public Node<T> left;
        public Node<T> right;
        public Node<T> prev;
        public Node(T value, Node<T> left, Node<T> right, Node<T> prev)
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
        public bool isLeftChild()
        {
            if (prev != null)
            {
                if (prev.left == this)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

