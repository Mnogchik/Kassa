
namespace Касса
{
    partial class ChangeAdmPassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeAdmPassForm));
            this.ChangePassButton = new System.Windows.Forms.Button();
            this.back_to_menu = new System.Windows.Forms.Button();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ShowHidePassButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShowHidePassButton)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangePassButton
            // 
            this.ChangePassButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangePassButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangePassButton.Location = new System.Drawing.Point(23, 177);
            this.ChangePassButton.Name = "ChangePassButton";
            this.ChangePassButton.Size = new System.Drawing.Size(220, 54);
            this.ChangePassButton.TabIndex = 16;
            this.ChangePassButton.Text = "Изменить";
            this.ChangePassButton.UseVisualStyleBackColor = true;
            this.ChangePassButton.Click += new System.EventHandler(this.ChangePassButton_Click);
            // 
            // back_to_menu
            // 
            this.back_to_menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back_to_menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back_to_menu.Location = new System.Drawing.Point(88, 342);
            this.back_to_menu.Name = "back_to_menu";
            this.back_to_menu.Size = new System.Drawing.Size(85, 29);
            this.back_to_menu.TabIndex = 15;
            this.back_to_menu.Text = "Назад";
            this.back_to_menu.UseVisualStyleBackColor = true;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPasswordTextBox.Location = new System.Drawing.Point(10, 121);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PlaceholderText = "  Введите новый пароль";
            this.newPasswordTextBox.Size = new System.Drawing.Size(210, 29);
            this.newPasswordTextBox.TabIndex = 13;
            this.newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // ShowHidePassButton
            // 
            this.ShowHidePassButton.BackColor = System.Drawing.Color.Transparent;
            this.ShowHidePassButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShowHidePassButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowHidePassButton.Image")));
            this.ShowHidePassButton.Location = new System.Drawing.Point(221, 121);
            this.ShowHidePassButton.Name = "ShowHidePassButton";
            this.ShowHidePassButton.Size = new System.Drawing.Size(40, 29);
            this.ShowHidePassButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowHidePassButton.TabIndex = 18;
            this.ShowHidePassButton.TabStop = false;
            this.ShowHidePassButton.Click += new System.EventHandler(this.ShowHidePassButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(104, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Admin";
            // 
            // ChangeAdmPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowHidePassButton);
            this.Controls.Add(this.ChangePassButton);
            this.Controls.Add(this.back_to_menu);
            this.Controls.Add(this.newPasswordTextBox);
            this.Name = "ChangeAdmPassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Сменить пароль администратора";
            ((System.ComponentModel.ISupportInitialize)(this.ShowHidePassButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangePassButton;
        private System.Windows.Forms.Button back_to_menu;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.PictureBox ShowHidePassButton;
        private System.Windows.Forms.Label label1;
    }
}