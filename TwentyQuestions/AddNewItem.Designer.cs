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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewLabel
            // 
            this.AddNewLabel.AutoSize = true;
            this.AddNewLabel.Location = new System.Drawing.Point(112, 22);
            this.AddNewLabel.Name = "AddNewLabel";
            this.AddNewLabel.Size = new System.Drawing.Size(51, 20);
            this.AddNewLabel.TabIndex = 0;
            this.AddNewLabel.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 26);
            this.textBox1.TabIndex = 1;
            // 
            // AddNewButton
            // 
            this.AddNewButton.Location = new System.Drawing.Point(94, 130);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(87, 33);
            this.AddNewButton.TabIndex = 2;
            this.AddNewButton.Text = "Enter";
            this.AddNewButton.UseVisualStyleBackColor = true;
            // 
            // AddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddNewLabel);
            this.Name = "AddNewItem";
            this.Text = "AddNewItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddNewLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddNewButton;
    }
}