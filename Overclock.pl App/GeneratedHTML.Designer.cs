namespace Overclock.pl_App
{
    partial class GeneratedHTML
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
            this.textField = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textField
            // 
            this.textField.Location = new System.Drawing.Point(12, 12);
            this.textField.Multiline = true;
            this.textField.Name = "textField";
            this.textField.Size = new System.Drawing.Size(260, 238);
            this.textField.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(157, 256);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(115, 30);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Zamknij okno";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(12, 256);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(115, 30);
            this.copyButton.TabIndex = 2;
            this.copyButton.Text = "Skopiuj do schowka";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // GeneratedHTML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 298);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.textField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GeneratedHTML";
            this.Text = "Kod HTML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textField;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button copyButton;

    }
}