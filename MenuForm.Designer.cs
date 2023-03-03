
namespace Касса
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShiftStartButton = new System.Windows.Forms.Button();
            this.LoginAsAdminButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShiftStartButton
            // 
            this.ShiftStartButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShiftStartButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShiftStartButton.Location = new System.Drawing.Point(12, 97);
            this.ShiftStartButton.Name = "ShiftStartButton";
            this.ShiftStartButton.Size = new System.Drawing.Size(245, 75);
            this.ShiftStartButton.TabIndex = 0;
            this.ShiftStartButton.Text = "Начать смену";
            this.ShiftStartButton.UseVisualStyleBackColor = true;
            this.ShiftStartButton.Click += new System.EventHandler(this.ShiftStartButton_Click);
            // 
            // LoginAsAdminButton
            // 
            this.LoginAsAdminButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginAsAdminButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginAsAdminButton.Location = new System.Drawing.Point(11, 199);
            this.LoginAsAdminButton.Name = "LoginAsAdminButton";
            this.LoginAsAdminButton.Size = new System.Drawing.Size(246, 79);
            this.LoginAsAdminButton.TabIndex = 1;
            this.LoginAsAdminButton.Text = "Зайти от администратора";
            this.LoginAsAdminButton.UseVisualStyleBackColor = true;
            this.LoginAsAdminButton.Click += new System.EventHandler(this.LoginAsAdminButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 383);
            this.Controls.Add(this.LoginAsAdminButton);
            this.Controls.Add(this.ShiftStartButton);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShiftStartButton;
        //private System.Windows.Forms.Button new_cashier;
        //private System.Windows.Forms.Button cashier_rating;
        private System.Windows.Forms.Button LoginAsAdminButton;
    }
}

