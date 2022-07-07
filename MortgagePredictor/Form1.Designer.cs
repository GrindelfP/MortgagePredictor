namespace MortgagePredictor
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainControls = new System.Windows.Forms.GroupBox();
            this.Run = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.FreeMoney = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NumberOfMonth = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DebetPercentage = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MortgagePercentage = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RentAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ApartmentPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.mainControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FreeMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebetPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MortgagePercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApartmentPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // mainControls
            // 
            this.mainControls.BackColor = System.Drawing.SystemColors.Info;
            this.mainControls.Controls.Add(this.Run);
            this.mainControls.Controls.Add(this.label11);
            this.mainControls.Controls.Add(this.FreeMoney);
            this.mainControls.Controls.Add(this.label12);
            this.mainControls.Controls.Add(this.label9);
            this.mainControls.Controls.Add(this.NumberOfMonth);
            this.mainControls.Controls.Add(this.label10);
            this.mainControls.Controls.Add(this.label5);
            this.mainControls.Controls.Add(this.DebetPercentage);
            this.mainControls.Controls.Add(this.label6);
            this.mainControls.Controls.Add(this.label7);
            this.mainControls.Controls.Add(this.MortgagePercentage);
            this.mainControls.Controls.Add(this.label8);
            this.mainControls.Controls.Add(this.label3);
            this.mainControls.Controls.Add(this.RentAmount);
            this.mainControls.Controls.Add(this.label4);
            this.mainControls.Controls.Add(this.label2);
            this.mainControls.Controls.Add(this.ApartmentPrice);
            this.mainControls.Controls.Add(this.label1);
            this.mainControls.Location = new System.Drawing.Point(759, 13);
            this.mainControls.Name = "mainControls";
            this.mainControls.Size = new System.Drawing.Size(200, 426);
            this.mainControls.TabIndex = 0;
            this.mainControls.TabStop = false;
            // 
            // Run
            // 
            this.Run.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Run.Location = new System.Drawing.Point(9, 359);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(182, 61);
            this.Run.TabIndex = 18;
            this.Run.Text = "Рассчитать!";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(135, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "руб";
            // 
            // FreeMoney
            // 
            this.FreeMoney.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.FreeMoney.Location = new System.Drawing.Point(9, 253);
            this.FreeMoney.Maximum = new decimal(new int[] {
            140000,
            0,
            0,
            0});
            this.FreeMoney.Minimum = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.FreeMoney.Name = "FreeMoney";
            this.FreeMoney.Size = new System.Drawing.Size(120, 20);
            this.FreeMoney.TabIndex = 16;
            this.FreeMoney.ThousandsSeparator = true;
            this.FreeMoney.Value = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 32);
            this.label12.TabIndex = 15;
            this.label12.Text = "Количество свободных\r\nденег\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(135, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "мес";
            // 
            // NumberOfMonth
            // 
            this.NumberOfMonth.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumberOfMonth.Location = new System.Drawing.Point(9, 317);
            this.NumberOfMonth.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.NumberOfMonth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NumberOfMonth.Name = "NumberOfMonth";
            this.NumberOfMonth.Size = new System.Drawing.Size(120, 20);
            this.NumberOfMonth.TabIndex = 13;
            this.NumberOfMonth.ThousandsSeparator = true;
            this.NumberOfMonth.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 32);
            this.label10.TabIndex = 12;
            this.label10.Text = "Продолжительность\r\nсимуляции";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "%";
            // 
            // DebetPercentage
            // 
            this.DebetPercentage.DecimalPlaces = 2;
            this.DebetPercentage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.DebetPercentage.Location = new System.Drawing.Point(7, 195);
            this.DebetPercentage.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.DebetPercentage.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.DebetPercentage.Name = "DebetPercentage";
            this.DebetPercentage.Size = new System.Drawing.Size(120, 20);
            this.DebetPercentage.TabIndex = 10;
            this.DebetPercentage.ThousandsSeparator = true;
            this.DebetPercentage.Value = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Процентная ставка \r\n(дебетовый вклад)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(135, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "%";
            // 
            // MortgagePercentage
            // 
            this.MortgagePercentage.DecimalPlaces = 2;
            this.MortgagePercentage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.MortgagePercentage.Location = new System.Drawing.Point(9, 137);
            this.MortgagePercentage.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.MortgagePercentage.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.MortgagePercentage.Name = "MortgagePercentage";
            this.MortgagePercentage.Size = new System.Drawing.Size(120, 20);
            this.MortgagePercentage.TabIndex = 7;
            this.MortgagePercentage.ThousandsSeparator = true;
            this.MortgagePercentage.Value = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 32);
            this.label8.TabIndex = 6;
            this.label8.Text = "Процентная ставка \r\n(ипотека)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 79);
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
            this.RentAmount.Location = new System.Drawing.Point(7, 79);
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
            this.label4.Location = new System.Drawing.Point(3, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Размер арендной платы";
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
            // ResultsChart
            // 
            chartArea3.Name = "ChartArea1";
            this.ResultsChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ResultsChart.Legends.Add(legend3);
            this.ResultsChart.Location = new System.Drawing.Point(13, 13);
            this.ResultsChart.Name = "ResultsChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ResultsChart.Series.Add(series3);
            this.ResultsChart.Size = new System.Drawing.Size(740, 419);
            this.ResultsChart.TabIndex = 1;
            this.ResultsChart.Text = "chart1";
            // 
            // textBox1
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBox.Location = new System.Drawing.Point(13, 439);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "textBox1";
            this.ResultTextBox.Size = new System.Drawing.Size(946, 188);
            this.ResultTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 639);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ResultsChart);
            this.Controls.Add(this.mainControls);
            this.Name = "Form1";
            this.Text = "Form";
            this.mainControls.ResumeLayout(false);
            this.mainControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FreeMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebetPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MortgagePercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApartmentPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.NumericUpDown MortgagePercentage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown DebetPercentage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NumberOfMonth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown FreeMoney;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataVisualization.Charting.Chart ResultsChart;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}

