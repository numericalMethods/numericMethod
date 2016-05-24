namespace numericMethod
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelH = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.labelK = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.labelSP = new System.Windows.Forms.Label();
            this.numericUpDownSBust = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRMin = new System.Windows.Forms.NumericUpDown();
            this.labelTK = new System.Windows.Forms.Label();
            this.numericUpDownTK = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSBust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTK)).BeginInit();
            this.SuspendLayout();
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(113, 17);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(45, 13);
            this.labelH.TabIndex = 0;
            this.labelH.Text = "< Шаг <";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(71, 56);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(139, 13);
            this.labelN.TabIndex = 2;
            this.labelN.Text = "< Коэффициент трения <  ";
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Location = new System.Drawing.Point(83, 95);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(109, 13);
            this.labelM.TabIndex = 4;
            this.labelM.Text = "< Масса объекта <  ";
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Location = new System.Drawing.Point(71, 139);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(130, 13);
            this.labelK.TabIndex = 6;
            this.labelK.Text = "< Жесткость пружины <";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(27, 244);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(466, 246);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelSP
            // 
            this.labelSP.AutoSize = true;
            this.labelSP.Location = new System.Drawing.Point(351, 34);
            this.labelSP.Name = "labelSP";
            this.labelSP.Size = new System.Drawing.Size(78, 13);
            this.labelSP.TabIndex = 14;
            this.labelSP.Text = "Шаг перебора";
            // 
            // numericUpDownSBust
            // 
            this.numericUpDownSBust.Location = new System.Drawing.Point(354, 53);
            this.numericUpDownSBust.Name = "numericUpDownSBust";
            this.numericUpDownSBust.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownSBust.TabIndex = 15;
            this.numericUpDownSBust.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // numericUpDownSMax
            // 
            this.numericUpDownSMax.Location = new System.Drawing.Point(165, 14);
            this.numericUpDownSMax.Name = "numericUpDownSMax";
            this.numericUpDownSMax.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownSMax.TabIndex = 16;
            // 
            // numericUpDownSMin
            // 
            this.numericUpDownSMin.Location = new System.Drawing.Point(54, 14);
            this.numericUpDownSMin.Name = "numericUpDownSMin";
            this.numericUpDownSMin.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownSMin.TabIndex = 17;
            // 
            // numericUpDownTMax
            // 
            this.numericUpDownTMax.Location = new System.Drawing.Point(210, 53);
            this.numericUpDownTMax.Name = "numericUpDownTMax";
            this.numericUpDownTMax.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownTMax.TabIndex = 18;
            // 
            // numericUpDownTMin
            // 
            this.numericUpDownTMin.Location = new System.Drawing.Point(12, 54);
            this.numericUpDownTMin.Name = "numericUpDownTMin";
            this.numericUpDownTMin.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownTMin.TabIndex = 19;
            // 
            // numericUpDownMMax
            // 
            this.numericUpDownMMax.Location = new System.Drawing.Point(198, 93);
            this.numericUpDownMMax.Name = "numericUpDownMMax";
            this.numericUpDownMMax.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownMMax.TabIndex = 20;
            // 
            // numericUpDownMMin
            // 
            this.numericUpDownMMin.Location = new System.Drawing.Point(27, 93);
            this.numericUpDownMMin.Name = "numericUpDownMMin";
            this.numericUpDownMMin.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownMMin.TabIndex = 21;
            // 
            // numericUpDownRMax
            // 
            this.numericUpDownRMax.Location = new System.Drawing.Point(207, 136);
            this.numericUpDownRMax.Name = "numericUpDownRMax";
            this.numericUpDownRMax.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownRMax.TabIndex = 22;
            // 
            // numericUpDownRMin
            // 
            this.numericUpDownRMin.Location = new System.Drawing.Point(12, 137);
            this.numericUpDownRMin.Name = "numericUpDownRMin";
            this.numericUpDownRMin.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownRMin.TabIndex = 23;
            // 
            // labelTK
            // 
            this.labelTK.AutoSize = true;
            this.labelTK.Location = new System.Drawing.Point(322, 99);
            this.labelTK.Name = "labelTK";
            this.labelTK.Size = new System.Drawing.Size(127, 13);
            this.labelTK.TabIndex = 24;
            this.labelTK.Text = "Задача коши, введите х";
            // 
            // numericUpDownTK
            // 
            this.numericUpDownTK.Location = new System.Drawing.Point(354, 132);
            this.numericUpDownTK.Name = "numericUpDownTK";
            this.numericUpDownTK.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownTK.TabIndex = 25;
            this.numericUpDownTK.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 496);
            this.Controls.Add(this.numericUpDownTK);
            this.Controls.Add(this.labelTK);
            this.Controls.Add(this.numericUpDownRMin);
            this.Controls.Add(this.numericUpDownRMax);
            this.Controls.Add(this.numericUpDownMMin);
            this.Controls.Add(this.numericUpDownMMax);
            this.Controls.Add(this.numericUpDownTMin);
            this.Controls.Add(this.numericUpDownTMax);
            this.Controls.Add(this.numericUpDownSMin);
            this.Controls.Add(this.numericUpDownSMax);
            this.Controls.Add(this.numericUpDownSBust);
            this.Controls.Add(this.labelSP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelK);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelH);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSBust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelSP;
        private System.Windows.Forms.NumericUpDown numericUpDownSBust;
        private System.Windows.Forms.NumericUpDown numericUpDownSMax;
        private System.Windows.Forms.NumericUpDown numericUpDownSMin;
        private System.Windows.Forms.NumericUpDown numericUpDownTMax;
        private System.Windows.Forms.NumericUpDown numericUpDownTMin;
        private System.Windows.Forms.NumericUpDown numericUpDownMMax;
        private System.Windows.Forms.NumericUpDown numericUpDownMMin;
        private System.Windows.Forms.NumericUpDown numericUpDownRMax;
        private System.Windows.Forms.NumericUpDown numericUpDownRMin;
        private System.Windows.Forms.Label labelTK;
        private System.Windows.Forms.NumericUpDown numericUpDownTK;
    }
}

