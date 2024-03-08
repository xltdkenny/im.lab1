namespace lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.zxcAstralStep = new System.Windows.Forms.NumericUpDown();
            this.step = new System.Windows.Forms.Label();
            this.zxcWeight = new System.Windows.Forms.NumericUpDown();
            this.zxcSize = new System.Windows.Forms.NumericUpDown();
            this.weight = new System.Windows.Forms.Label();
            this.Size = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_click = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.zxcSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.zxcHeight = new System.Windows.Forms.NumericUpDown();
            this.zxcAngle = new System.Windows.Forms.NumericUpDown();
            this.graphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.table = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zxcAstralStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zxcWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zxcSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zxcSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zxcHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zxcAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.zxcAstralStep);
            this.panel1.Controls.Add(this.step);
            this.panel1.Controls.Add(this.zxcWeight);
            this.panel1.Controls.Add(this.zxcSize);
            this.panel1.Controls.Add(this.weight);
            this.panel1.Controls.Add(this.Size);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_click);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.zxcSpeed);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.zxcHeight);
            this.panel1.Controls.Add(this.zxcAngle);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 303);
            this.panel1.TabIndex = 0;
            // 
            // zxcAstralStep
            // 
            this.zxcAstralStep.DecimalPlaces = 5;
            this.zxcAstralStep.Location = new System.Drawing.Point(83, 197);
            this.zxcAstralStep.Name = "zxcAstralStep";
            this.zxcAstralStep.Size = new System.Drawing.Size(120, 20);
            this.zxcAstralStep.TabIndex = 12;
            this.zxcAstralStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // step
            // 
            this.step.AutoSize = true;
            this.step.Location = new System.Drawing.Point(23, 204);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(27, 13);
            this.step.TabIndex = 11;
            this.step.Text = "Шаг";
            // 
            // zxcWeight
            // 
            this.zxcWeight.DecimalPlaces = 2;
            this.zxcWeight.Location = new System.Drawing.Point(83, 159);
            this.zxcWeight.Name = "zxcWeight";
            this.zxcWeight.Size = new System.Drawing.Size(120, 20);
            this.zxcWeight.TabIndex = 10;
            this.zxcWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // zxcSize
            // 
            this.zxcSize.DecimalPlaces = 2;
            this.zxcSize.Location = new System.Drawing.Point(83, 121);
            this.zxcSize.Name = "zxcSize";
            this.zxcSize.Size = new System.Drawing.Size(120, 20);
            this.zxcSize.TabIndex = 9;
            this.zxcSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(23, 166);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(40, 13);
            this.weight.TabIndex = 8;
            this.weight.Text = "Масса";
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.Location = new System.Drawing.Point(23, 128);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(46, 13);
            this.Size.TabIndex = 7;
            this.Size.Text = "Размер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Высота";
            // 
            // button_click
            // 
            this.button_click.Location = new System.Drawing.Point(55, 235);
            this.button_click.Name = "button_click";
            this.button_click.Size = new System.Drawing.Size(121, 34);
            this.button_click.TabIndex = 6;
            this.button_click.Text = "Запуск";
            this.button_click.UseVisualStyleBackColor = true;
            this.button_click.Click += new System.EventHandler(this.btStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Скорость";
            // 
            // zxcSpeed
            // 
            this.zxcSpeed.Location = new System.Drawing.Point(83, 7);
            this.zxcSpeed.Name = "zxcSpeed";
            this.zxcSpeed.Size = new System.Drawing.Size(120, 20);
            this.zxcSpeed.TabIndex = 5;
            this.zxcSpeed.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Угол";
            // 
            // zxcHeight
            // 
            this.zxcHeight.Location = new System.Drawing.Point(83, 79);
            this.zxcHeight.Name = "zxcHeight";
            this.zxcHeight.Size = new System.Drawing.Size(120, 20);
            this.zxcHeight.TabIndex = 3;
            // 
            // zxcAngle
            // 
            this.zxcAngle.Location = new System.Drawing.Point(83, 42);
            this.zxcAngle.Name = "zxcAngle";
            this.zxcAngle.Size = new System.Drawing.Size(120, 20);
            this.zxcAngle.TabIndex = 4;
            this.zxcAngle.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // graphic
            // 
            this.graphic.BackColor = System.Drawing.Color.Snow;
            chartArea1.AxisX.Maximum = 25D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 6D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.graphic.ChartAreas.Add(chartArea1);
            this.graphic.Location = new System.Drawing.Point(235, 5);
            this.graphic.Name = "graphic";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Name = "Series1";
            this.graphic.Series.Add(series1);
            this.graphic.Size = new System.Drawing.Size(555, 303);
            this.graphic.TabIndex = 1;
            this.graphic.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // table
            // 
            this.table.AllowDrop = true;
            this.table.AllowUserToOrderColumns = true;
            this.table.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data});
            this.table.Location = new System.Drawing.Point(12, 314);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(778, 132);
            this.table.TabIndex = 2;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 468);
            this.Controls.Add(this.table);
            this.Controls.Add(this.graphic);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zxcAstralStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zxcWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zxcSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zxcSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zxcHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zxcAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown zxcSpeed;
        private System.Windows.Forms.NumericUpDown zxcAngle;
        private System.Windows.Forms.NumericUpDown zxcHeight;
        private System.Windows.Forms.Button button_click;
        private System.Windows.Forms.DataVisualization.Charting.Chart graphic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Label Size;
        private System.Windows.Forms.NumericUpDown zxcWeight;
        private System.Windows.Forms.NumericUpDown zxcSize;
        private System.Windows.Forms.NumericUpDown zxcAstralStep;
        private System.Windows.Forms.Label step;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
    }
}

