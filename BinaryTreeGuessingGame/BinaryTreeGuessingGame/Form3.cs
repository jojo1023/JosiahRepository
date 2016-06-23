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
    public partial class Form3 : Form
    {
        bool answer;
        public string Text;
        public Form3(bool answer)
        {
            this.answer = answer;
            InitializeComponent();
            if (answer)
            {
                QuestionOrAwnserLabel.Text = "Enter the animal you were thinking of.";
            }
            else
            {
                QuestionOrAwnserLabel.Text = "Enter a new question to lead to the animal you were thinking of.";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            
            Text = NewQuestionAwnser.Text;
            Close();
        }
    }
}
