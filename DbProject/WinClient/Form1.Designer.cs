namespace TestDb
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tabs = new System.Windows.Forms.TabControl();
            this.CarPage = new System.Windows.Forms.TabPage();
            this.PropertyPage = new System.Windows.Forms.TabPage();
            this.CarTable = new System.Windows.Forms.DataGridView();
            this.AddCar = new System.Windows.Forms.Button();
            this.PropertyTable = new System.Windows.Forms.DataGridView();
            this.AddProperty = new System.Windows.Forms.Button();
            this.Clients = new System.Windows.Forms.TabPage();
            this.ClientTable = new System.Windows.Forms.DataGridView();
            this.CarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Properties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassportData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddClient = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AllCars = new System.Windows.Forms.RadioButton();
            this.CarsInRent = new System.Windows.Forms.RadioButton();
            this.CarsNotInRent = new System.Windows.Forms.RadioButton();
            this.PopularCars = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ProfitableClient = new System.Windows.Forms.RadioButton();
            this.Rents = new System.Windows.Forms.TabPage();
            this.RentTable = new System.Windows.Forms.DataGridView();
            this.NewClientRequest = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentStop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddRent = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.CloseRent = new System.Windows.Forms.Button();
            this.ServiceFunctions = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CalculateProfit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CalculateReturnClients = new System.Windows.Forms.Button();
            this.CalculateWarnedClients = new System.Windows.Forms.Button();
            this.ProfitLabel = new System.Windows.Forms.Label();
            this.ReturnedClientLabel = new System.Windows.Forms.Label();
            this.WarnedClientLabel = new System.Windows.Forms.Label();
            this.Tabs.SuspendLayout();
            this.CarPage.SuspendLayout();
            this.PropertyPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PropertyTable)).BeginInit();
            this.Clients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Rents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentTable)).BeginInit();
            this.NewClientRequest.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.ServiceFunctions.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.CarPage);
            this.Tabs.Controls.Add(this.PropertyPage);
            this.Tabs.Controls.Add(this.Clients);
            this.Tabs.Controls.Add(this.Rents);
            this.Tabs.Controls.Add(this.NewClientRequest);
            this.Tabs.Controls.Add(this.ServiceFunctions);
            this.Tabs.Location = new System.Drawing.Point(12, 12);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(955, 328);
            this.Tabs.TabIndex = 1;
            // 
            // CarPage
            // 
            this.CarPage.Controls.Add(this.groupBox1);
            this.CarPage.Controls.Add(this.AddCar);
            this.CarPage.Controls.Add(this.CarTable);
            this.CarPage.Location = new System.Drawing.Point(4, 22);
            this.CarPage.Name = "CarPage";
            this.CarPage.Padding = new System.Windows.Forms.Padding(3);
            this.CarPage.Size = new System.Drawing.Size(947, 302);
            this.CarPage.TabIndex = 0;
            this.CarPage.Text = "Автомобили";
            this.CarPage.UseVisualStyleBackColor = true;
            // 
            // PropertyPage
            // 
            this.PropertyPage.Controls.Add(this.AddProperty);
            this.PropertyPage.Controls.Add(this.PropertyTable);
            this.PropertyPage.Location = new System.Drawing.Point(4, 22);
            this.PropertyPage.Name = "PropertyPage";
            this.PropertyPage.Padding = new System.Windows.Forms.Padding(3);
            this.PropertyPage.Size = new System.Drawing.Size(947, 302);
            this.PropertyPage.TabIndex = 1;
            this.PropertyPage.Text = "Свойства автомобилей";
            this.PropertyPage.UseVisualStyleBackColor = true;
            // 
            // CarTable
            // 
            this.CarTable.AllowUserToOrderColumns = true;
            this.CarTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarId,
            this.Brand,
            this.Cost,
            this.DailyCost,
            this.Properties});
            this.CarTable.Location = new System.Drawing.Point(3, 3);
            this.CarTable.Name = "CarTable";
            this.CarTable.Size = new System.Drawing.Size(707, 290);
            this.CarTable.TabIndex = 1;
            // 
            // AddCar
            // 
            this.AddCar.Location = new System.Drawing.Point(716, 6);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(173, 29);
            this.AddCar.TabIndex = 2;
            this.AddCar.Text = "+ Добавить автомобиль";
            this.AddCar.UseVisualStyleBackColor = true;
            // 
            // PropertyTable
            // 
            this.PropertyTable.AllowUserToOrderColumns = true;
            this.PropertyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PropertyTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropertyId,
            this.PropertyDescription});
            this.PropertyTable.Location = new System.Drawing.Point(3, 3);
            this.PropertyTable.Name = "PropertyTable";
            this.PropertyTable.Size = new System.Drawing.Size(707, 290);
            this.PropertyTable.TabIndex = 2;
            // 
            // AddProperty
            // 
            this.AddProperty.Location = new System.Drawing.Point(716, 6);
            this.AddProperty.Name = "AddProperty";
            this.AddProperty.Size = new System.Drawing.Size(173, 29);
            this.AddProperty.TabIndex = 3;
            this.AddProperty.Text = "+ Добавить свойство";
            this.AddProperty.UseVisualStyleBackColor = true;
            // 
            // Clients
            // 
            this.Clients.Controls.Add(this.groupBox2);
            this.Clients.Controls.Add(this.AddClient);
            this.Clients.Controls.Add(this.ClientTable);
            this.Clients.Location = new System.Drawing.Point(4, 22);
            this.Clients.Name = "Clients";
            this.Clients.Padding = new System.Windows.Forms.Padding(3);
            this.Clients.Size = new System.Drawing.Size(947, 302);
            this.Clients.TabIndex = 2;
            this.Clients.Text = "Клиенты";
            this.Clients.UseVisualStyleBackColor = true;
            // 
            // ClientTable
            // 
            this.ClientTable.AllowUserToOrderColumns = true;
            this.ClientTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientId,
            this.FirstName,
            this.Lastname,
            this.MiddleName,
            this.PassportData,
            this.Telephone,
            this.Discount});
            this.ClientTable.Location = new System.Drawing.Point(3, 3);
            this.ClientTable.Name = "ClientTable";
            this.ClientTable.Size = new System.Drawing.Size(754, 290);
            this.ClientTable.TabIndex = 2;
            // 
            // CarId
            // 
            this.CarId.HeaderText = "Идентификатор";
            this.CarId.Name = "CarId";
            this.CarId.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Марка";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Стоимость";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // DailyCost
            // 
            this.DailyCost.HeaderText = "Дневная стоимость";
            this.DailyCost.Name = "DailyCost";
            this.DailyCost.ReadOnly = true;
            // 
            // Properties
            // 
            this.Properties.HeaderText = "Свойства";
            this.Properties.Name = "Properties";
            this.Properties.ReadOnly = true;
            // 
            // PropertyId
            // 
            this.PropertyId.HeaderText = "Идентификатор";
            this.PropertyId.Name = "PropertyId";
            this.PropertyId.ReadOnly = true;
            // 
            // PropertyDescription
            // 
            this.PropertyDescription.HeaderText = "Описание";
            this.PropertyDescription.Name = "PropertyDescription";
            this.PropertyDescription.ReadOnly = true;
            // 
            // ClientId
            // 
            this.ClientId.HeaderText = "Идентификатор";
            this.ClientId.Name = "ClientId";
            this.ClientId.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // Lastname
            // 
            this.Lastname.HeaderText = "Фамилия";
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            // 
            // MiddleName
            // 
            this.MiddleName.HeaderText = "Отчество";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
            // 
            // PassportData
            // 
            this.PassportData.HeaderText = "Паспортные данные";
            this.PassportData.Name = "PassportData";
            this.PassportData.ReadOnly = true;
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Телефон";
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Скидка";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // AddClient
            // 
            this.AddClient.Location = new System.Drawing.Point(763, 6);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(173, 29);
            this.AddClient.TabIndex = 4;
            this.AddClient.Text = "+ Добавить клиента";
            this.AddClient.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PopularCars);
            this.groupBox1.Controls.Add(this.CarsNotInRent);
            this.groupBox1.Controls.Add(this.CarsInRent);
            this.groupBox1.Controls.Add(this.AllCars);
            this.groupBox1.Location = new System.Drawing.Point(716, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 133);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильры";
            // 
            // AllCars
            // 
            this.AllCars.AutoSize = true;
            this.AllCars.Checked = true;
            this.AllCars.Location = new System.Drawing.Point(7, 20);
            this.AllCars.Name = "AllCars";
            this.AllCars.Size = new System.Drawing.Size(107, 17);
            this.AllCars.TabIndex = 0;
            this.AllCars.TabStop = true;
            this.AllCars.Text = "все автомобили";
            this.AllCars.UseVisualStyleBackColor = true;
            // 
            // CarsInRent
            // 
            this.CarsInRent.AutoSize = true;
            this.CarsInRent.Location = new System.Drawing.Point(7, 44);
            this.CarsInRent.Name = "CarsInRent";
            this.CarsInRent.Size = new System.Drawing.Size(139, 17);
            this.CarsInRent.TabIndex = 1;
            this.CarsInRent.Text = "автомобили в прокате";
            this.CarsInRent.UseVisualStyleBackColor = true;
            // 
            // CarsNotInRent
            // 
            this.CarsNotInRent.AutoSize = true;
            this.CarsNotInRent.Location = new System.Drawing.Point(7, 68);
            this.CarsNotInRent.Name = "CarsNotInRent";
            this.CarsNotInRent.Size = new System.Drawing.Size(154, 17);
            this.CarsNotInRent.TabIndex = 2;
            this.CarsNotInRent.Text = "автомобили не в прокате";
            this.CarsNotInRent.UseVisualStyleBackColor = true;
            // 
            // PopularCars
            // 
            this.PopularCars.AutoSize = true;
            this.PopularCars.Location = new System.Drawing.Point(7, 91);
            this.PopularCars.Name = "PopularCars";
            this.PopularCars.Size = new System.Drawing.Size(150, 17);
            this.PopularCars.TabIndex = 3;
            this.PopularCars.TabStop = true;
            this.PopularCars.Text = "популярные автомобили";
            this.PopularCars.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ProfitableClient);
            this.groupBox2.Location = new System.Drawing.Point(763, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 124);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильры";
            // 
            // ProfitableClient
            // 
            this.ProfitableClient.AutoSize = true;
            this.ProfitableClient.Checked = true;
            this.ProfitableClient.Location = new System.Drawing.Point(7, 20);
            this.ProfitableClient.Name = "ProfitableClient";
            this.ProfitableClient.Size = new System.Drawing.Size(120, 17);
            this.ProfitableClient.TabIndex = 0;
            this.ProfitableClient.TabStop = true;
            this.ProfitableClient.Text = "доходные клиенты";
            this.ProfitableClient.UseVisualStyleBackColor = true;
            // 
            // Rents
            // 
            this.Rents.Controls.Add(this.CloseRent);
            this.Rents.Controls.Add(this.RentTable);
            this.Rents.Location = new System.Drawing.Point(4, 22);
            this.Rents.Name = "Rents";
            this.Rents.Padding = new System.Windows.Forms.Padding(3);
            this.Rents.Size = new System.Drawing.Size(947, 302);
            this.Rents.TabIndex = 3;
            this.Rents.Text = "Сделки";
            this.Rents.UseVisualStyleBackColor = true;
            // 
            // RentTable
            // 
            this.RentTable.AllowUserToOrderColumns = true;
            this.RentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RentId,
            this.CarData,
            this.ClientData,
            this.RentStart,
            this.RentStop});
            this.RentTable.Location = new System.Drawing.Point(3, 3);
            this.RentTable.Name = "RentTable";
            this.RentTable.Size = new System.Drawing.Size(754, 290);
            this.RentTable.TabIndex = 3;
            // 
            // NewClientRequest
            // 
            this.NewClientRequest.Controls.Add(this.groupBox4);
            this.NewClientRequest.Controls.Add(this.groupBox3);
            this.NewClientRequest.Location = new System.Drawing.Point(4, 22);
            this.NewClientRequest.Name = "NewClientRequest";
            this.NewClientRequest.Padding = new System.Windows.Forms.Padding(3);
            this.NewClientRequest.Size = new System.Drawing.Size(947, 302);
            this.NewClientRequest.TabIndex = 4;
            this.NewClientRequest.Text = "Новое обращение клиента";
            this.NewClientRequest.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 256);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Свойства автомобиля:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Клиент:";
            // 
            // RentId
            // 
            this.RentId.HeaderText = "Идентификатор";
            this.RentId.Name = "RentId";
            this.RentId.ReadOnly = true;
            // 
            // CarData
            // 
            this.CarData.HeaderText = "Автомобиль";
            this.CarData.Name = "CarData";
            this.CarData.ReadOnly = true;
            // 
            // ClientData
            // 
            this.ClientData.HeaderText = "Клиент";
            this.ClientData.Name = "ClientData";
            this.ClientData.ReadOnly = true;
            // 
            // RentStart
            // 
            this.RentStart.HeaderText = "Дата начала";
            this.RentStart.Name = "RentStart";
            this.RentStart.ReadOnly = true;
            // 
            // RentStop
            // 
            this.RentStop.HeaderText = "Дата окончания";
            this.RentStop.Name = "RentStop";
            this.RentStop.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата начала проката:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата окончания проката:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Марка автомобиля:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Предельная сумма проката (в день):";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.AddRent);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(404, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(537, 255);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Подходящие автомобили:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Код запроса клиента:";
            // 
            // AddRent
            // 
            this.AddRent.Location = new System.Drawing.Point(40, 93);
            this.AddRent.Name = "AddRent";
            this.AddRent.Size = new System.Drawing.Size(115, 23);
            this.AddRent.TabIndex = 6;
            this.AddRent.Text = "Оформить сделку";
            this.AddRent.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Предполагаемая стоимость:";
            // 
            // CloseRent
            // 
            this.CloseRent.Location = new System.Drawing.Point(764, 7);
            this.CloseRent.Name = "CloseRent";
            this.CloseRent.Size = new System.Drawing.Size(133, 23);
            this.CloseRent.TabIndex = 4;
            this.CloseRent.Text = "Зыкрыть сделку";
            this.CloseRent.UseVisualStyleBackColor = true;
            // 
            // ServiceFunctions
            // 
            this.ServiceFunctions.Controls.Add(this.groupBox5);
            this.ServiceFunctions.Location = new System.Drawing.Point(4, 22);
            this.ServiceFunctions.Name = "ServiceFunctions";
            this.ServiceFunctions.Size = new System.Drawing.Size(947, 302);
            this.ServiceFunctions.TabIndex = 5;
            this.ServiceFunctions.Text = "Дополнителное";
            this.ServiceFunctions.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(253, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Прибыль за все время:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.WarnedClientLabel);
            this.groupBox5.Controls.Add(this.ReturnedClientLabel);
            this.groupBox5.Controls.Add(this.ProfitLabel);
            this.groupBox5.Controls.Add(this.CalculateWarnedClients);
            this.groupBox5.Controls.Add(this.CalculateReturnClients);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.CalculateProfit);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(16, 17);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(520, 95);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // CalculateProfit
            // 
            this.CalculateProfit.Location = new System.Drawing.Point(425, 11);
            this.CalculateProfit.Name = "CalculateProfit";
            this.CalculateProfit.Size = new System.Drawing.Size(75, 23);
            this.CalculateProfit.TabIndex = 1;
            this.CalculateProfit.Text = "Рассчитать";
            this.CalculateProfit.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(374, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Количество клиентов только с одним штрафом и обратившихся заново:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(166, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(214, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Количество предупрежденных клиентов:";
            // 
            // CalculateReturnClients
            // 
            this.CalculateReturnClients.Location = new System.Drawing.Point(425, 38);
            this.CalculateReturnClients.Name = "CalculateReturnClients";
            this.CalculateReturnClients.Size = new System.Drawing.Size(75, 23);
            this.CalculateReturnClients.TabIndex = 4;
            this.CalculateReturnClients.Text = "Рассчитать";
            this.CalculateReturnClients.UseVisualStyleBackColor = true;
            // 
            // CalculateWarnedClients
            // 
            this.CalculateWarnedClients.Location = new System.Drawing.Point(425, 64);
            this.CalculateWarnedClients.Name = "CalculateWarnedClients";
            this.CalculateWarnedClients.Size = new System.Drawing.Size(75, 23);
            this.CalculateWarnedClients.TabIndex = 5;
            this.CalculateWarnedClients.Text = "Рассчитать";
            this.CalculateWarnedClients.UseVisualStyleBackColor = true;
            // 
            // ProfitLabel
            // 
            this.ProfitLabel.AutoSize = true;
            this.ProfitLabel.Location = new System.Drawing.Point(387, 21);
            this.ProfitLabel.Name = "ProfitLabel";
            this.ProfitLabel.Size = new System.Drawing.Size(16, 13);
            this.ProfitLabel.TabIndex = 6;
            this.ProfitLabel.Text = "---";
            // 
            // ReturnedClientLabel
            // 
            this.ReturnedClientLabel.AutoSize = true;
            this.ReturnedClientLabel.Location = new System.Drawing.Point(387, 44);
            this.ReturnedClientLabel.Name = "ReturnedClientLabel";
            this.ReturnedClientLabel.Size = new System.Drawing.Size(16, 13);
            this.ReturnedClientLabel.TabIndex = 7;
            this.ReturnedClientLabel.Text = "---";
            // 
            // WarnedClientLabel
            // 
            this.WarnedClientLabel.AutoSize = true;
            this.WarnedClientLabel.Location = new System.Drawing.Point(387, 69);
            this.WarnedClientLabel.Name = "WarnedClientLabel";
            this.WarnedClientLabel.Size = new System.Drawing.Size(16, 13);
            this.WarnedClientLabel.TabIndex = 8;
            this.WarnedClientLabel.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 352);
            this.Controls.Add(this.Tabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tabs.ResumeLayout(false);
            this.CarPage.ResumeLayout(false);
            this.PropertyPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CarTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PropertyTable)).EndInit();
            this.Clients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Rents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RentTable)).EndInit();
            this.NewClientRequest.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ServiceFunctions.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage CarPage;
        private System.Windows.Forms.Button AddCar;
        private System.Windows.Forms.DataGridView CarTable;
        private System.Windows.Forms.TabPage PropertyPage;
        private System.Windows.Forms.DataGridView PropertyTable;
        private System.Windows.Forms.Button AddProperty;
        private System.Windows.Forms.TabPage Clients;
        private System.Windows.Forms.DataGridView ClientTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Properties;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyDescription;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassportData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton CarsNotInRent;
        private System.Windows.Forms.RadioButton CarsInRent;
        private System.Windows.Forms.RadioButton AllCars;
        private System.Windows.Forms.RadioButton PopularCars;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ProfitableClient;
        private System.Windows.Forms.TabPage Rents;
        private System.Windows.Forms.DataGridView RentTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientData;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentStop;
        private System.Windows.Forms.TabPage NewClientRequest;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseRent;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AddRent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage ServiceFunctions;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label WarnedClientLabel;
        private System.Windows.Forms.Label ReturnedClientLabel;
        private System.Windows.Forms.Label ProfitLabel;
        private System.Windows.Forms.Button CalculateWarnedClients;
        private System.Windows.Forms.Button CalculateReturnClients;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button CalculateProfit;
        private System.Windows.Forms.Label label10;

    }
}

