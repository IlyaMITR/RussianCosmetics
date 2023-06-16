namespace RussianCosmetics
{
    partial class AddClientForm
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
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.CompanyNameText = new System.Windows.Forms.TextBox();
            this.ClientTypeLabel = new System.Windows.Forms.Label();
            this.ClientTypeComboBox = new System.Windows.Forms.ComboBox();
            this.UrPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddCompanyButton = new System.Windows.Forms.Button();
            this.CompanyEmailLabel = new System.Windows.Forms.Label();
            this.CompanyEmailText = new System.Windows.Forms.TextBox();
            this.CompanyContactNameLabel = new System.Windows.Forms.Label();
            this.CompanyContactNameText = new System.Windows.Forms.TextBox();
            this.CompanyManagerNameLabel = new System.Windows.Forms.Label();
            this.CompanyManagerNameText = new System.Windows.Forms.TextBox();
            this.CompanyBIKLabel = new System.Windows.Forms.Label();
            this.CompanyBIKText = new System.Windows.Forms.TextBox();
            this.CompanyRSLabel = new System.Windows.Forms.Label();
            this.CompanyRSText = new System.Windows.Forms.TextBox();
            this.CompanyAdressLabel = new System.Windows.Forms.Label();
            this.CompanyAdressText = new System.Windows.Forms.TextBox();
            this.CompanyINNLabel = new System.Windows.Forms.Label();
            this.CompanyINNText = new System.Windows.Forms.TextBox();
            this.FizPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ClientPhoneText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ClientPassportText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ClientEmailText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ClientNameText = new System.Windows.Forms.TextBox();
            this.ClientBirthDayPicker = new System.Windows.Forms.DateTimePicker();
            this.UrPanel.SuspendLayout();
            this.FizPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Location = new System.Drawing.Point(3, 21);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(110, 13);
            this.CompanyNameLabel.TabIndex = 3;
            this.CompanyNameLabel.Text = "Название компании";
            // 
            // CompanyNameText
            // 
            this.CompanyNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyNameText.Location = new System.Drawing.Point(136, 19);
            this.CompanyNameText.Name = "CompanyNameText";
            this.CompanyNameText.Size = new System.Drawing.Size(269, 20);
            this.CompanyNameText.TabIndex = 2;
            // 
            // ClientTypeLabel
            // 
            this.ClientTypeLabel.AutoSize = true;
            this.ClientTypeLabel.Location = new System.Drawing.Point(70, 41);
            this.ClientTypeLabel.Name = "ClientTypeLabel";
            this.ClientTypeLabel.Size = new System.Drawing.Size(53, 13);
            this.ClientTypeLabel.TabIndex = 5;
            this.ClientTypeLabel.Text = "Тип лица";
            // 
            // ClientTypeComboBox
            // 
            this.ClientTypeComboBox.FormattingEnabled = true;
            this.ClientTypeComboBox.Items.AddRange(new object[] {
            "Физическое",
            "Юридическое"});
            this.ClientTypeComboBox.Location = new System.Drawing.Point(203, 38);
            this.ClientTypeComboBox.Name = "ClientTypeComboBox";
            this.ClientTypeComboBox.Size = new System.Drawing.Size(269, 21);
            this.ClientTypeComboBox.TabIndex = 6;
            this.ClientTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ClientTypeComboBox_SelectedIndexChanged);
            // 
            // UrPanel
            // 
            this.UrPanel.Controls.Add(this.CancelButton);
            this.UrPanel.Controls.Add(this.AddCompanyButton);
            this.UrPanel.Controls.Add(this.CompanyEmailLabel);
            this.UrPanel.Controls.Add(this.CompanyEmailText);
            this.UrPanel.Controls.Add(this.CompanyContactNameLabel);
            this.UrPanel.Controls.Add(this.CompanyContactNameText);
            this.UrPanel.Controls.Add(this.CompanyManagerNameLabel);
            this.UrPanel.Controls.Add(this.CompanyManagerNameText);
            this.UrPanel.Controls.Add(this.CompanyBIKLabel);
            this.UrPanel.Controls.Add(this.CompanyBIKText);
            this.UrPanel.Controls.Add(this.CompanyRSLabel);
            this.UrPanel.Controls.Add(this.CompanyRSText);
            this.UrPanel.Controls.Add(this.CompanyAdressLabel);
            this.UrPanel.Controls.Add(this.CompanyAdressText);
            this.UrPanel.Controls.Add(this.CompanyINNLabel);
            this.UrPanel.Controls.Add(this.CompanyINNText);
            this.UrPanel.Controls.Add(this.CompanyNameLabel);
            this.UrPanel.Controls.Add(this.CompanyNameText);
            this.UrPanel.Location = new System.Drawing.Point(67, 65);
            this.UrPanel.Name = "UrPanel";
            this.UrPanel.Size = new System.Drawing.Size(424, 374);
            this.UrPanel.TabIndex = 8;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(231, 334);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 19;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AddCompanyButton
            // 
            this.AddCompanyButton.Location = new System.Drawing.Point(330, 334);
            this.AddCompanyButton.Name = "AddCompanyButton";
            this.AddCompanyButton.Size = new System.Drawing.Size(75, 23);
            this.AddCompanyButton.TabIndex = 18;
            this.AddCompanyButton.Text = "Сохранить";
            this.AddCompanyButton.UseVisualStyleBackColor = true;
            // 
            // CompanyEmailLabel
            // 
            this.CompanyEmailLabel.AutoSize = true;
            this.CompanyEmailLabel.Location = new System.Drawing.Point(3, 290);
            this.CompanyEmailLabel.Name = "CompanyEmailLabel";
            this.CompanyEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.CompanyEmailLabel.TabIndex = 17;
            this.CompanyEmailLabel.Text = "Email";
            // 
            // CompanyEmailText
            // 
            this.CompanyEmailText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyEmailText.Location = new System.Drawing.Point(136, 288);
            this.CompanyEmailText.Name = "CompanyEmailText";
            this.CompanyEmailText.Size = new System.Drawing.Size(269, 20);
            this.CompanyEmailText.TabIndex = 16;
            // 
            // CompanyContactNameLabel
            // 
            this.CompanyContactNameLabel.AutoSize = true;
            this.CompanyContactNameLabel.Location = new System.Drawing.Point(3, 251);
            this.CompanyContactNameLabel.Name = "CompanyContactNameLabel";
            this.CompanyContactNameLabel.Size = new System.Drawing.Size(127, 13);
            this.CompanyContactNameLabel.TabIndex = 15;
            this.CompanyContactNameLabel.Text = "ФИО контактного лица";
            // 
            // CompanyContactNameText
            // 
            this.CompanyContactNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyContactNameText.Location = new System.Drawing.Point(136, 249);
            this.CompanyContactNameText.Name = "CompanyContactNameText";
            this.CompanyContactNameText.Size = new System.Drawing.Size(269, 20);
            this.CompanyContactNameText.TabIndex = 14;
            // 
            // CompanyManagerNameLabel
            // 
            this.CompanyManagerNameLabel.AutoSize = true;
            this.CompanyManagerNameLabel.Location = new System.Drawing.Point(3, 214);
            this.CompanyManagerNameLabel.Name = "CompanyManagerNameLabel";
            this.CompanyManagerNameLabel.Size = new System.Drawing.Size(107, 13);
            this.CompanyManagerNameLabel.TabIndex = 13;
            this.CompanyManagerNameLabel.Text = "ФИО руководителя";
            // 
            // CompanyManagerNameText
            // 
            this.CompanyManagerNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyManagerNameText.Location = new System.Drawing.Point(136, 212);
            this.CompanyManagerNameText.Name = "CompanyManagerNameText";
            this.CompanyManagerNameText.Size = new System.Drawing.Size(269, 20);
            this.CompanyManagerNameText.TabIndex = 12;
            // 
            // CompanyBIKLabel
            // 
            this.CompanyBIKLabel.AutoSize = true;
            this.CompanyBIKLabel.Location = new System.Drawing.Point(3, 173);
            this.CompanyBIKLabel.Name = "CompanyBIKLabel";
            this.CompanyBIKLabel.Size = new System.Drawing.Size(29, 13);
            this.CompanyBIKLabel.TabIndex = 11;
            this.CompanyBIKLabel.Text = "БИК";
            // 
            // CompanyBIKText
            // 
            this.CompanyBIKText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyBIKText.Location = new System.Drawing.Point(136, 171);
            this.CompanyBIKText.Name = "CompanyBIKText";
            this.CompanyBIKText.Size = new System.Drawing.Size(269, 20);
            this.CompanyBIKText.TabIndex = 10;
            // 
            // CompanyRSLabel
            // 
            this.CompanyRSLabel.AutoSize = true;
            this.CompanyRSLabel.Location = new System.Drawing.Point(3, 138);
            this.CompanyRSLabel.Name = "CompanyRSLabel";
            this.CompanyRSLabel.Size = new System.Drawing.Size(87, 13);
            this.CompanyRSLabel.TabIndex = 9;
            this.CompanyRSLabel.Text = "Расчётный счёт";
            // 
            // CompanyRSText
            // 
            this.CompanyRSText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyRSText.Location = new System.Drawing.Point(136, 136);
            this.CompanyRSText.Name = "CompanyRSText";
            this.CompanyRSText.Size = new System.Drawing.Size(269, 20);
            this.CompanyRSText.TabIndex = 8;
            // 
            // CompanyAdressLabel
            // 
            this.CompanyAdressLabel.AutoSize = true;
            this.CompanyAdressLabel.Location = new System.Drawing.Point(3, 99);
            this.CompanyAdressLabel.Name = "CompanyAdressLabel";
            this.CompanyAdressLabel.Size = new System.Drawing.Size(38, 13);
            this.CompanyAdressLabel.TabIndex = 7;
            this.CompanyAdressLabel.Text = "Адрес";
            // 
            // CompanyAdressText
            // 
            this.CompanyAdressText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyAdressText.Location = new System.Drawing.Point(136, 97);
            this.CompanyAdressText.Name = "CompanyAdressText";
            this.CompanyAdressText.Size = new System.Drawing.Size(269, 20);
            this.CompanyAdressText.TabIndex = 6;
            // 
            // CompanyINNLabel
            // 
            this.CompanyINNLabel.AutoSize = true;
            this.CompanyINNLabel.Location = new System.Drawing.Point(3, 62);
            this.CompanyINNLabel.Name = "CompanyINNLabel";
            this.CompanyINNLabel.Size = new System.Drawing.Size(31, 13);
            this.CompanyINNLabel.TabIndex = 5;
            this.CompanyINNLabel.Text = "ИНН";
            // 
            // CompanyINNText
            // 
            this.CompanyINNText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyINNText.Location = new System.Drawing.Point(136, 60);
            this.CompanyINNText.Name = "CompanyINNText";
            this.CompanyINNText.Size = new System.Drawing.Size(269, 20);
            this.CompanyINNText.TabIndex = 4;
            // 
            // FizPanel
            // 
            this.FizPanel.Controls.Add(this.ClientBirthDayPicker);
            this.FizPanel.Controls.Add(this.button1);
            this.FizPanel.Controls.Add(this.button2);
            this.FizPanel.Controls.Add(this.label4);
            this.FizPanel.Controls.Add(this.ClientPhoneText);
            this.FizPanel.Controls.Add(this.label5);
            this.FizPanel.Controls.Add(this.ClientPassportText);
            this.FizPanel.Controls.Add(this.label6);
            this.FizPanel.Controls.Add(this.label7);
            this.FizPanel.Controls.Add(this.ClientEmailText);
            this.FizPanel.Controls.Add(this.label8);
            this.FizPanel.Controls.Add(this.ClientNameText);
            this.FizPanel.Location = new System.Drawing.Point(67, 65);
            this.FizPanel.Name = "FizPanel";
            this.FizPanel.Size = new System.Drawing.Size(429, 374);
            this.FizPanel.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Телефон";
            // 
            // ClientPhoneText
            // 
            this.ClientPhoneText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientPhoneText.Location = new System.Drawing.Point(136, 171);
            this.ClientPhoneText.Name = "ClientPhoneText";
            this.ClientPhoneText.Size = new System.Drawing.Size(269, 20);
            this.ClientPhoneText.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Серия и номер паспорта";
            // 
            // ClientPassportText
            // 
            this.ClientPassportText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientPassportText.Location = new System.Drawing.Point(136, 136);
            this.ClientPassportText.Name = "ClientPassportText";
            this.ClientPassportText.Size = new System.Drawing.Size(269, 20);
            this.ClientPassportText.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Дата рождения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Email";
            // 
            // ClientEmailText
            // 
            this.ClientEmailText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientEmailText.Location = new System.Drawing.Point(136, 60);
            this.ClientEmailText.Name = "ClientEmailText";
            this.ClientEmailText.Size = new System.Drawing.Size(269, 20);
            this.ClientEmailText.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "ФИО";
            // 
            // ClientNameText
            // 
            this.ClientNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientNameText.Location = new System.Drawing.Point(136, 19);
            this.ClientNameText.Name = "ClientNameText";
            this.ClientNameText.Size = new System.Drawing.Size(269, 20);
            this.ClientNameText.TabIndex = 2;
            // 
            // ClientBirthDayPicker
            // 
            this.ClientBirthDayPicker.Location = new System.Drawing.Point(136, 97);
            this.ClientBirthDayPicker.Name = "ClientBirthDayPicker";
            this.ClientBirthDayPicker.Size = new System.Drawing.Size(269, 20);
            this.ClientBirthDayPicker.TabIndex = 20;
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 483);
            this.Controls.Add(this.FizPanel);
            this.Controls.Add(this.UrPanel);
            this.Controls.Add(this.ClientTypeComboBox);
            this.Controls.Add(this.ClientTypeLabel);
            this.Name = "AddClientForm";
            this.Text = "AddClientForm";
            this.Load += new System.EventHandler(this.AddClientForm_Load);
            this.UrPanel.ResumeLayout(false);
            this.UrPanel.PerformLayout();
            this.FizPanel.ResumeLayout(false);
            this.FizPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.TextBox CompanyNameText;
        private System.Windows.Forms.Label ClientTypeLabel;
        private System.Windows.Forms.ComboBox ClientTypeComboBox;
        private System.Windows.Forms.Panel UrPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddCompanyButton;
        private System.Windows.Forms.Label CompanyEmailLabel;
        private System.Windows.Forms.TextBox CompanyEmailText;
        private System.Windows.Forms.Label CompanyContactNameLabel;
        private System.Windows.Forms.TextBox CompanyContactNameText;
        private System.Windows.Forms.Label CompanyManagerNameLabel;
        private System.Windows.Forms.TextBox CompanyManagerNameText;
        private System.Windows.Forms.Label CompanyBIKLabel;
        private System.Windows.Forms.TextBox CompanyBIKText;
        private System.Windows.Forms.Label CompanyRSLabel;
        private System.Windows.Forms.TextBox CompanyRSText;
        private System.Windows.Forms.Label CompanyAdressLabel;
        private System.Windows.Forms.TextBox CompanyAdressText;
        private System.Windows.Forms.Label CompanyINNLabel;
        private System.Windows.Forms.TextBox CompanyINNText;
        private System.Windows.Forms.Panel FizPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClientPhoneText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ClientPassportText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ClientEmailText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ClientNameText;
        private System.Windows.Forms.DateTimePicker ClientBirthDayPicker;
    }
}