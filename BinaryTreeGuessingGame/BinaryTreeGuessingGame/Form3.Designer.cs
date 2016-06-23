namespace BinaryTreeGuessingGame
{
    partial class Form3
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
            this.QuestionOrAwnserLabel = new System.Windows.Forms.Label();
            this.NewQuestionAwnser = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionOrAwnserLabel
            // 
            this.QuestionOrAwnserLabel.AutoSize = true;
            this.QuestionOrAwnserLabel.Location = new System.Drawing.Point(12, 18);
            this.QuestionOrAwnserLabel.Name = "QuestionOrAwnserLabel";
            this.QuestionOrAwnserLabel.Size = new System.Drawing.Size(0, 13);
            this.QuestionOrAwnserLabel.TabIndex = 0;
            // 
            // NewQuestionAwnser
            // 
            this.NewQuestionAwnser.Location = new System.Drawing.Point(32, 112);
            this.NewQuestionAwnser.Name = "NewQuestionAwnser";
            this.NewQuestionAwnser.Size = new System.Drawing.Size(214, 20);
            this.NewQuestionAwnser.TabIndex = 1;
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(99, 197);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(83, 22);
            this.EnterButton.TabIndex = 2;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.NewQuestionAwnser);
            this.Controls.Add(this.QuestionOrAwnserLabel);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionOrAwnserLabel;
        private System.Windows.Forms.TextBox NewQuestionAwnser;
        private System.Windows.Forms.Button EnterButton;
    }
}