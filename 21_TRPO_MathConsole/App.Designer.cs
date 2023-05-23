namespace _21_TRPO_MathConsole
{
    partial class App
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartNormal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartExp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewNormal = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridViewExp = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            buttonStart = new Button();
            labelResult = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartNormal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartExp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNormal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // chartNormal
            // 
            chartArea1.Name = "ChartArea1";
            chartNormal.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartNormal.Legends.Add(legend1);
            chartNormal.Location = new Point(12, 12);
            chartNormal.Name = "chartNormal";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartNormal.Series.Add(series1);
            chartNormal.Size = new Size(576, 426);
            chartNormal.TabIndex = 0;
            chartNormal.Text = "chart1";
            // 
            // chartExp
            // 
            chartArea2.Name = "ChartArea1";
            chartExp.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartExp.Legends.Add(legend2);
            chartExp.Location = new Point(12, 444);
            chartExp.Name = "chartExp";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartExp.Series.Add(series2);
            chartExp.Size = new Size(576, 426);
            chartExp.TabIndex = 1;
            chartExp.Text = "chart1";
            // 
            // dataGridViewNormal
            // 
            dataGridViewNormal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNormal.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridViewNormal.Location = new Point(594, 12);
            dataGridViewNormal.Name = "dataGridViewNormal";
            dataGridViewNormal.RowTemplate.Height = 25;
            dataGridViewNormal.Size = new Size(383, 426);
            dataGridViewNormal.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "Нормальный";
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // dataGridViewExp
            // 
            dataGridViewExp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExp.Columns.AddRange(new DataGridViewColumn[] { Column2 });
            dataGridViewExp.Location = new Point(594, 444);
            dataGridViewExp.Name = "dataGridViewExp";
            dataGridViewExp.RowTemplate.Height = 25;
            dataGridViewExp.Size = new Size(383, 426);
            dataGridViewExp.TabIndex = 3;
            // 
            // Column2
            // 
            Column2.HeaderText = "Экспоненциальный";
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(1522, 876);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(383, 76);
            buttonStart.TabIndex = 4;
            buttonStart.Text = "Старт";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(12, 873);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 15);
            labelResult.TabIndex = 5;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart1.Legends.Add(legend3);
            chart1.Location = new Point(983, 12);
            chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart1.Series.Add(series3);
            chart1.Size = new Size(922, 858);
            chart1.TabIndex = 6;
            chart1.Text = "chart1";
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1917, 964);
            Controls.Add(chart1);
            Controls.Add(labelResult);
            Controls.Add(buttonStart);
            Controls.Add(dataGridViewExp);
            Controls.Add(dataGridViewNormal);
            Controls.Add(chartExp);
            Controls.Add(chartNormal);
            Name = "App";
            Text = "App";
            ((System.ComponentModel.ISupportInitialize)chartNormal).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartExp).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNormal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExp).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartNormal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExp;
        private DataGridView dataGridViewNormal;
        private DataGridView dataGridViewExp;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button buttonStart;
        private Label labelResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}