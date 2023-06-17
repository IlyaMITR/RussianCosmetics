namespace RussianCosmetics
{
    partial class AddOrderForm
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
            this.OrderClientNameComboBox = new System.Windows.Forms.ComboBox();
            this.OrderClientNameLabel = new System.Windows.Forms.Label();
            this.OrderUslugaLabel = new System.Windows.Forms.Label();
            this.OrderUslugaListBox = new System.Windows.Forms.ListBox();
            this.OrderCancelButton = new System.Windows.Forms.Button();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderClientNameComboBox
            // 
            this.OrderClientNameComboBox.FormattingEnabled = true;
            this.OrderClientNameComboBox.Location = new System.Drawing.Point(97, 37);
            this.OrderClientNameComboBox.Name = "OrderClientNameComboBox";
            this.OrderClientNameComboBox.Size = new System.Drawing.Size(184, 21);
            this.OrderClientNameComboBox.TabIndex = 0;
            // 
            // OrderClientNameLabel
            // 
            this.OrderClientNameLabel.AutoSize = true;
            this.OrderClientNameLabel.Location = new System.Drawing.Point(31, 40);
            this.OrderClientNameLabel.Name = "OrderClientNameLabel";
            this.OrderClientNameLabel.Size = new System.Drawing.Size(43, 13);
            this.OrderClientNameLabel.TabIndex = 1;
            this.OrderClientNameLabel.Text = "Клиент";
            // 
            // OrderUslugaLabel
            // 
            this.OrderUslugaLabel.AutoSize = true;
            this.OrderUslugaLabel.Location = new System.Drawing.Point(31, 81);
            this.OrderUslugaLabel.Name = "OrderUslugaLabel";
            this.OrderUslugaLabel.Size = new System.Drawing.Size(43, 13);
            this.OrderUslugaLabel.TabIndex = 3;
            this.OrderUslugaLabel.Text = "Услуги";
            // 
            // OrderUslugaListBox
            // 
            this.OrderUslugaListBox.FormattingEnabled = true;
            this.OrderUslugaListBox.Location = new System.Drawing.Point(97, 81);
            this.OrderUslugaListBox.MaximumSize = new System.Drawing.Size(184, 300);
            this.OrderUslugaListBox.MinimumSize = new System.Drawing.Size(184, 100);
            this.OrderUslugaListBox.Name = "OrderUslugaListBox";
            this.OrderUslugaListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.OrderUslugaListBox.Size = new System.Drawing.Size(184, 108);
            this.OrderUslugaListBox.TabIndex = 5;
            // 
            // OrderCancelButton
            // 
            this.OrderCancelButton.Location = new System.Drawing.Point(110, 401);
            this.OrderCancelButton.Name = "OrderCancelButton";
            this.OrderCancelButton.Size = new System.Drawing.Size(75, 23);
            this.OrderCancelButton.TabIndex = 6;
            this.OrderCancelButton.Text = "Отмена";
            this.OrderCancelButton.UseVisualStyleBackColor = true;
            this.OrderCancelButton.Click += new System.EventHandler(this.OrderCancelButton_Click);
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(206, 401);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(75, 23);
            this.AddOrderButton.TabIndex = 7;
            this.AddOrderButton.Text = "Оформить";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 450);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.OrderCancelButton);
            this.Controls.Add(this.OrderUslugaListBox);
            this.Controls.Add(this.OrderUslugaLabel);
            this.Controls.Add(this.OrderClientNameLabel);
            this.Controls.Add(this.OrderClientNameComboBox);
            this.Name = "AddOrderForm";
            this.Text = "Отмена";
            this.Load += new System.EventHandler(this.AddOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox OrderClientNameComboBox;
        private System.Windows.Forms.Label OrderClientNameLabel;
        private System.Windows.Forms.Label OrderUslugaLabel;
        private System.Windows.Forms.ListBox OrderUslugaListBox;
        private System.Windows.Forms.Button OrderCancelButton;
        private System.Windows.Forms.Button AddOrderButton;
    }
}