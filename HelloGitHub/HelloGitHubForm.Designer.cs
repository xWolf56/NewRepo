﻿
namespace HelloGitHub
{
    partial class HelloGitHubForm
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
            this.afficherButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // afficherButton
            // 
            this.afficherButton.Location = new System.Drawing.Point(81, 56);
            this.afficherButton.Name = "afficherButton";
            this.afficherButton.Size = new System.Drawing.Size(96, 27);
            this.afficherButton.TabIndex = 0;
            this.afficherButton.Text = "Afficher Hello GitHub";
            this.afficherButton.UseVisualStyleBackColor = true;
            this.afficherButton.Click += new System.EventHandler(this.afficherButton_Click);
            // 
            // HelloGitHubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 341);
            this.Controls.Add(this.afficherButton);
            this.Name = "HelloGitHubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello GitHub";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button afficherButton;
    }
}

