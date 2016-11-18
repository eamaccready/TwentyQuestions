namespace TwentyQuestions
{
    partial class AddNewItem
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
            this.AddNewLabel = new System.Windows.Forms.Label();
            this.AddNewText = new System.Windows.Forms.TextBox();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.AddNewPic = new System.Windows.Forms.PictureBox();
            this.AddNewQuestion = new System.Windows.Forms.TextBox();
            this.LabelYes = new System.Windows.Forms.Label();
            this.LabelNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AddNewPic)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNewLabel
            // 
            this.AddNewLabel.AutoSize = true;
            this.AddNewLabel.Location = new System.Drawing.Point(226, 194);
            this.AddNewLabel.Name = "AddNewLabel";
            this.AddNewLabel.Size = new System.Drawing.Size(51, 20);
            this.AddNewLabel.TabIndex = 0;
            this.AddNewLabel.Text = "label1";
            // 
            // AddNewText
            // 
            this.AddNewText.Location = new System.Drawing.Point(230, 296);
            this.AddNewText.Name = "AddNewText";
            this.AddNewText.Size = new System.Drawing.Size(202, 26);
            this.AddNewText.TabIndex = 1;
            this.AddNewText.TextChanged += new System.EventHandler(this.AddNewText_TextChanged);
            // 
            // AddNewButton
            // 
            this.AddNewButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddNewButton.Location = new System.Drawing.Point(266, 457);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(127, 39);
            this.AddNewButton.TabIndex = 2;
            this.AddNewButton.Text = "Enter";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // AddNewPic
            // 
            this.AddNewPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddNewPic.Image = global::TwentyQuestions.Properties.Resources.johnny5;
            this.AddNewPic.Location = new System.Drawing.Point(266, 27);
            this.AddNewPic.Name = "AddNewPic";
            this.AddNewPic.Size = new System.Drawing.Size(127, 154);
            this.AddNewPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddNewPic.TabIndex = 3;
            this.AddNewPic.TabStop = false;
            this.AddNewPic.Click += new System.EventHandler(this.AddNewPic_Click);
            // 
            // AddNewQuestion
            // 
            this.AddNewQuestion.Location = new System.Drawing.Point(161, 381);
            this.AddNewQuestion.Name = "AddNewQuestion";
            this.AddNewQuestion.Size = new System.Drawing.Size(328, 26);
            this.AddNewQuestion.TabIndex = 5;
            // 
            // LabelYes
            // 
            this.LabelYes.AutoSize = true;
            this.LabelYes.Location = new System.Drawing.Point(194, 250);
            this.LabelYes.Name = "LabelYes";
            this.LabelYes.Size = new System.Drawing.Size(51, 20);
            this.LabelYes.TabIndex = 7;
            this.LabelYes.Text = "label1";
            this.LabelYes.Click += new System.EventHandler(this.LabelYes_Click);
            // 
            // LabelNo
            // 
            this.LabelNo.AutoSize = true;
            this.LabelNo.Location = new System.Drawing.Point(135, 333);
            this.LabelNo.Name = "LabelNo";
            this.LabelNo.Size = new System.Drawing.Size(51, 20);
            this.LabelNo.TabIndex = 8;
            this.LabelNo.Text = "label1";
            this.LabelNo.Click += new System.EventHandler(this.LabelNo_Click);
            // 
            // AddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 541);
            this.Controls.Add(this.LabelNo);
            this.Controls.Add(this.LabelYes);
            this.Controls.Add(this.AddNewQuestion);
            this.Controls.Add(this.AddNewPic);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.AddNewText);
            this.Controls.Add(this.AddNewLabel);
            this.Name = "AddNewItem";
            this.Text = "AddNewItem";
            this.Load += new System.EventHandler(this.AddNewItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddNewPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddNewLabel;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.PictureBox AddNewPic;
        public System.Windows.Forms.TextBox AddNewText;
        private System.Windows.Forms.TextBox AddNewQuestion;
        private System.Windows.Forms.Label LabelYes;
        private System.Windows.Forms.Label LabelNo;
    }
}