
namespace Arka
{
    partial class frmAddDepartamento
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
            this.gbDepartamentos = new System.Windows.Forms.GroupBox();
            this.dgvDepartamentos = new System.Windows.Forms.DataGridView();
            this.gbucarDepartamento = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.gbAgregarDepartamento = new System.Windows.Forms.GroupBox();
            this.txtAgregarDepartamento = new System.Windows.Forms.TextBox();
            this.btnAgregarDepartamento = new System.Windows.Forms.Button();
            this.gbDepartamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).BeginInit();
            this.gbucarDepartamento.SuspendLayout();
            this.gbAgregarDepartamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDepartamentos
            // 
            this.gbDepartamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDepartamentos.Controls.Add(this.dgvDepartamentos);
            this.gbDepartamentos.Location = new System.Drawing.Point(12, 164);
            this.gbDepartamentos.Name = "gbDepartamentos";
            this.gbDepartamentos.Size = new System.Drawing.Size(490, 140);
            this.gbDepartamentos.TabIndex = 5;
            this.gbDepartamentos.TabStop = false;
            this.gbDepartamentos.Text = "Departamentos";
            // 
            // dgvDepartamentos
            // 
            this.dgvDepartamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamentos.Location = new System.Drawing.Point(7, 20);
            this.dgvDepartamentos.Name = "dgvDepartamentos";
            this.dgvDepartamentos.ReadOnly = true;
            this.dgvDepartamentos.Size = new System.Drawing.Size(477, 100);
            this.dgvDepartamentos.TabIndex = 0;
            // 
            // gbucarDepartamento
            // 
            this.gbucarDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbucarDepartamento.Controls.Add(this.txtBuscar);
            this.gbucarDepartamento.Location = new System.Drawing.Point(12, 102);
            this.gbucarDepartamento.Name = "gbucarDepartamento";
            this.gbucarDepartamento.Size = new System.Drawing.Size(490, 55);
            this.gbucarDepartamento.TabIndex = 4;
            this.gbucarDepartamento.TabStop = false;
            this.gbucarDepartamento.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(6, 19);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(463, 20);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // gbAgregarDepartamento
            // 
            this.gbAgregarDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAgregarDepartamento.Controls.Add(this.txtAgregarDepartamento);
            this.gbAgregarDepartamento.Controls.Add(this.btnAgregarDepartamento);
            this.gbAgregarDepartamento.Location = new System.Drawing.Point(12, 12);
            this.gbAgregarDepartamento.Name = "gbAgregarDepartamento";
            this.gbAgregarDepartamento.Size = new System.Drawing.Size(490, 74);
            this.gbAgregarDepartamento.TabIndex = 3;
            this.gbAgregarDepartamento.TabStop = false;
            this.gbAgregarDepartamento.Text = "Agregar Departamento";
            // 
            // txtAgregarDepartamento
            // 
            this.txtAgregarDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAgregarDepartamento.Location = new System.Drawing.Point(6, 28);
            this.txtAgregarDepartamento.Name = "txtAgregarDepartamento";
            this.txtAgregarDepartamento.Size = new System.Drawing.Size(328, 20);
            this.txtAgregarDepartamento.TabIndex = 1;
            this.txtAgregarDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgregarDepartamento_KeyPress);
            // 
            // btnAgregarDepartamento
            // 
            this.btnAgregarDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarDepartamento.Location = new System.Drawing.Point(340, 28);
            this.btnAgregarDepartamento.Name = "btnAgregarDepartamento";
            this.btnAgregarDepartamento.Size = new System.Drawing.Size(144, 22);
            this.btnAgregarDepartamento.TabIndex = 0;
            this.btnAgregarDepartamento.Text = "Agregar";
            this.btnAgregarDepartamento.UseVisualStyleBackColor = true;
            this.btnAgregarDepartamento.Click += new System.EventHandler(this.btnAgregarDepartamento_Click);
            // 
            // frmAddDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(515, 337);
            this.Controls.Add(this.gbDepartamentos);
            this.Controls.Add(this.gbucarDepartamento);
            this.Controls.Add(this.gbAgregarDepartamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddDepartamento";
            this.Text = "frmAddDepartamento";
            this.gbDepartamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).EndInit();
            this.gbucarDepartamento.ResumeLayout(false);
            this.gbucarDepartamento.PerformLayout();
            this.gbAgregarDepartamento.ResumeLayout(false);
            this.gbAgregarDepartamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDepartamentos;
        private System.Windows.Forms.DataGridView dgvDepartamentos;
        private System.Windows.Forms.GroupBox gbucarDepartamento;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox gbAgregarDepartamento;
        private System.Windows.Forms.TextBox txtAgregarDepartamento;
        private System.Windows.Forms.Button btnAgregarDepartamento;
    }
}