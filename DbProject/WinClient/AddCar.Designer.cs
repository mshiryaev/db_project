namespace TestDb
{
    partial class AddCar
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
            this.CarCost = new System.Windows.Forms.NumericUpDown();
            this.CarBrand = new System.Windows.Forms.TextBox();
            this.CreateCar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CarDailyCost = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CarProperties = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.CarCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarDailyCost)).BeginInit();
            this.SuspendLayout();
            // 
            // CarCost
            // 
            this.CarCost.DecimalPlaces = 2;
            this.CarCost.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CarCost.Location = new System.Drawing.Point(129, 35);
            this.CarCost.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.CarCost.Name = "CarCost";
            this.CarCost.Size = new System.Drawing.Size(152, 20);
            this.CarCost.TabIndex = 23;
            // 
            // CarBrand
            // 
            this.CarBrand.Location = new System.Drawing.Point(129, 9);
            this.CarBrand.Name = "CarBrand";
            this.CarBrand.Size = new System.Drawing.Size(152, 20);
            this.CarBrand.TabIndex = 19;
            // 
            // CreateCar
            // 
            this.CreateCar.Location = new System.Drawing.Point(222, 191);
            this.CreateCar.Name = "CreateCar";
            this.CreateCar.Size = new System.Drawing.Size(113, 23);
            this.CreateCar.TabIndex = 18;
            this.CreateCar.Text = "Создать";
            this.CreateCar.UseVisualStyleBackColor = true;
            this.CreateCar.Click += new System.EventHandler(this.CreateCar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Стоимость:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Марка:";
            // 
            // CarDailyCost
            // 
            this.CarDailyCost.DecimalPlaces = 2;
            this.CarDailyCost.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CarDailyCost.Location = new System.Drawing.Point(129, 61);
            this.CarDailyCost.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.CarDailyCost.Name = "CarDailyCost";
            this.CarDailyCost.Size = new System.Drawing.Size(152, 20);
            this.CarDailyCost.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Дневная стоимость:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Свойства:";
            // 
            // CarProperties
            // 
            this.CarProperties.FormattingEnabled = true;
            this.CarProperties.Location = new System.Drawing.Point(129, 90);
            this.CarProperties.Name = "CarProperties";
            this.CarProperties.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.CarProperties.Size = new System.Drawing.Size(206, 95);
            this.CarProperties.TabIndex = 27;
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 226);
            this.Controls.Add(this.CarProperties);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CarDailyCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CarCost);
            this.Controls.Add(this.CarBrand);
            this.Controls.Add(this.CreateCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новый автомобиль";
            ((System.ComponentModel.ISupportInitialize)(this.CarCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarDailyCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown CarCost;
        private System.Windows.Forms.TextBox CarBrand;
        private System.Windows.Forms.Button CreateCar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown CarDailyCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox CarProperties;
    }
}