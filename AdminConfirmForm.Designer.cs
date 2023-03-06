
namespace Касса
{
    partial class AdminConfirmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminConfirmForm));
            this.incorrectPassLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.BackToMenuButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowHidePassButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShowHidePassButton)).BeginInit();
            this.SuspendLayout();
            // 
            // incorrectPassLabel
            // 
            this.incorrectPassLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.incorrectPassLabel.AutoSize = true;
            this.incorrectPassLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.incorrectPassLabel.Location = new System.Drawing.Point(57, 219);
            this.incorrectPassLabel.Name = "incorrectPassLabel";
            this.incorrectPassLabel.Size = new System.Drawing.Size(163, 15);
            this.incorrectPassLabel.TabIndex = 11;
            this.incorrectPassLabel.Text = "Пароль введен некорректно";
            this.incorrectPassLabel.Visible = false;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginButton.Location = new System.Drawing.Point(12, 168);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(246, 48);
            this.loginButton.TabIndex = 10;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // BackToMenuButton
            // 
            this.BackToMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackToMenuButton.Location = new System.Drawing.Point(79, 344);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(106, 27);
            this.BackToMenuButton.TabIndex = 9;
            this.BackToMenuButton.Text = "Назад";
            this.BackToMenuButton.UseVisualStyleBackColor = true;
            this.BackToMenuButton.Click += new System.EventHandler(this.BackToMenuButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.Location = new System.Drawing.Point(12, 116);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PlaceholderText = "  Пароль";
            this.passwordTextBox.Size = new System.Drawing.Size(208, 30);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Введите пароль администратора:";
            // 
            // ShowHidePassButton
            // 
            this.ShowHidePassButton.BackColor = System.Drawing.Color.Transparent;
            this.ShowHidePassButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShowHidePassButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowHidePassButton.Image")));
            this.ShowHidePassButton.Location = new System.Drawing.Point(218, 116);
            this.ShowHidePassButton.Name = "ShowHidePassButton";
            this.ShowHidePassButton.Size = new System.Drawing.Size(40, 30);
            this.ShowHidePassButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowHidePassButton.TabIndex = 19;
            this.ShowHidePassButton.TabStop = false;
            this.ShowHidePassButton.Click += new System.EventHandler(this.ShowHidePassButton_Click);
            // 
            // AdminConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 383);
            this.Controls.Add(this.ShowHidePassButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.incorrectPassLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.BackToMenuButton);
            this.Controls.Add(this.passwordTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Подтверждение";
            ((System.ComponentModel.ISupportInitialize)(this.ShowHidePassButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label incorrectPassLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button BackToMenuButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ShowHidePassButton;
    }
}