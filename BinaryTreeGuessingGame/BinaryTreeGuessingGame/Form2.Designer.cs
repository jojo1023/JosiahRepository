namespace BinaryTreeGuessingGame
{
    partial class Form2
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
            this.AddNewQuestion = new System.Windows.Forms.Button();
            this.AddNewAwnser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewQuestion
            // 
            this.AddNewQuestion.Location = new System.Drawing.Point(33, 44);
            this.AddNewQuestion.Name = "AddNewQuestion";
            this.AddNewQuestion.Size = new System.Drawing.Size(107, 103);
            this.AddNewQuestion.TabIndex = 0;
            this.AddNewQuestion.Text = "Add New Question";
            this.AddNewQuestion.UseVisualStyleBackColor = true;
            this.AddNewQuestion.Click += new System.EventHandler(this.AddNewQuestion_Click);
            // 
            // AddNewAwnser
            // 
            this.AddNewAwnser.Location = new System.Drawing.Point(193, 44);
            this.AddNewAwnser.Name = "AddNewAwnser";
            this.AddNewAwnser.Size = new System.Drawing.Size(107, 103);
            this.AddNewAwnser.TabIndex = 1;
            this.AddNewAwnser.Text = "Add New Awnser";
            this.AddNewAwnser.UseVisualStyleBackColor = true;
            this.AddNewAwnser.Click += new System.EventHandler(this.AddNewAwnser_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 200);
            this.Controls.Add(this.AddNewAwnser);
            this.Controls.Add(this.AddNewQuestion);
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewQuestion;
        private System.Windows.Forms.Button AddNewAwnser;
    }
}