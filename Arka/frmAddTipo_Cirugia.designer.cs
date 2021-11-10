
namespace Arka
{
    partial class frmAddTipo_Cirugia
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
            this.dgvTipoCiguia = new System.Windows.Forms.DataGridView();
            this.gbucarDepartamento = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.gbAgregarDepartamento = new System.Windows.Forms.GroupBox();
            this.txtAgregarCirugia = new System.Windows.Forms.TextBox();
            this.btnAgregarCirugia = new System.Windows.Forms.Button();
            this.gbDepartamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCiguia)).BeginInit();
            this.gbucarDepartamento.SuspendLayout();
            this.gbAgregarDepartamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDepartamentos
            // 
            this.gbDepartamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDepartamentos.Controls.Add(this.dgvTipoCiguia);
            this.gbDepartamentos.Location = new System.Drawing.Point(12, 164);
            this.gbDepartamentos.Name = "gbDepartamentos";
            this.gbDepartamentos.Size = new System.Drawing.Size(373, 141);
            this.gbDepartamentos.TabIndex = 11;
            this.gbDepartamentos.TabStop = false;
            this.gbDepartamentos.Text = "Departamentos";
            // 
            // dgvTipoCiguia
            // 
            this.dgvTipoCiguia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTipoCiguia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoCiguia.Location = new System.Drawing.Point(7, 20);
            this.dgvTipoCiguia.Name = "dgvTipoCiguia";
            this.dgvTipoCiguia.ReadOnly = true;
            this.dgvTipoCiguia.Size = new System.Drawing.Size(360, 101);
            this.dgvTipoCiguia.TabIndex = 0;
            // 
            // gbucarDepartamento
            // 
            this.gbucarDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbucarDepartamento.Controls.Add(this.txtBuscar);
            this.gbucarDepartamento.Location = new System.Drawing.Point(12, 102);
            this.gbucarDepartamento.Name = "gbucarDepartamento";
            this.gbucarDepartamento.Size = new System.Drawing.Size(373, 56);
            this.gbucarDepartamento.TabIndex = 10;
            this.gbucarDepartamento.TabStop = false;
            this.gbucarDepartamento.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(6, 19);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(361, 20);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // gbAgregarDepartamento
            // 
            this.gbAgregarDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAgregarDepartamento.Controls.Add(this.txtAgregarCirugia);
            this.gbAgregarDepartamento.Controls.Add(this.btnAgregarCirugia);
            this.gbAgregarDepartamento.Location = new System.Drawing.Point(12, 12);
            this.gbAgregarDepartamento.Name = "gbAgregarDepartamento";
            this.gbAgregarDepartamento.Size = new System.Drawing.Size(373, 75);
            this.gbAgregarDepartamento.TabIndex = 9;
            this.gbAgregarDepartamento.TabStop = false;
            this.gbAgregarDepartamento.Text = "agregar Tipo Cirugia";
            // 
            // txtAgregarCirugia
            // 
            this.txtAgregarCirugia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAgregarCirugia.Location = new System.Drawing.Point(6, 28);
            this.txtAgregarCirugia.Name = "txtAgregarCirugia";
            this.txtAgregarCirugia.Size = new System.Drawing.Size(280, 20);
            this.txtAgregarCirugia.TabIndex = 1;
            this.txtAgregarCirugia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgregarCirugia_KeyPress);
            // 
            // btnAgregarCirugia
            // 
            this.btnAgregarCirugia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCirugia.Location = new System.Drawing.Point(292, 25);
            this.btnAgregarCirugia.Name = "btnAgregarCirugia";
            this.btnAgregarCirugia.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCirugia.TabIndex = 0;
            this.btnAgregarCirugia.Text = "Agregar";
            this.btnAgregarCirugia.UseVisualStyleBackColor = true;
            this.btnAgregarCirugia.Click += new System.EventHandler(this.btnAgregarCirugia_Click);
            // 
            // frmAddTipo_Cirugia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(406, 326);
            this.Controls.Add(this.gbDepartamentos);
            this.Controls.Add(this.gbucarDepartamento);
            this.Controls.Add(this.gbAgregarDepartamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddTipo_Cirugia";
            this.Text = "frmAddTipo_Cirugia";
            this.gbDepartamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCiguia)).EndInit();
            this.gbucarDepartamento.ResumeLayout(false);
            this.gbucarDepartamento.PerformLayout();
            this.gbAgregarDepartamento.ResumeLayout(false);
            this.gbAgregarDepartamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDepartamentos;
        private System.Windows.Forms.DataGridView dgvTipoCiguia;
        private System.Windows.Forms.GroupBox gbucarDepartamento;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox gbAgregarDepartamento;
        private System.Windows.Forms.TextBox txtAgregarCirugia;
        private System.Windows.Forms.Button btnAgregarCirugia;
    }
}