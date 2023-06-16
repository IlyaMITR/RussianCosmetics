namespace RussianCosmetics
{
    partial class AddUslugaForm
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
            this.UslugaNameText = new System.Windows.Forms.TextBox();
            this.UslugaNameLabel = new System.Windows.Forms.Label();
            this.UslugaPriceLabel = new System.Windows.Forms.Label();
            this.UslugaPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UslugaPriceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // UslugaNameText
            // 
            this.UslugaNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UslugaNameText.Location = new System.Drawing.Point(125, 46);
            this.UslugaNameText.Name = "UslugaNameText";
            this.UslugaNameText.Size = new System.Drawing.Size(210, 20);
            this.UslugaNameText.TabIndex = 0;
            // 
            // UslugaNameLabel
            // 
            this.UslugaNameLabel.AutoSize = true;
            this.UslugaNameLabel.Location = new System.Drawing.Point(26, 49);
            this.UslugaNameLabel.Name = "UslugaNameLabel";
            this.UslugaNameLabel.Size = new System.Drawing.Size(93, 13);
            this.UslugaNameLabel.TabIndex = 1;
            this.UslugaNameLabel.Text = "Название услуги";
            // 
            // UslugaPriceLabel
            // 
            this.UslugaPriceLabel.AutoSize = true;
            this.UslugaPriceLabel.Location = new System.Drawing.Point(26, 90);
            this.UslugaPriceLabel.Name = "UslugaPriceLabel";
            this.UslugaPriceLabel.Size = new System.Drawing.Size(98, 13);
            this.UslugaPriceLabel.TabIndex = 3;
            this.UslugaPriceLabel.Text = "Стоимость услуги";
            // 
            // UslugaPriceNumericUpDown
            // 
            this.UslugaPriceNumericUpDown.Location = new System.Drawing.Point(125, 88);
            this.UslugaPriceNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.UslugaPriceNumericUpDown.Name = "UslugaPriceNumericUpDown";
            this.UslugaPriceNumericUpDown.Size = new System.Drawing.Size(210, 20);
            this.UslugaPriceNumericUpDown.TabIndex = 4;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(260, 151);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(167, 151);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddUslugaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 197);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.UslugaPriceNumericUpDown);
            this.Controls.Add(this.UslugaPriceLabel);
            this.Controls.Add(this.UslugaNameLabel);
            this.Controls.Add(this.UslugaNameText);
            this.Name = "AddUslugaForm";
            this.Text = "AddUslugaForm";
            ((System.ComponentModel.ISupportInitialize)(this.UslugaPriceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UslugaNameText;
        private System.Windows.Forms.Label UslugaNameLabel;
        private System.Windows.Forms.Label UslugaPriceLabel;
        private System.Windows.Forms.NumericUpDown UslugaPriceNumericUpDown;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
    }
}