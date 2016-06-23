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
    public partial class Form4OLD : Form
    {
        List<Button> buttons = new List<Button>();
        string[] questions;
        public Form4OLD(string[] values)
        {
            InitializeComponent();
            questions = new string[values.Count()];
            for (int i = 0; i < values.Count(); i++)
            {
                questions[i] = values[i];
            }
            int height = 0;
            int column = 0;
            for (int i = 0; i < questions.Count(); i++)
            {
                if (i > (int)Math.Pow(2, height) * 2 - 2)
                {
                    height++;
                    column = 0;
                }

                buttons.Add(new Button());
                buttons[i].Width = (int)widthOfButton(height);
                buttons[i].Top = height * buttons[i].Height + 5;
                buttons[i].Left = (int)xOfButton(column, height, buttons[i].Width);
                buttons[i].Name = "button" + i;
                if (values[i] == null)
                {
                    buttons[i].Enabled = false;
                }
                else
                {
                    buttons[i].Click += new EventHandler(ButtonClick);
                }
                this.Controls.Add(buttons[i]);
                column++;
            }
        }
        public float xOfButton(int column, int height, int widthOfButton)
        {
            //if (Math.Pow(2, height) / 2 - 1 < column)
            //{
            //    return this.Width - ((widthOfButton / 2) + (2 * ((float)Math.Pow(2, height)-1-column) * widthOfButton));
            //}
            //else
            //{
            float temp = (widthOfButton / 2) + (2 * column * widthOfButton);
            return (widthOfButton / 2) + (2 * column * widthOfButton);
            //}
        }
        public float widthOfButton(int height)
        {
            return this.Width / (float)Math.Pow(2, height + 1);
        }
        //public float xOfButton(int column, int height, int widthOfButton)
        //{
        //    return widthOfButton * (column * 2 + 1);
        //}
        //public float widthOfButton(int height)
        //{
        //    return this.Width / ((float)Math.Pow(2, height + 1) + 1);
        //}
        //public int numberOfColumnsInRow(int height)
        //{
        //    return (int)Math.Pow(2, height);
        //}
        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int buttonIndex = int.Parse(button.Name.Remove(0, 6));
            MessageBox.Show(questions[buttonIndex]);
        }
    }
}
