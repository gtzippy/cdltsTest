namespace PrimeFactorizationGUI
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
            this.fileSelectButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.computePrimesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileSelectButton
            // 
            this.fileSelectButton.Location = new System.Drawing.Point(13, 47);
            this.fileSelectButton.Name = "fileSelectButton";
            this.fileSelectButton.Size = new System.Drawing.Size(75, 23);
            this.fileSelectButton.TabIndex = 0;
            this.fileSelectButton.Text = "Select File";
            this.fileSelectButton.UseVisualStyleBackColor = true;
            this.fileSelectButton.Click += new System.EventHandler(this.fileSelectButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 86);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(452, 222);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "No File Selected";
            // 
            // computePrimesButton
            // 
            this.computePrimesButton.Enabled = false;
            this.computePrimesButton.Location = new System.Drawing.Point(109, 47);
            this.computePrimesButton.Name = "computePrimesButton";
            this.computePrimesButton.Size = new System.Drawing.Size(96, 23);
            this.computePrimesButton.TabIndex = 3;
            this.computePrimesButton.Text = "Compute Primes";
            this.computePrimesButton.UseVisualStyleBackColor = true;
            this.computePrimesButton.Click += new System.EventHandler(this.computePrimesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 320);
            this.Controls.Add(this.computePrimesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.fileSelectButton);
            this.Name = "Form1";
            this.Text = "Prime Factorization App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileSelectButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button computePrimesButton;
    }
}

