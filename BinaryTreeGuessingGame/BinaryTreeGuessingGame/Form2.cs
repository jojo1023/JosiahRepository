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
    public partial class Form2 : Form
    {
        public bool isAnswer = false;
        public string Text = "";
        public Form2(bool canAddAnswer)
        {
            InitializeComponent();
            if(!canAddAnswer)
            {
                AddNewAwnser.Enabled = false;
            }
            else
            {
                AddNewAwnser.Enabled = true;
            }
        }

        private void AddNewAwnser_Click(object sender, EventArgs e)
        {
            isAnswer = true;
            Form3 form = new Form3(isAnswer);
            form.ShowDialog();
            Text = form.Text;
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void AddNewQuestion_Click(object sender, EventArgs e)
        {
            isAnswer = false;
            Form3 form = new Form3(isAnswer);
            form.ShowDialog();
            Text = form.Text;
            Close();
        }
    }
}
