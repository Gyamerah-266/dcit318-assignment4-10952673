﻿namespace WindowsFormsApp1_3
{
    namespace WindowsFormsApp
    {
        partial class Loginscreen
        {
            private System.ComponentModel.IContainer components = null;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            private void InitializeComponent()
            {
                this.usernameTextBox = new System.Windows.Forms.TextBox();
                this.passwordTextBox = new System.Windows.Forms.TextBox();
                this.loginButton = new System.Windows.Forms.Button();
                this.SuspendLayout();
                // 
                // usernameTextBox
                // 
                this.usernameTextBox.Location = new System.Drawing.Point(80, 40);
                this.usernameTextBox.Name = "usernameTextBox";
                this.usernameTextBox.Size = new System.Drawing.Size(200, 20);
                this.usernameTextBox.TabIndex = 0;
                // 
                // passwordTextBox
                // 
                this.passwordTextBox.Location = new System.Drawing.Point(80, 80);
                this.passwordTextBox.Name = "passwordTextBox";
                this.passwordTextBox.Size = new System.Drawing.Size(200, 20);
                this.passwordTextBox.TabIndex = 1;
                // 
                // loginButton
                // 
                this.loginButton.Location = new System.Drawing.Point(140, 120);
                this.loginButton.Name = "loginButton";
                this.loginButton.Size = new System.Drawing.Size(75, 23);
                this.loginButton.TabIndex = 2;
                this.loginButton.Text = "Login";
                this.loginButton.UseVisualStyleBackColor = true;
                this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
                // 
                // Form1
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(364, 201);
                this.Controls.Add(this.loginButton);
                this.Controls.Add(this.passwordTextBox);
                this.Controls.Add(this.usernameTextBox);
                this.Name = "Form1";
                this.Text = "Login";
                this.ResumeLayout(false);
                this.PerformLayout();
            }

            private System.Windows.Forms.TextBox usernameTextBox;
            private System.Windows.Forms.TextBox passwordTextBox;
            private System.Windows.Forms.Button loginButton;
        }
    }
