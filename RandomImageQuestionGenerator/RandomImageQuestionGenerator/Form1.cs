using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RandomImageQuestionGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //replacementLabel.Location = questionPicture.PointToClient (replacementLabel.Location);
            replacementLabel.Parent = awnserPicture;

            replacementLabel.BackColor = Color.Transparent;
        }
        bool createNewParameter = false;

        Bitmap questionImage;
        Bitmap originalImage;
        Rectangle currentSelection;
        Point startPoint;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (questionPicture.Image != null)
            {
                newPossibility.Enabled = true;
                addPosibilityButton.Enabled = true;
                questionPicture.Enabled = true;
                possibilities.Enabled = true;
            }
            else
            {
                newPossibility.Enabled = false;
                addPosibilityButton.Enabled = false;
                questionPicture.Enabled = false;
                possibilities.Enabled = false;
            }

            if (questions.SelectedItem != null && questions.Enabled)
            {
                deleteQuestionButton.Enabled = true;
                openQuestion.Enabled = true;
            }
            else
            {
                deleteQuestionButton.Enabled = false;
                openQuestion.Enabled = false;
            }

            if (possibilities.SelectedItem != null && possibilities.Enabled)
            {
                removePosibilityButton.Enabled = true;
            }
            else
            {
                removePosibilityButton.Enabled = false;
            }

            if (possibilities.Items.Count > 0)
            {
                if (currentSelection.Width > 0 && currentSelection.Height > 0)
                {
                    generateQuestionButton.Enabled = true;
                    questionName.Enabled = true;
                }
            }
            else
            {
                questionName.Enabled = false;
                generateQuestionButton.Enabled = false;
            }

            if (questionName.Text != "" && questionName.Text != "Question Name" && questionName.Enabled)
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }

        }

        Graphics gfx;
        Random random;
        XDocument xdoc;
        private void Form1_Load(object sender, EventArgs e)
        {
            xdoc = XDocument.Load("Questions.xml");

            showQuestions();

            random = new Random();
        }

        public void showQuestions()
        {
            questions.Items.Clear();
            foreach (XElement question in xdoc.Root.Elements("Question"))
            {
                if (question.Attribute("deleted").Value == "false")
                {
                    questions.Items.Add(question.Attribute("name").Value);
                }
            }
        }

        private void questionPicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (createNewParameter)
                {
                    gfx.DrawImage(originalImage, new Point(0, 0));
                    currentSelection = getSelectedArea(new Point(e.X, e.Y), startPoint, originalImage);
                    gfx.DrawRectangle(Pens.Black, currentSelection);
                    questionPicture.Image = questionImage;
                }
            }
        }

        public Rectangle getSelectedArea(Point mousePoint, Point startPoint, Bitmap originalImage)
        {
            Rectangle returnRectangle = new Rectangle();

            returnRectangle.Width = Math.Abs(mousePoint.X - startPoint.X);
            returnRectangle.Height = Math.Abs(mousePoint.Y - startPoint.Y);

            if (mousePoint.X - startPoint.X < 0 && mousePoint.Y - startPoint.Y < 0)
            {
                returnRectangle.X = mousePoint.X;
                returnRectangle.Y = mousePoint.Y;
            }
            else if (mousePoint.X - startPoint.X < 0)
            {
                returnRectangle.X = mousePoint.X;
                returnRectangle.Y = startPoint.Y;
            }
            else if (mousePoint.Y - startPoint.Y < 0)
            {
                returnRectangle.X = startPoint.X;
                returnRectangle.Y = mousePoint.Y;
            }
            else
            {
                returnRectangle.X = startPoint.X;
                returnRectangle.Y = startPoint.Y;
            }

            return returnRectangle;
        }

        private void questionPicture_MouseUp(object sender, MouseEventArgs e)
        {
            setSelction();
        }

        public void setSelction()
        {
            if (createNewParameter)
            {
                createNewParameter = false;
            }
            gfx.DrawRectangle(Pens.Black, currentSelection);
            questionPicture.Image = questionImage;
        }
        private void questionPicture_MouseDown(object sender, MouseEventArgs e)
        {
            if (!createNewParameter)
            {
                createNewParameter = true;
                currentSelection = new Rectangle(e.X, e.Y, 0, 0);
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void generateQuestionButton_Click(object sender, EventArgs e)
        {
            Bitmap awnserImage = new Bitmap(originalImage);

            Color rowPixel;
            for (int i = 0; i < currentSelection.Height; i++)
            {
                rowPixel = awnserImage.GetPixel(currentSelection.X, currentSelection.Y + i);
                for (int ii = 0; ii < currentSelection.Width; ii++)
                {
                    Point currentPixel = new Point(currentSelection.X + ii, currentSelection.Y + i);
                    awnserImage.SetPixel(currentPixel.X, currentPixel.Y, rowPixel);
                }
            }
            awnserPicture.Image = awnserImage;

            replacementLabel.Text = possibilities.Items[random.Next(0, possibilities.Items.Count)].ToString();
            replacementLabel.Left = currentSelection.X + currentSelection.Width / 2 - replacementLabel.Width / 2;
            replacementLabel.Top = currentSelection.Y + currentSelection.Height / 2 - replacementLabel.Height / 2;
        }


        private void addPosibilityButton_Click(object sender, EventArgs e)
        {
            possibilities.Items.Add(newPossibility.Text);
            newPossibility.Text = "";
        }

        private void removePosibilityButton_Click(object sender, EventArgs e)
        {
            possibilities.Items.Remove(possibilities.SelectedItem);
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            possibilities.Items.Clear();
            openFileDialog1.ShowDialog();
        }
        string filePath;
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            filePath = openFileDialog1.FileName;
            questionPicture.Image = Bitmap.FromStream(openFileDialog1.OpenFile());
            originalImage = new Bitmap(questionPicture.Image);
            questionImage = new Bitmap(questionPicture.Image);
            gfx = Graphics.FromImage(questionImage);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            XElement question;
            question = new XElement("Question");
            for (int i = 0; i < xdoc.Root.Elements("Question").ToArray().Count(); i++)
            {
                if (xdoc.Root.Elements("Question").ToArray()[i].FirstAttribute.Value == questionName.Text)
                {
                    xdoc.Root.Elements("Question").ToArray()[i].Remove();
                }
            }

            question.Add(new XAttribute("name", questionName.Text));
            question.Add(new XAttribute("deleted", "false"));
            question.Add(new XElement("CorrectAnwser", filePath));


            XElement selection = new XElement("Selction");
            selection.Add(new XElement("X", currentSelection.X));
            selection.Add(new XElement("Y", currentSelection.Y));
            selection.Add(new XElement("Width", currentSelection.Width));
            selection.Add(new XElement("Height", currentSelection.Height));

            XElement replacements = new XElement("Replacements");

            foreach (object replacement in possibilities.Items)
            {
                replacements.Add(new XElement("Replacement", replacement));
            }

            question.Add(selection);
            question.Add(replacements);
            xdoc.Root.Add(question);

            xdoc.Save("Questions.xml");

            showQuestions();
        }

        private void openQuestion_Click(object sender, EventArgs e)
        {
            foreach (XElement question in xdoc.Root.Elements("Question"))
            {
                if (question.FirstAttribute.Value == questions.SelectedItem.ToString())
                {
                    filePath = question.Element("CorrectAnwser").Value;
                    questionPicture.Load(filePath);
                    originalImage = new Bitmap(questionPicture.Image);
                    questionImage = new Bitmap(questionPicture.Image);
                    gfx = Graphics.FromImage(questionImage);

                    possibilities.Items.Clear();
                    foreach (XElement replacement in question.Element("Replacements").Elements("Replacement"))
                    {
                        possibilities.Items.Add(replacement.Value);
                    }

                    XElement selection = question.Element("Selction");
                    currentSelection = new Rectangle(int.Parse(selection.Element("X").Value), int.Parse(selection.Element("Y").Value), int.Parse(selection.Element("Width").Value), int.Parse(selection.Element("Height").Value));
                    setSelction();

                    questionName.Text = question.FirstAttribute.Value;

                }
            }

        }

        private void deleteQuestionButton_Click(object sender, EventArgs e)
        {
            foreach (XElement question in xdoc.Root.Elements("Question"))
            {
                if (question.FirstAttribute.Value == questions.SelectedItem.ToString())
                {
                    question.Attribute("deleted").SetValue("true");
                }
            }
            xdoc.Save("Questions.xml");
            showQuestions();
        }
    }
}
