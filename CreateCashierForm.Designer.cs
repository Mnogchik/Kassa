
namespace Касса
{
    partial class CreateCashierForm
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
            this.registerButton = new System.Windows.Forms.Button();
            this.back_to_menu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newLoginTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerButton.Location = new System.Drawing.Point(23, 206);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(246, 48);
            this.registerButton.TabIndex = 12;
            this.registerButton.Text = "Зарегистрировать\r\n";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // back_to_menu
            // 
            this.back_to_menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back_to_menu.Location = new System.Drawing.Point(87, 344);
            this.back_to_menu.Name = "back_to_menu";
            this.back_to_menu.Size = new System.Drawing.Size(106, 27);
            this.back_to_menu.TabIndex = 11;
            this.back_to_menu.Text = "Назад";
            this.back_to_menu.UseVisualStyleBackColor = true;
            this.back_to_menu.Click += new System.EventHandler(this.back_to_menu_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(115, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Пароль";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newPasswordTextBox.Location = new System.Drawing.Point(23, 147);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(246, 23);
            this.newPasswordTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(115, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Логин";
            // 
            // newLoginTextBox
            // 
            this.newLoginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newLoginTextBox.Location = new System.Drawing.Point(23, 73);
            this.newLoginTextBox.Name = "newLoginTextBox";
            this.newLoginTextBox.Size = new System.Drawing.Size(246, 23);
            this.newLoginTextBox.TabIndex = 7;
            // 
            // CreateCashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 383);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.back_to_menu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newLoginTextBox);
            this.Name = "CreateCashierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Регистрация нового кассира";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button back_to_menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newLoginTextBox;
    }
}