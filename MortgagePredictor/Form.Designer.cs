namespace MortgagePredictor
{
    partial class Form
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
            this.mainControls = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ApartmentPrice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RentAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mortgagePercentage = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.debetPercentage = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numberOfMonth = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.mainControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApartmentPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mortgagePercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debetPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // mainControls
            // 
            this.mainControls.BackColor = System.Drawing.SystemColors.Info;
            this.mainControls.Controls.Add(this.label9);
            this.mainControls.Controls.Add(this.numberOfMonth);
            this.mainControls.Controls.Add(this.label10);
            this.mainControls.Controls.Add(this.label5);
            this.mainControls.Controls.Add(this.debetPercentage);
            this.mainControls.Controls.Add(this.label6);
            this.mainControls.Controls.Add(this.label7);
            this.mainControls.Controls.Add(this.mortgagePercentage);
            this.mainControls.Controls.Add(this.label8);
            this.mainControls.Controls.Add(this.label3);
            this.mainControls.Controls.Add(this.RentAmount);
            this.mainControls.Controls.Add(this.label4);
            this.mainControls.Controls.Add(this.label2);
            this.mainControls.Controls.Add(this.ApartmentPrice);
            this.mainControls.Controls.Add(this.label1);
            this.mainControls.Location = new System.Drawing.Point(593, 12);
            this.mainControls.Name = "mainControls";
            this.mainControls.Size = new System.Drawing.Size(200, 426);
            this.mainControls.TabIndex = 0;
            this.mainControls.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Стоимость квартиры";
            // 
            // ApartmentPrice
            // 
            this.ApartmentPrice.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.ApartmentPrice.Location = new System.Drawing.Point(7, 36);
            this.ApartmentPrice.Maximum = new decimal(new int[] {
            20000000,
            0,
            0,
            0});
            this.ApartmentPrice.Minimum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.ApartmentPrice.Name = "ApartmentPrice";
            this.ApartmentPrice.Size = new System.Drawing.Size(120, 20);
            this.ApartmentPrice.TabIndex = 1;
            this.ApartmentPrice.ThousandsSeparator = true;
            this.ApartmentPrice.Value = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "руб";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "руб";
            // 
            // RentAmount
            // 
            this.RentAmount.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RentAmount.Location = new System.Drawing.Point(7, 120);
            this.RentAmount.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.RentAmount.Minimum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.RentAmount.Name = "RentAmount";
            this.RentAmount.Size = new System.Drawing.Size(120, 20);
            this.RentAmount.TabIndex = 4;
            this.RentAmount.ThousandsSeparator = true;
            this.RentAmount.Value = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Размер арендной платы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(135, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "%";
            // 
            // mortgagePercentage
            // 
            this.mortgagePercentage.DecimalPlaces = 2;
            this.mortgagePercentage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.mortgagePercentage.Location = new System.Drawing.Point(9, 206);
            this.mortgagePercentage.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.mortgagePercentage.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.mortgagePercentage.Name = "mortgagePercentage";
            this.mortgagePercentage.Size = new System.Drawing.Size(120, 20);
            this.mortgagePercentage.TabIndex = 7;
            this.mortgagePercentage.ThousandsSeparator = true;
            this.mortgagePercentage.Value = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 32);
            this.label8.TabIndex = 6;
            this.label8.Text = "Процентная ставка \r\n(ипотека)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "%";
            // 
            // debetPercentage
            // 
            this.debetPercentage.DecimalPlaces = 2;
            this.debetPercentage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.debetPercentage.Location = new System.Drawing.Point(9, 299);
            this.debetPercentage.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.debetPercentage.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.debetPercentage.Name = "debetPercentage";
            this.debetPercentage.Size = new System.Drawing.Size(120, 20);
            this.debetPercentage.TabIndex = 10;
            this.debetPercentage.ThousandsSeparator = true;
            this.debetPercentage.Value = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Процентная ставка \r\n(дебетовый вклад)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(138, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "мес";
            // 
            // numberOfMonth
            // 
            this.numberOfMonth.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numberOfMonth.Location = new System.Drawing.Point(12, 387);
            this.numberOfMonth.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numberOfMonth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numberOfMonth.Name = "numberOfMonth";
            this.numberOfMonth.Size = new System.Drawing.Size(120, 20);
            this.numberOfMonth.TabIndex = 13;
            this.numberOfMonth.ThousandsSeparator = true;
            this.numberOfMonth.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 32);
            this.label10.TabIndex = 12;
            this.label10.Text = "Продолжительность\r\nсимуляции";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainControls);
            this.Name = "Form";
            this.Text = "Form1";
            this.mainControls.ResumeLayout(false);
            this.mainControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApartmentPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mortgagePercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debetPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfMonth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainControls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ApartmentPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown RentAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown mortgagePercentage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown debetPercentage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numberOfMonth;
        private System.Windows.Forms.Label label10;
    }
}

