
namespace Arka
{
    partial class FrmEstadistico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Ch_Esta = new System.Windows.Forms.Panel();
            this.Ch_ET = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Ch_Esta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ch_ET)).BeginInit();
            this.SuspendLayout();
            // 
            // Ch_Esta
            // 
            this.Ch_Esta.Controls.Add(this.Ch_ET);
            this.Ch_Esta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ch_Esta.Location = new System.Drawing.Point(0, 0);
            this.Ch_Esta.Name = "Ch_Esta";
            this.Ch_Esta.Size = new System.Drawing.Size(914, 562);
            this.Ch_Esta.TabIndex = 0;
            // 
            // Ch_ET
            // 
            chartArea2.Name = "ChartArea1";
            this.Ch_ET.ChartAreas.Add(chartArea2);
            this.Ch_ET.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.Ch_ET.Legends.Add(legend2);
            this.Ch_ET.Location = new System.Drawing.Point(0, 0);
            this.Ch_ET.Name = "Ch_ET";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Ch_ET.Series.Add(series2);
            this.Ch_ET.Size = new System.Drawing.Size(914, 562);
            this.Ch_ET.TabIndex = 2;
            this.Ch_ET.Text = "chart1";
            // 
            // FrmEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.Ch_Esta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstadistico";
            this.Text = "FrmEstadistico";
            this.Load += new System.EventHandler(this.FrmEstadistico_Load);
            this.Ch_Esta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ch_ET)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Ch_Esta;
        private System.Windows.Forms.DataVisualization.Charting.Chart Ch_ET;
    }
}