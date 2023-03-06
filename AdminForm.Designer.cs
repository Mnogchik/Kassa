
namespace Касса
{
    partial class AdminForm
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
            this.CashierEfficiencyButton = new System.Windows.Forms.Button();
            this.newCashierButton = new System.Windows.Forms.Button();
            this.ChangeAccountButton = new System.Windows.Forms.Button();
            this.BackToMenuButton = new System.Windows.Forms.Button();
            this.ChangeAdmPassButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CashierEfficiencyButton
            // 
            this.CashierEfficiencyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CashierEfficiencyButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CashierEfficiencyButton.Location = new System.Drawing.Point(12, 153);
            this.CashierEfficiencyButton.Name = "CashierEfficiencyButton";
            this.CashierEfficiencyButton.Size = new System.Drawing.Size(246, 56);
            this.CashierEfficiencyButton.TabIndex = 5;
            this.CashierEfficiencyButton.Text = "Посмотреть статистику всех кассиров";
            this.CashierEfficiencyButton.UseVisualStyleBackColor = true;
            this.CashierEfficiencyButton.Click += new System.EventHandler(this.CashierEfficiencyButton_Click);
            // 
            // newCashierButton
            // 
            this.newCashierButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newCashierButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newCashierButton.Location = new System.Drawing.Point(12, 29);
            this.newCashierButton.Name = "newCashierButton";
            this.newCashierButton.Size = new System.Drawing.Size(246, 56);
            this.newCashierButton.TabIndex = 4;
            this.newCashierButton.Text = "Добавить новый аккаунт кассира";
            this.newCashierButton.UseVisualStyleBackColor = true;
            this.newCashierButton.Click += new System.EventHandler(this.newCashierButton_Click);
            // 
            // ChangeAccountButton
            // 
            this.ChangeAccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeAccountButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeAccountButton.Location = new System.Drawing.Point(12, 91);
            this.ChangeAccountButton.Name = "ChangeAccountButton";
            this.ChangeAccountButton.Size = new System.Drawing.Size(246, 56);
            this.ChangeAccountButton.TabIndex = 6;
            this.ChangeAccountButton.Text = "Изменить существующий аккаунт кассира";
            this.ChangeAccountButton.UseVisualStyleBackColor = true;
            this.ChangeAccountButton.Click += new System.EventHandler(this.ChangeAccountButton_Click);
            // 
            // BackToMenuButton
            // 
            this.BackToMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackToMenuButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackToMenuButton.Location = new System.Drawing.Point(63, 340);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(141, 31);
            this.BackToMenuButton.TabIndex = 7;
            this.BackToMenuButton.Text = "Назад";
            this.BackToMenuButton.UseVisualStyleBackColor = true;
            this.BackToMenuButton.Click += new System.EventHandler(this.BackToMenuButton_Click);
            // 
            // ChangeAdmPassButton
            // 
            this.ChangeAdmPassButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeAdmPassButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeAdmPassButton.Location = new System.Drawing.Point(12, 215);
            this.ChangeAdmPassButton.Name = "ChangeAdmPassButton";
            this.ChangeAdmPassButton.Size = new System.Drawing.Size(246, 56);
            this.ChangeAdmPassButton.TabIndex = 8;
            this.ChangeAdmPassButton.Text = "Изменить пароль администратора";
            this.ChangeAdmPassButton.UseVisualStyleBackColor = true;
            this.ChangeAdmPassButton.Click += new System.EventHandler(this.ChangeAdmPassButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 383);
            this.Controls.Add(this.ChangeAdmPassButton);
            this.Controls.Add(this.BackToMenuButton);
            this.Controls.Add(this.ChangeAccountButton);
            this.Controls.Add(this.CashierEfficiencyButton);
            this.Controls.Add(this.newCashierButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CashierEfficiencyButton;
        private System.Windows.Forms.Button newCashierButton;
        //private System.Windows.Forms.Button shift_start;
        private System.Windows.Forms.Button ChangeAccountButton;
        private System.Windows.Forms.Button BackToMenuButton;
        private System.Windows.Forms.Button ChangeAdmPassButton;
    }
}