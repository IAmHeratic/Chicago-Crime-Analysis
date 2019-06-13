namespace ChicagoCrime
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmdByYear = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.cmdArrested = new System.Windows.Forms.Button();
            this.cmdOneArea = new System.Windows.Forms.Button();
            this.cmdChicagoAreas = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdByYear
            // 
            this.cmdByYear.Location = new System.Drawing.Point(12, 30);
            this.cmdByYear.Name = "cmdByYear";
            this.cmdByYear.Size = new System.Drawing.Size(94, 61);
            this.cmdByYear.TabIndex = 0;
            this.cmdByYear.Text = "By Year";
            this.cmdByYear.UseVisualStyleBackColor = true;
            this.cmdByYear.Click += new System.EventHandler(this.cmdByYear_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilename.BackColor = System.Drawing.SystemColors.Control;
            this.txtFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilename.Location = new System.Drawing.Point(122, 477);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(769, 26);
            this.txtFilename.TabIndex = 2;
            this.txtFilename.Text = "CrimeDB.mdf";
            // 
            // cmdArrested
            // 
            this.cmdArrested.Location = new System.Drawing.Point(12, 134);
            this.cmdArrested.Name = "cmdArrested";
            this.cmdArrested.Size = new System.Drawing.Size(94, 61);
            this.cmdArrested.TabIndex = 3;
            this.cmdArrested.Text = "Arrested";
            this.cmdArrested.UseVisualStyleBackColor = true;
            this.cmdArrested.Click += new System.EventHandler(this.cmdArrested_Click);
            // 
            // cmdOneArea
            // 
            this.cmdOneArea.Location = new System.Drawing.Point(12, 236);
            this.cmdOneArea.Name = "cmdOneArea";
            this.cmdOneArea.Size = new System.Drawing.Size(94, 61);
            this.cmdOneArea.TabIndex = 6;
            this.cmdOneArea.Text = "One Area";
            this.cmdOneArea.UseVisualStyleBackColor = true;
            this.cmdOneArea.Click += new System.EventHandler(this.cmdOneArea_Click);
            // 
            // cmdChicagoAreas
            // 
            this.cmdChicagoAreas.Location = new System.Drawing.Point(12, 378);
            this.cmdChicagoAreas.Name = "cmdChicagoAreas";
            this.cmdChicagoAreas.Size = new System.Drawing.Size(94, 61);
            this.cmdChicagoAreas.TabIndex = 7;
            this.cmdChicagoAreas.Text = "Chicago Areas";
            this.cmdChicagoAreas.UseVisualStyleBackColor = true;
            this.cmdChicagoAreas.Click += new System.EventHandler(this.cmdChicagoAreas_Click);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(12, 304);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(95, 29);
            this.txtArea.TabIndex = 8;
            this.txtArea.Text = "Loop";
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(122, 12);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(769, 459);
            this.chart.TabIndex = 9;
            this.chart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 511);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.cmdChicagoAreas);
            this.Controls.Add(this.cmdOneArea);
            this.Controls.Add(this.cmdArrested);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.cmdByYear);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chicago Crime Analysis";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button cmdByYear;
    private System.Windows.Forms.TextBox txtFilename;
    private System.Windows.Forms.Button cmdArrested;
    private System.Windows.Forms.Button cmdOneArea;
    private System.Windows.Forms.Button cmdChicagoAreas;
    private System.Windows.Forms.TextBox txtArea;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart;
  }
}

