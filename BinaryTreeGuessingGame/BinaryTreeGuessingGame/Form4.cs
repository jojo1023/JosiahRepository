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
    public partial class Form4 : Form
    {
        BinaryTree<string> tree = new BinaryTree<string>();
        public Form4(BinaryTree<string> tree)
        {
            InitializeComponent();
            this.tree.head = tree.head;

            treeView1.Nodes.Add(tree.head.value);
            fillViewTree(tree.head, treeView1.Nodes[0]);
        }
        public void fillViewTree(Node<string> head, TreeNode treeViewHeadNode)
        {
            if(head != null)
            {
                if (head.left != null)
                {
                    treeViewHeadNode.Nodes.Add(head.left.value);
                    fillViewTree(head.left, treeViewHeadNode.Nodes[0]);
                }
                if (head.right != null)
                {
                    treeViewHeadNode.Nodes.Add(head.right.value);
                    if(treeViewHeadNode.Nodes.Count > 0)
                    {
                        fillViewTree(head.right, treeViewHeadNode.Nodes[1]);
                    }
                    else
                    {
                        fillViewTree(head.right, treeViewHeadNode.Nodes[0]);
                    }
                }
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }
        
    }
}
