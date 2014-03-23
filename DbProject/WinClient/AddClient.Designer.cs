namespace TestDb
{
    partial class AddClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CreateClient = new System.Windows.Forms.Button();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.ClientLastName = new System.Windows.Forms.TextBox();
            this.ClientMiddleName = new System.Windows.Forms.TextBox();
            this.ClientPassportData = new System.Windows.Forms.TextBox();
            this.ClientDiscount = new System.Windows.Forms.NumericUpDown();
            this.ClientTelephone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Паспортные данные:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Скидка:";
            // 
            // CreateClient
            // 
            this.CreateClient.Location = new System.Drawing.Point(284, 207);
            this.CreateClient.Name = "CreateClient";
            this.CreateClient.Size = new System.Drawing.Size(113, 23);
            this.CreateClient.TabIndex = 5;
            this.CreateClient.Text = "Создать";
            this.CreateClient.UseVisualStyleBackColor = true;
            this.CreateClient.Click += new System.EventHandler(this.CreateClient_Click);
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(130, 15);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(152, 20);
            this.ClientName.TabIndex = 6;
            // 
            // ClientLastName
            // 
            this.ClientLastName.Location = new System.Drawing.Point(130, 37);
            this.ClientLastName.Name = "ClientLastName";
            this.ClientLastName.Size = new System.Drawing.Size(152, 20);
            this.ClientLastName.TabIndex = 7;
            // 
            // ClientMiddleName
            // 
            this.ClientMiddleName.Location = new System.Drawing.Point(130, 59);
            this.ClientMiddleName.Name = "ClientMiddleName";
            this.ClientMiddleName.Size = new System.Drawing.Size(152, 20);
            this.ClientMiddleName.TabIndex = 8;
            // 
            // ClientPassportData
            // 
            this.ClientPassportData.Location = new System.Drawing.Point(130, 110);
            this.ClientPassportData.Multiline = true;
            this.ClientPassportData.Name = "ClientPassportData";
            this.ClientPassportData.Size = new System.Drawing.Size(267, 54);
            this.ClientPassportData.TabIndex = 9;
            // 
            // ClientDiscount
            // 
            this.ClientDiscount.DecimalPlaces = 1;
            this.ClientDiscount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.ClientDiscount.Location = new System.Drawing.Point(130, 170);
            this.ClientDiscount.Name = "ClientDiscount";
            this.ClientDiscount.Size = new System.Drawing.Size(66, 20);
            this.ClientDiscount.TabIndex = 10;
            // 
            // ClientTelephone
            // 
            this.ClientTelephone.Location = new System.Drawing.Point(130, 85);
            this.ClientTelephone.Name = "ClientTelephone";
            this.ClientTelephone.Size = new System.Drawing.Size(152, 20);
            this.ClientTelephone.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Телефон:";
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 242);
            this.Controls.Add(this.ClientTelephone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClientDiscount);
            this.Controls.Add(this.ClientPassportData);
            this.Controls.Add(this.ClientMiddleName);
            this.Controls.Add(this.ClientLastName);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.CreateClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новый клиент";
            ((System.ComponentModel.ISupportInitialize)(this.ClientDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CreateClient;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.TextBox ClientLastName;
        private System.Windows.Forms.TextBox ClientMiddleName;
        private System.Windows.Forms.TextBox ClientPassportData;
        private System.Windows.Forms.NumericUpDown ClientDiscount;
        private System.Windows.Forms.TextBox ClientTelephone;
        private System.Windows.Forms.Label label6;
    }
}