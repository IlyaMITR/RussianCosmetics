namespace RussianCosmetics
{
    partial class Form1
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
            this.PagesControl = new System.Windows.Forms.TabControl();
            this.Orders = new System.Windows.Forms.TabPage();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usluga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.More = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Clients = new System.Windows.Forms.TabPage();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.ClientsTable = new System.Windows.Forms.DataGridView();
            this.Uslugi = new System.Windows.Forms.TabPage();
            this.AddUslugaButton = new System.Windows.Forms.Button();
            this.UslugiTable = new System.Windows.Forms.DataGridView();
            this.NameUsluga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceUsluga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoreInfo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PagesControl.SuspendLayout();
            this.Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Clients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsTable)).BeginInit();
            this.Uslugi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UslugiTable)).BeginInit();
            this.SuspendLayout();
            // 
            // PagesControl
            // 
            this.PagesControl.Controls.Add(this.Orders);
            this.PagesControl.Controls.Add(this.Clients);
            this.PagesControl.Controls.Add(this.Uslugi);
            this.PagesControl.Location = new System.Drawing.Point(12, 24);
            this.PagesControl.Name = "PagesControl";
            this.PagesControl.SelectedIndex = 0;
            this.PagesControl.Size = new System.Drawing.Size(652, 312);
            this.PagesControl.TabIndex = 0;
            // 
            // Orders
            // 
            this.Orders.Controls.Add(this.AddOrderButton);
            this.Orders.Controls.Add(this.dataGridView1);
            this.Orders.Location = new System.Drawing.Point(4, 22);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(3);
            this.Orders.Size = new System.Drawing.Size(644, 286);
            this.Orders.TabIndex = 0;
            this.Orders.Text = "Заказы";
            this.Orders.UseVisualStyleBackColor = true;
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(537, 229);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(75, 23);
            this.AddOrderButton.TabIndex = 1;
            this.AddOrderButton.Text = "Добавить";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Usluga,
            this.Client,
            this.Price,
            this.Date,
            this.More});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Usluga
            // 
            this.Usluga.HeaderText = "Услуга";
            this.Usluga.Name = "Usluga";
            this.Usluga.ReadOnly = true;
            // 
            // Client
            // 
            this.Client.HeaderText = "Клиент";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Стоимость";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // More
            // 
            this.More.HeaderText = "";
            this.More.Name = "More";
            this.More.ReadOnly = true;
            this.More.Text = "Подробнее";
            this.More.UseColumnTextForButtonValue = true;
            // 
            // Clients
            // 
            this.Clients.Controls.Add(this.AddClientButton);
            this.Clients.Controls.Add(this.ClientsTable);
            this.Clients.Location = new System.Drawing.Point(4, 22);
            this.Clients.Name = "Clients";
            this.Clients.Padding = new System.Windows.Forms.Padding(3);
            this.Clients.Size = new System.Drawing.Size(644, 286);
            this.Clients.TabIndex = 1;
            this.Clients.Text = "Клиенты";
            this.Clients.UseVisualStyleBackColor = true;
            // 
            // AddClientButton
            // 
            this.AddClientButton.Location = new System.Drawing.Point(541, 244);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(75, 23);
            this.AddClientButton.TabIndex = 1;
            this.AddClientButton.Text = "Добавить";
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // ClientsTable
            // 
            this.ClientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientName,
            this.Type,
            this.Email,
            this.Phone,
            this.MoreInfo});
            this.ClientsTable.Location = new System.Drawing.Point(0, 3);
            this.ClientsTable.Name = "ClientsTable";
            this.ClientsTable.Size = new System.Drawing.Size(644, 150);
            this.ClientsTable.TabIndex = 0;
            // 
            // Uslugi
            // 
            this.Uslugi.Controls.Add(this.AddUslugaButton);
            this.Uslugi.Controls.Add(this.UslugiTable);
            this.Uslugi.Location = new System.Drawing.Point(4, 22);
            this.Uslugi.Name = "Uslugi";
            this.Uslugi.Padding = new System.Windows.Forms.Padding(3);
            this.Uslugi.Size = new System.Drawing.Size(644, 286);
            this.Uslugi.TabIndex = 2;
            this.Uslugi.Text = "Услуги";
            this.Uslugi.UseVisualStyleBackColor = true;
            // 
            // AddUslugaButton
            // 
            this.AddUslugaButton.Location = new System.Drawing.Point(548, 218);
            this.AddUslugaButton.Name = "AddUslugaButton";
            this.AddUslugaButton.Size = new System.Drawing.Size(75, 23);
            this.AddUslugaButton.TabIndex = 2;
            this.AddUslugaButton.Text = "Добавить";
            this.AddUslugaButton.UseVisualStyleBackColor = true;
            this.AddUslugaButton.Click += new System.EventHandler(this.AddUslugaButton_Click);
            // 
            // UslugiTable
            // 
            this.UslugiTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UslugiTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameUsluga,
            this.PriceUsluga});
            this.UslugiTable.Location = new System.Drawing.Point(0, 0);
            this.UslugiTable.Name = "UslugiTable";
            this.UslugiTable.Size = new System.Drawing.Size(644, 173);
            this.UslugiTable.TabIndex = 0;
            // 
            // NameUsluga
            // 
            this.NameUsluga.HeaderText = "Название";
            this.NameUsluga.Name = "NameUsluga";
            this.NameUsluga.ReadOnly = true;
            // 
            // PriceUsluga
            // 
            this.PriceUsluga.HeaderText = "Стоимость";
            this.PriceUsluga.Name = "PriceUsluga";
            this.PriceUsluga.ReadOnly = true;
            // 
            // ClientName
            // 
            this.ClientName.HeaderText = "ФИО";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Телефон";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // MoreInfo
            // 
            this.MoreInfo.HeaderText = "";
            this.MoreInfo.Name = "MoreInfo";
            this.MoreInfo.ReadOnly = true;
            this.MoreInfo.Text = "Подробнее";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 351);
            this.Controls.Add(this.PagesControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PagesControl.ResumeLayout(false);
            this.Orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Clients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsTable)).EndInit();
            this.Uslugi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UslugiTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl PagesControl;
        private System.Windows.Forms.TabPage Orders;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage Clients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usluga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewButtonColumn More;
        private System.Windows.Forms.Button AddClientButton;
        private System.Windows.Forms.DataGridView ClientsTable;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.TabPage Uslugi;
        private System.Windows.Forms.Button AddUslugaButton;
        private System.Windows.Forms.DataGridView UslugiTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUsluga;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceUsluga;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewButtonColumn MoreInfo;
    }
}

