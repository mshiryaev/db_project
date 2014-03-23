namespace TestDb
{
    partial class AddProperty
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
            this.PropertyDescription = new System.Windows.Forms.TextBox();
            this.CreateProperty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Описание:";
            // 
            // PropertyDescription
            // 
            this.PropertyDescription.Location = new System.Drawing.Point(80, 13);
            this.PropertyDescription.Multiline = true;
            this.PropertyDescription.Name = "PropertyDescription";
            this.PropertyDescription.Size = new System.Drawing.Size(270, 90);
            this.PropertyDescription.TabIndex = 1;
            // 
            // CreateProperty
            // 
            this.CreateProperty.Location = new System.Drawing.Point(275, 109);
            this.CreateProperty.Name = "CreateProperty";
            this.CreateProperty.Size = new System.Drawing.Size(75, 23);
            this.CreateProperty.TabIndex = 2;
            this.CreateProperty.Text = "Создать";
            this.CreateProperty.UseVisualStyleBackColor = true;
            this.CreateProperty.Click += new System.EventHandler(this.CreateProperty_Click);
            // 
            // AddProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 144);
            this.Controls.Add(this.CreateProperty);
            this.Controls.Add(this.PropertyDescription);
            this.Controls.Add(this.label1);
            this.Name = "AddProperty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новое свойство автомобиля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PropertyDescription;
        private System.Windows.Forms.Button CreateProperty;
    }
}