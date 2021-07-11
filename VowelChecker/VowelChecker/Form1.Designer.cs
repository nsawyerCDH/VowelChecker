
namespace VowelChecker
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
            this.UserStringTextbox = new System.Windows.Forms.TextBox();
            this.EnterStringLabel = new System.Windows.Forms.Label();
            this.CountVowelsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserStringTextbox
            // 
            this.UserStringTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserStringTextbox.Location = new System.Drawing.Point(15, 49);
            this.UserStringTextbox.Name = "UserStringTextbox";
            this.UserStringTextbox.Size = new System.Drawing.Size(223, 20);
            this.UserStringTextbox.TabIndex = 0;
            // 
            // EnterStringLabel
            // 
            this.EnterStringLabel.AutoSize = true;
            this.EnterStringLabel.Location = new System.Drawing.Point(12, 33);
            this.EnterStringLabel.Name = "EnterStringLabel";
            this.EnterStringLabel.Size = new System.Drawing.Size(108, 13);
            this.EnterStringLabel.TabIndex = 1;
            this.EnterStringLabel.Text = "Enter a string of Text:";
            // 
            // CountVowelsButton
            // 
            this.CountVowelsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CountVowelsButton.Location = new System.Drawing.Point(152, 75);
            this.CountVowelsButton.Name = "CountVowelsButton";
            this.CountVowelsButton.Size = new System.Drawing.Size(86, 23);
            this.CountVowelsButton.TabIndex = 2;
            this.CountVowelsButton.Text = "Count Vowels!";
            this.CountVowelsButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 107);
            this.Controls.Add(this.CountVowelsButton);
            this.Controls.Add(this.EnterStringLabel);
            this.Controls.Add(this.UserStringTextbox);
            this.MinimumSize = new System.Drawing.Size(266, 146);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserStringTextbox;
        private System.Windows.Forms.Label EnterStringLabel;
        private System.Windows.Forms.Button CountVowelsButton;
    }
}

