﻿namespace TestDb
{
    partial class CloseRent
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
            this.BadState = new System.Windows.Forms.CheckBox();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.ReturnCar = new System.Windows.Forms.Button();
            this.BadStatePenalty = new System.Windows.Forms.NumericUpDown();
            this.BadStatePenaltyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BadStatePenalty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата возврата:";
            // 
            // BadState
            // 
            this.BadState.AutoSize = true;
            this.BadState.Location = new System.Drawing.Point(101, 55);
            this.BadState.Name = "BadState";
            this.BadState.Size = new System.Drawing.Size(141, 17);
            this.BadState.TabIndex = 1;
            this.BadState.Text = "в ненадлежащем виде";
            this.BadState.UseVisualStyleBackColor = true;
            this.BadState.CheckedChanged += new System.EventHandler(this.BadState_CheckedChanged);
            // 
            // ReturnDate
            // 
            this.ReturnDate.Location = new System.Drawing.Point(101, 19);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(200, 20);
            this.ReturnDate.TabIndex = 2;
            // 
            // ReturnCar
            // 
            this.ReturnCar.Location = new System.Drawing.Point(101, 125);
            this.ReturnCar.Name = "ReturnCar";
            this.ReturnCar.Size = new System.Drawing.Size(75, 23);
            this.ReturnCar.TabIndex = 3;
            this.ReturnCar.Text = "Ок";
            this.ReturnCar.UseVisualStyleBackColor = true;
            this.ReturnCar.Click += new System.EventHandler(this.ReturnCar_Click);
            // 
            // BadStatePenalty
            // 
            this.BadStatePenalty.Location = new System.Drawing.Point(147, 78);
            this.BadStatePenalty.Name = "BadStatePenalty";
            this.BadStatePenalty.Size = new System.Drawing.Size(154, 20);
            this.BadStatePenalty.TabIndex = 4;
            this.BadStatePenalty.Visible = false;
            // 
            // BadStatePenaltyLabel
            // 
            this.BadStatePenaltyLabel.AutoSize = true;
            this.BadStatePenaltyLabel.Location = new System.Drawing.Point(98, 80);
            this.BadStatePenaltyLabel.Name = "BadStatePenaltyLabel";
            this.BadStatePenaltyLabel.Size = new System.Drawing.Size(43, 13);
            this.BadStatePenaltyLabel.TabIndex = 5;
            this.BadStatePenaltyLabel.Text = "штраф:";
            this.BadStatePenaltyLabel.Visible = false;
            // 
            // CloseRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 158);
            this.Controls.Add(this.BadStatePenaltyLabel);
            this.Controls.Add(this.BadStatePenalty);
            this.Controls.Add(this.ReturnCar);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.BadState);
            this.Controls.Add(this.label1);
            this.Name = "CloseRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Возврат автомобиля";
            ((System.ComponentModel.ISupportInitialize)(this.BadStatePenalty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox BadState;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.Button ReturnCar;
        private System.Windows.Forms.NumericUpDown BadStatePenalty;
        private System.Windows.Forms.Label BadStatePenaltyLabel;
    }
}