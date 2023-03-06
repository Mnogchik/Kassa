
namespace Касса
{
    partial class ShiftForm
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
            this.endShiftLabel = new System.Windows.Forms.LinkLabel();
            this.EndShiftLinkLabel = new System.Windows.Forms.LinkLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NewPurchaseButton = new System.Windows.Forms.Button();
            this.PurchaseGroupBox = new System.Windows.Forms.GroupBox();
            this.EndPurchaseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AddedSumLabel = new System.Windows.Forms.Label();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.ArticleTextBox = new System.Windows.Forms.TextBox();
            this.ProductTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.PurchaseGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // endShiftLabel
            // 
            this.endShiftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endShiftLabel.AutoSize = true;
            this.endShiftLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endShiftLabel.Location = new System.Drawing.Point(79, 553);
            this.endShiftLabel.Name = "endShiftLabel";
            this.endShiftLabel.Size = new System.Drawing.Size(113, 17);
            this.endShiftLabel.TabIndex = 7;
            this.endShiftLabel.TabStop = true;
            this.endShiftLabel.Text = "Завершить смену";
            this.endShiftLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EndShiftLabel_LinkClicked);
            // 
            // EndShiftLinkLabel
            // 
            this.EndShiftLinkLabel.AutoSize = true;
            this.EndShiftLinkLabel.Location = new System.Drawing.Point(90, 499);
            this.EndShiftLinkLabel.Name = "EndShiftLinkLabel";
            this.EndShiftLinkLabel.Size = new System.Drawing.Size(105, 15);
            this.EndShiftLinkLabel.TabIndex = 9;
            this.EndShiftLinkLabel.TabStop = true;
            this.EndShiftLinkLabel.Text = "Завершить смену";
            this.EndShiftLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EndShiftLinkLabel_LinkClicked);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(268, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Доп. информация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(262, 462);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 79;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NewPurchaseButton);
            this.tabPage1.Controls.Add(this.PurchaseGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(268, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // NewPurchaseButton
            // 
            this.NewPurchaseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewPurchaseButton.Location = new System.Drawing.Point(8, 6);
            this.NewPurchaseButton.Name = "NewPurchaseButton";
            this.NewPurchaseButton.Size = new System.Drawing.Size(253, 64);
            this.NewPurchaseButton.TabIndex = 0;
            this.NewPurchaseButton.Text = "Новая покупка";
            this.NewPurchaseButton.UseVisualStyleBackColor = true;
            this.NewPurchaseButton.Click += new System.EventHandler(this.NewPurchaseButton_Click);
            // 
            // PurchaseGroupBox
            // 
            this.PurchaseGroupBox.Controls.Add(this.EndPurchaseButton);
            this.PurchaseGroupBox.Controls.Add(this.label3);
            this.PurchaseGroupBox.Controls.Add(this.AddedSumLabel);
            this.PurchaseGroupBox.Controls.Add(this.AddProductButton);
            this.PurchaseGroupBox.Controls.Add(this.SumTextBox);
            this.PurchaseGroupBox.Controls.Add(this.ArticleTextBox);
            this.PurchaseGroupBox.Controls.Add(this.ProductTextBox);
            this.PurchaseGroupBox.Controls.Add(this.label1);
            this.PurchaseGroupBox.Controls.Add(this.label2);
            this.PurchaseGroupBox.Location = new System.Drawing.Point(0, 76);
            this.PurchaseGroupBox.Name = "PurchaseGroupBox";
            this.PurchaseGroupBox.Size = new System.Drawing.Size(268, 396);
            this.PurchaseGroupBox.TabIndex = 9;
            this.PurchaseGroupBox.TabStop = false;
            this.PurchaseGroupBox.Visible = false;
            // 
            // EndPurchaseButton
            // 
            this.EndPurchaseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EndPurchaseButton.Location = new System.Drawing.Point(38, 336);
            this.EndPurchaseButton.Name = "EndPurchaseButton";
            this.EndPurchaseButton.Size = new System.Drawing.Size(184, 37);
            this.EndPurchaseButton.TabIndex = 9;
            this.EndPurchaseButton.Text = "Завершить покупку";
            this.EndPurchaseButton.UseVisualStyleBackColor = true;
            this.EndPurchaseButton.Click += new System.EventHandler(this.EndPurchaseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(46, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Сумма покупки:";
            // 
            // AddedSumLabel
            // 
            this.AddedSumLabel.AutoSize = true;
            this.AddedSumLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddedSumLabel.Location = new System.Drawing.Point(188, 252);
            this.AddedSumLabel.Name = "AddedSumLabel";
            this.AddedSumLabel.Size = new System.Drawing.Size(87, 25);
            this.AddedSumLabel.TabIndex = 8;
            this.AddedSumLabel.Text = "(+9999₽)";
            // 
            // AddProductButton
            // 
            this.AddProductButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddProductButton.Location = new System.Drawing.Point(55, 83);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(151, 43);
            this.AddProductButton.TabIndex = 3;
            this.AddProductButton.Text = "Добавить";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // SumTextBox
            // 
            this.SumTextBox.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SumTextBox.Location = new System.Drawing.Point(36, 236);
            this.SumTextBox.Multiline = true;
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.ReadOnly = true;
            this.SumTextBox.Size = new System.Drawing.Size(152, 58);
            this.SumTextBox.TabIndex = 7;
            this.SumTextBox.Text = "99999₽";
            this.SumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ArticleTextBox
            // 
            this.ArticleTextBox.Location = new System.Drawing.Point(9, 54);
            this.ArticleTextBox.Name = "ArticleTextBox";
            this.ArticleTextBox.Size = new System.Drawing.Size(253, 23);
            this.ArticleTextBox.TabIndex = 2;
            // 
            // ProductTextBox
            // 
            this.ProductTextBox.Location = new System.Drawing.Point(9, 162);
            this.ProductTextBox.Name = "ProductTextBox";
            this.ProductTextBox.ReadOnly = true;
            this.ProductTextBox.Size = new System.Drawing.Size(253, 23);
            this.ProductTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите код товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Добавлен товар:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(276, 496);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // ShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 523);
            this.ControlBox = false;
            this.Controls.Add(this.EndShiftLinkLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.endShiftLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ShiftForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Смена в процессе";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShiftForm_FormClosed);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.PurchaseGroupBox.ResumeLayout(false);
            this.PurchaseGroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel endShiftLabel;
        private System.Windows.Forms.LinkLabel EndShiftLinkLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label AddedSumLabel;
        private System.Windows.Forms.TextBox SumTextBox;
        private System.Windows.Forms.TextBox ProductTextBox;
        private System.Windows.Forms.TextBox ArticleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox PurchaseGroupBox;
        private System.Windows.Forms.Button NewPurchaseButton;
        private System.Windows.Forms.Button EndPurchaseButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}