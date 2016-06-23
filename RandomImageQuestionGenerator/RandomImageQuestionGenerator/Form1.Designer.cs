namespace RandomImageQuestionGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.questionPicture = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.awnserPicture = new System.Windows.Forms.PictureBox();
            this.replacementLabel = new System.Windows.Forms.Label();
            this.possibilities = new System.Windows.Forms.ListBox();
            this.generateQuestionButton = new System.Windows.Forms.Button();
            this.newPossibility = new System.Windows.Forms.TextBox();
            this.addPosibilityButton = new System.Windows.Forms.Button();
            this.removePosibilityButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFile = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.questions = new System.Windows.Forms.ListBox();
            this.openQuestion = new System.Windows.Forms.Button();
            this.questionName = new System.Windows.Forms.TextBox();
            this.deleteQuestionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.questionPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awnserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // questionPicture
            // 
            this.questionPicture.Enabled = false;
            this.questionPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("questionPicture.InitialImage")));
            this.questionPicture.Location = new System.Drawing.Point(0, 0);
            this.questionPicture.Name = "questionPicture";
            this.questionPicture.Size = new System.Drawing.Size(563, 453);
            this.questionPicture.TabIndex = 0;
            this.questionPicture.TabStop = false;
            this.questionPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.questionPicture_MouseDown);
            this.questionPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.questionPicture_MouseMove);
            this.questionPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.questionPicture_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // awnserPicture
            // 
            this.awnserPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("awnserPicture.InitialImage")));
            this.awnserPicture.Location = new System.Drawing.Point(695, 0);
            this.awnserPicture.Name = "awnserPicture";
            this.awnserPicture.Size = new System.Drawing.Size(563, 453);
            this.awnserPicture.TabIndex = 1;
            this.awnserPicture.TabStop = false;
            // 
            // replacementLabel
            // 
            this.replacementLabel.AutoSize = true;
            this.replacementLabel.BackColor = System.Drawing.Color.Transparent;
            this.replacementLabel.Location = new System.Drawing.Point(0, 0);
            this.replacementLabel.Name = "replacementLabel";
            this.replacementLabel.Size = new System.Drawing.Size(0, 13);
            this.replacementLabel.TabIndex = 2;
            // 
            // possibilities
            // 
            this.possibilities.Enabled = false;
            this.possibilities.FormattingEnabled = true;
            this.possibilities.Location = new System.Drawing.Point(569, 59);
            this.possibilities.Name = "possibilities";
            this.possibilities.Size = new System.Drawing.Size(120, 108);
            this.possibilities.TabIndex = 3;
            // 
            // generateQuestionButton
            // 
            this.generateQuestionButton.Enabled = false;
            this.generateQuestionButton.Location = new System.Drawing.Point(431, 459);
            this.generateQuestionButton.Name = "generateQuestionButton";
            this.generateQuestionButton.Size = new System.Drawing.Size(132, 23);
            this.generateQuestionButton.TabIndex = 4;
            this.generateQuestionButton.Text = "Generate Question";
            this.generateQuestionButton.UseVisualStyleBackColor = true;
            this.generateQuestionButton.Click += new System.EventHandler(this.generateQuestionButton_Click);
            // 
            // newPossibility
            // 
            this.newPossibility.Enabled = false;
            this.newPossibility.Location = new System.Drawing.Point(568, 4);
            this.newPossibility.Name = "newPossibility";
            this.newPossibility.Size = new System.Drawing.Size(119, 20);
            this.newPossibility.TabIndex = 5;
            // 
            // addPosibilityButton
            // 
            this.addPosibilityButton.Enabled = false;
            this.addPosibilityButton.Location = new System.Drawing.Point(569, 30);
            this.addPosibilityButton.Name = "addPosibilityButton";
            this.addPosibilityButton.Size = new System.Drawing.Size(118, 23);
            this.addPosibilityButton.TabIndex = 6;
            this.addPosibilityButton.Text = "Add Posibility";
            this.addPosibilityButton.UseVisualStyleBackColor = true;
            this.addPosibilityButton.Click += new System.EventHandler(this.addPosibilityButton_Click);
            // 
            // removePosibilityButton
            // 
            this.removePosibilityButton.Enabled = false;
            this.removePosibilityButton.Location = new System.Drawing.Point(568, 173);
            this.removePosibilityButton.Name = "removePosibilityButton";
            this.removePosibilityButton.Size = new System.Drawing.Size(121, 23);
            this.removePosibilityButton.TabIndex = 7;
            this.removePosibilityButton.Text = "Remove Posibility";
            this.removePosibilityButton.UseVisualStyleBackColor = true;
            this.removePosibilityButton.Click += new System.EventHandler(this.removePosibilityButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(0, 459);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 23);
            this.openFile.TabIndex = 8;
            this.openFile.Text = "Open File";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1183, 459);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save Question";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // questions
            // 
            this.questions.FormattingEnabled = true;
            this.questions.Location = new System.Drawing.Point(569, 329);
            this.questions.Name = "questions";
            this.questions.Size = new System.Drawing.Size(121, 95);
            this.questions.TabIndex = 10;
            // 
            // openQuestion
            // 
            this.openQuestion.Location = new System.Drawing.Point(569, 300);
            this.openQuestion.Name = "openQuestion";
            this.openQuestion.Size = new System.Drawing.Size(121, 23);
            this.openQuestion.TabIndex = 11;
            this.openQuestion.Text = "Open Question";
            this.openQuestion.UseVisualStyleBackColor = true;
            this.openQuestion.Click += new System.EventHandler(this.openQuestion_Click);
            // 
            // questionName
            // 
            this.questionName.Location = new System.Drawing.Point(1077, 462);
            this.questionName.Name = "questionName";
            this.questionName.Size = new System.Drawing.Size(100, 20);
            this.questionName.TabIndex = 12;
            this.questionName.Text = "Question Name";
            // 
            // deleteQuestionButton
            // 
            this.deleteQuestionButton.Location = new System.Drawing.Point(569, 430);
            this.deleteQuestionButton.Name = "deleteQuestionButton";
            this.deleteQuestionButton.Size = new System.Drawing.Size(121, 23);
            this.deleteQuestionButton.TabIndex = 13;
            this.deleteQuestionButton.Text = "Delete Question";
            this.deleteQuestionButton.UseVisualStyleBackColor = true;
            this.deleteQuestionButton.Click += new System.EventHandler(this.deleteQuestionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 556);
            this.Controls.Add(this.deleteQuestionButton);
            this.Controls.Add(this.questionName);
            this.Controls.Add(this.openQuestion);
            this.Controls.Add(this.questions);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.removePosibilityButton);
            this.Controls.Add(this.addPosibilityButton);
            this.Controls.Add(this.newPossibility);
            this.Controls.Add(this.generateQuestionButton);
            this.Controls.Add(this.possibilities);
            this.Controls.Add(this.replacementLabel);
            this.Controls.Add(this.awnserPicture);
            this.Controls.Add(this.questionPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awnserPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox questionPicture;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox awnserPicture;
        private System.Windows.Forms.Label replacementLabel;
        private System.Windows.Forms.ListBox possibilities;
        private System.Windows.Forms.Button generateQuestionButton;
        private System.Windows.Forms.TextBox newPossibility;
        private System.Windows.Forms.Button addPosibilityButton;
        private System.Windows.Forms.Button removePosibilityButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox questions;
        private System.Windows.Forms.Button openQuestion;
        private System.Windows.Forms.TextBox questionName;
        private System.Windows.Forms.Button deleteQuestionButton;
    }
}

