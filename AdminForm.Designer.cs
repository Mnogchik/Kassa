
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
            this.cashier_rating = new System.Windows.Forms.Button();
            this.newCashierButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BackToMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cashier_rating
            // 
            this.cashier_rating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cashier_rating.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cashier_rating.Location = new System.Drawing.Point(12, 209);
            this.cashier_rating.Name = "cashier_rating";
            this.cashier_rating.Size = new System.Drawing.Size(246, 84);
            this.cashier_rating.TabIndex = 5;
            this.cashier_rating.Text = "Посмотреть эффективность всех кассиров";
            this.cashier_rating.UseVisualStyleBackColor = true;
            // 
            // newCashierButton
            // 
            this.newCashierButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newCashierButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newCashierButton.Location = new System.Drawing.Point(12, 29);
            this.newCashierButton.Name = "newCashierButton";
            this.newCashierButton.Size = new System.Drawing.Size(246, 80);
            this.newCashierButton.TabIndex = 4;
            this.newCashierButton.Text = "Добавить нового кассира";
            this.newCashierButton.UseVisualStyleBackColor = true;
            this.newCashierButton.Click += new System.EventHandler(this.newCashierButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 88);
            this.button1.TabIndex = 6;
            this.button1.Text = "Удалить существующего кассира";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BackToMenuButton
            // 
            this.BackToMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackToMenuButton.Location = new System.Drawing.Point(63, 344);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(141, 27);
            this.BackToMenuButton.TabIndex = 7;
            this.BackToMenuButton.Text = "Назад";
            this.BackToMenuButton.UseVisualStyleBackColor = true;
            this.BackToMenuButton.Click += new System.EventHandler(this.BackToMenuButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 383);
            this.Controls.Add(this.BackToMenuButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cashier_rating);
            this.Controls.Add(this.newCashierButton);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cashier_rating;
        private System.Windows.Forms.Button newCashierButton;
        //private System.Windows.Forms.Button shift_start;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BackToMenuButton;
    }
}