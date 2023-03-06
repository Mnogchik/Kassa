
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShiftStartButton
            // 
            this.ShiftStartButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShiftStartButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShiftStartButton.Location = new System.Drawing.Point(12, 115);
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
            this.LoginAsAdminButton.Location = new System.Drawing.Point(11, 217);
            this.LoginAsAdminButton.Name = "LoginAsAdminButton";
            this.LoginAsAdminButton.Size = new System.Drawing.Size(246, 79);
            this.LoginAsAdminButton.TabIndex = 1;
            this.LoginAsAdminButton.Text = "Зайти от администратора";
            this.LoginAsAdminButton.UseVisualStyleBackColor = true;
            this.LoginAsAdminButton.Click += new System.EventHandler(this.LoginAsAdminButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "v1.0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(90, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Касса";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 383);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginAsAdminButton);
            this.Controls.Add(this.ShiftStartButton);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShiftStartButton;
        //private System.Windows.Forms.Button new_cashier;
        //private System.Windows.Forms.Button cashier_rating;
        private System.Windows.Forms.Button LoginAsAdminButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

