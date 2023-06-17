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
            this.FizPanel = new System.Windows.Forms.Panel();
            this.ClientBirthDayPicker = new System.Windows.Forms.DateTimePicker();
            this.ClientCancelButton = new System.Windows.Forms.Button();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.ClientPhoneLabel = new System.Windows.Forms.Label();
            this.ClientPhoneText = new System.Windows.Forms.TextBox();
            this.ClientPassportLabel = new System.Windows.Forms.Label();
            this.ClientPassportText = new System.Windows.Forms.TextBox();
            this.ClientBirthDayLabel = new System.Windows.Forms.Label();
            this.ClientEmailLabel = new System.Windows.Forms.Label();
            this.ClientEmailText = new System.Windows.Forms.TextBox();
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.ClientNameText = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddCompanyButton = new System.Windows.Forms.Button();
            this.CompanyEmailLabel = new System.Windows.Forms.Label();
            this.CompanyEmailText = new System.Windows.Forms.TextBox();
            this.CompanyContactNameLabel = new System.Windows.Forms.Label();
            this.CompanyContactPhoneText = new System.Windows.Forms.TextBox();
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
            this.CompanyNameText.Location = new System.Drawing.Point(151, 19);
            this.CompanyNameText.Name = "CompanyNameText";
            this.CompanyNameText.Size = new System.Drawing.Size(254, 20);
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
            this.UrPanel.Controls.Add(this.CompanyContactPhoneText);
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
            // FizPanel
            // 
            this.FizPanel.Controls.Add(this.ClientBirthDayPicker);
            this.FizPanel.Controls.Add(this.ClientCancelButton);
            this.FizPanel.Controls.Add(this.AddClientButton);
            this.FizPanel.Controls.Add(this.ClientPhoneLabel);
            this.FizPanel.Controls.Add(this.ClientPhoneText);
            this.FizPanel.Controls.Add(this.ClientPassportLabel);
            this.FizPanel.Controls.Add(this.ClientPassportText);
            this.FizPanel.Controls.Add(this.ClientBirthDayLabel);
            this.FizPanel.Controls.Add(this.ClientEmailLabel);
            this.FizPanel.Controls.Add(this.ClientEmailText);
            this.FizPanel.Controls.Add(this.ClientNameLabel);
            this.FizPanel.Controls.Add(this.ClientNameText);
            this.FizPanel.Location = new System.Drawing.Point(67, 84);
            this.FizPanel.Name = "FizPanel";
            this.FizPanel.Size = new System.Drawing.Size(429, 374);
            this.FizPanel.TabIndex = 9;
            // 
            // ClientBirthDayPicker
            // 
            this.ClientBirthDayPicker.Location = new System.Drawing.Point(136, 97);
            this.ClientBirthDayPicker.Name = "ClientBirthDayPicker";
            this.ClientBirthDayPicker.Size = new System.Drawing.Size(269, 20);
            this.ClientBirthDayPicker.TabIndex = 20;
            // 
            // ClientCancelButton
            // 
            this.ClientCancelButton.Location = new System.Drawing.Point(231, 334);
            this.ClientCancelButton.Name = "ClientCancelButton";
            this.ClientCancelButton.Size = new System.Drawing.Size(75, 23);
            this.ClientCancelButton.TabIndex = 19;
            this.ClientCancelButton.Text = "Отмена";
            this.ClientCancelButton.UseVisualStyleBackColor = true;
            this.ClientCancelButton.Click += new System.EventHandler(this.ClientCancelButton_Click);
            // 
            // AddClientButton
            // 
            this.AddClientButton.Location = new System.Drawing.Point(330, 334);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(75, 23);
            this.AddClientButton.TabIndex = 18;
            this.AddClientButton.Text = "Сохранить";
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // ClientPhoneLabel
            // 
            this.ClientPhoneLabel.AutoSize = true;
            this.ClientPhoneLabel.Location = new System.Drawing.Point(3, 173);
            this.ClientPhoneLabel.Name = "ClientPhoneLabel";
            this.ClientPhoneLabel.Size = new System.Drawing.Size(52, 13);
            this.ClientPhoneLabel.TabIndex = 11;
            this.ClientPhoneLabel.Text = "Телефон";
            // 
            // ClientPhoneText
            // 
            this.ClientPhoneText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientPhoneText.Location = new System.Drawing.Point(136, 171);
            this.ClientPhoneText.Name = "ClientPhoneText";
            this.ClientPhoneText.Size = new System.Drawing.Size(269, 20);
            this.ClientPhoneText.TabIndex = 10;
            // 
            // ClientPassportLabel
            // 
            this.ClientPassportLabel.AutoSize = true;
            this.ClientPassportLabel.Location = new System.Drawing.Point(3, 138);
            this.ClientPassportLabel.Name = "ClientPassportLabel";
            this.ClientPassportLabel.Size = new System.Drawing.Size(132, 13);
            this.ClientPassportLabel.TabIndex = 9;
            this.ClientPassportLabel.Text = "Серия и номер паспорта";
            // 
            // ClientPassportText
            // 
            this.ClientPassportText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientPassportText.Location = new System.Drawing.Point(136, 136);
            this.ClientPassportText.Name = "ClientPassportText";
            this.ClientPassportText.Size = new System.Drawing.Size(269, 20);
            this.ClientPassportText.TabIndex = 8;
            // 
            // ClientBirthDayLabel
            // 
            this.ClientBirthDayLabel.AutoSize = true;
            this.ClientBirthDayLabel.Location = new System.Drawing.Point(3, 99);
            this.ClientBirthDayLabel.Name = "ClientBirthDayLabel";
            this.ClientBirthDayLabel.Size = new System.Drawing.Size(86, 13);
            this.ClientBirthDayLabel.TabIndex = 7;
            this.ClientBirthDayLabel.Text = "Дата рождения";
            // 
            // ClientEmailLabel
            // 
            this.ClientEmailLabel.AutoSize = true;
            this.ClientEmailLabel.Location = new System.Drawing.Point(3, 62);
            this.ClientEmailLabel.Name = "ClientEmailLabel";
            this.ClientEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.ClientEmailLabel.TabIndex = 5;
            this.ClientEmailLabel.Text = "Email";
            // 
            // ClientEmailText
            // 
            this.ClientEmailText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientEmailText.Location = new System.Drawing.Point(136, 60);
            this.ClientEmailText.Name = "ClientEmailText";
            this.ClientEmailText.Size = new System.Drawing.Size(269, 20);
            this.ClientEmailText.TabIndex = 4;
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Location = new System.Drawing.Point(3, 21);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(34, 13);
            this.ClientNameLabel.TabIndex = 3;
            this.ClientNameLabel.Text = "ФИО";
            // 
            // ClientNameText
            // 
            this.ClientNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientNameText.Location = new System.Drawing.Point(136, 19);
            this.ClientNameText.Name = "ClientNameText";
            this.ClientNameText.Size = new System.Drawing.Size(269, 20);
            this.ClientNameText.TabIndex = 2;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(231, 334);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 19;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddCompanyButton
            // 
            this.AddCompanyButton.Location = new System.Drawing.Point(330, 334);
            this.AddCompanyButton.Name = "AddCompanyButton";
            this.AddCompanyButton.Size = new System.Drawing.Size(75, 23);
            this.AddCompanyButton.TabIndex = 18;
            this.AddCompanyButton.Text = "Сохранить";
            this.AddCompanyButton.UseVisualStyleBackColor = true;
            this.AddCompanyButton.Click += new System.EventHandler(this.AddCompanyButton_Click);
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
            this.CompanyEmailText.Location = new System.Drawing.Point(151, 288);
            this.CompanyEmailText.Name = "CompanyEmailText";
            this.CompanyEmailText.Size = new System.Drawing.Size(254, 20);
            this.CompanyEmailText.TabIndex = 16;
            // 
            // CompanyContactNameLabel
            // 
            this.CompanyContactNameLabel.AutoSize = true;
            this.CompanyContactNameLabel.Location = new System.Drawing.Point(3, 251);
            this.CompanyContactNameLabel.Name = "CompanyContactNameLabel";
            this.CompanyContactNameLabel.Size = new System.Drawing.Size(145, 13);
            this.CompanyContactNameLabel.TabIndex = 15;
            this.CompanyContactNameLabel.Text = "Телефон контактного лица";
            // 
            // CompanyContactPhoneText
            // 
            this.CompanyContactPhoneText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyContactPhoneText.Location = new System.Drawing.Point(151, 249);
            this.CompanyContactPhoneText.Name = "CompanyContactPhoneText";
            this.CompanyContactPhoneText.Size = new System.Drawing.Size(254, 20);
            this.CompanyContactPhoneText.TabIndex = 14;
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
            this.CompanyManagerNameText.Location = new System.Drawing.Point(151, 212);
            this.CompanyManagerNameText.Name = "CompanyManagerNameText";
            this.CompanyManagerNameText.Size = new System.Drawing.Size(254, 20);
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
            this.CompanyBIKText.Location = new System.Drawing.Point(151, 171);
            this.CompanyBIKText.Name = "CompanyBIKText";
            this.CompanyBIKText.Size = new System.Drawing.Size(254, 20);
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
            this.CompanyRSText.Location = new System.Drawing.Point(151, 136);
            this.CompanyRSText.Name = "CompanyRSText";
            this.CompanyRSText.Size = new System.Drawing.Size(254, 20);
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
            this.CompanyAdressText.Location = new System.Drawing.Point(151, 97);
            this.CompanyAdressText.Name = "CompanyAdressText";
            this.CompanyAdressText.Size = new System.Drawing.Size(254, 20);
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
            this.CompanyINNText.Location = new System.Drawing.Point(151, 60);
            this.CompanyINNText.Name = "CompanyINNText";
            this.CompanyINNText.Size = new System.Drawing.Size(254, 20);
            this.CompanyINNText.TabIndex = 4;
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
        private System.Windows.Forms.TextBox CompanyContactPhoneText;
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
        private System.Windows.Forms.Button ClientCancelButton;
        private System.Windows.Forms.Button AddClientButton;
        private System.Windows.Forms.Label ClientPhoneLabel;
        private System.Windows.Forms.TextBox ClientPhoneText;
        private System.Windows.Forms.Label ClientPassportLabel;
        private System.Windows.Forms.TextBox ClientPassportText;
        private System.Windows.Forms.Label ClientBirthDayLabel;
        private System.Windows.Forms.Label ClientEmailLabel;
        private System.Windows.Forms.TextBox ClientEmailText;
        private System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.TextBox ClientNameText;
        private System.Windows.Forms.DateTimePicker ClientBirthDayPicker;
    }
}