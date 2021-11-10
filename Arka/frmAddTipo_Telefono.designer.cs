
namespace Arka
{
    partial class frmAddTipo_Telefono
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvTiposTelefonos = new System.Windows.Forms.DataGridView();
            this.grbBuscar = new System.Windows.Forms.GroupBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.grbtiposTelefono = new System.Windows.Forms.GroupBox();
            this.txtAgregarTelefono = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposTelefonos)).BeginInit();
            this.grbBuscar.SuspendLayout();
            this.grbtiposTelefono.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvTiposTelefonos);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(12, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 160);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipos de Telefonos";
            // 
            // dgvTiposTelefonos
            // 
            this.dgvTiposTelefonos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTiposTelefonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTiposTelefonos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTiposTelefonos.Location = new System.Drawing.Point(7, 19);
            this.dgvTiposTelefonos.Name = "dgvTiposTelefonos";
            this.dgvTiposTelefonos.ReadOnly = true;
            this.dgvTiposTelefonos.Size = new System.Drawing.Size(438, 135);
            this.dgvTiposTelefonos.TabIndex = 0;
            // 
            // grbBuscar
            // 
            this.grbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbBuscar.Controls.Add(this.txtbuscar);
            this.grbBuscar.ForeColor = System.Drawing.Color.Black;
            this.grbBuscar.Location = new System.Drawing.Point(12, 118);
            this.grbBuscar.Name = "grbBuscar";
            this.grbBuscar.Size = new System.Drawing.Size(451, 76);
            this.grbBuscar.TabIndex = 4;
            this.grbBuscar.TabStop = false;
            this.grbBuscar.Text = "Buscar";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbuscar.Location = new System.Drawing.Point(7, 32);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(438, 20);
            this.txtbuscar.TabIndex = 0;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            this.txtbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscar_KeyPress);
            // 
            // grbtiposTelefono
            // 
            this.grbtiposTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbtiposTelefono.Controls.Add(this.txtAgregarTelefono);
            this.grbtiposTelefono.Controls.Add(this.btnAgregar);
            this.grbtiposTelefono.ForeColor = System.Drawing.Color.Black;
            this.grbtiposTelefono.Location = new System.Drawing.Point(12, 12);
            this.grbtiposTelefono.Name = "grbtiposTelefono";
            this.grbtiposTelefono.Size = new System.Drawing.Size(451, 100);
            this.grbtiposTelefono.TabIndex = 3;
            this.grbtiposTelefono.TabStop = false;
            this.grbtiposTelefono.Text = "Agregar Tipo Telefono";
            // 
            // txtAgregarTelefono
            // 
            this.txtAgregarTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAgregarTelefono.Location = new System.Drawing.Point(18, 40);
            this.txtAgregarTelefono.Name = "txtAgregarTelefono";
            this.txtAgregarTelefono.Size = new System.Drawing.Size(346, 20);
            this.txtAgregarTelefono.TabIndex = 1;
          
            this.txtAgregarTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgregarTelefono_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(370, 38);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmAddTipo_Telefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(472, 388);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grbBuscar);
            this.Controls.Add(this.grbtiposTelefono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddTipo_Telefono";
            this.Text = "fmrAddTipo_Telefono";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposTelefonos)).EndInit();
            this.grbBuscar.ResumeLayout(false);
            this.grbBuscar.PerformLayout();
            this.grbtiposTelefono.ResumeLayout(false);
            this.grbtiposTelefono.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvTiposTelefonos;
        private System.Windows.Forms.GroupBox grbBuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.GroupBox grbtiposTelefono;
        private System.Windows.Forms.TextBox txtAgregarTelefono;
        private System.Windows.Forms.Button btnAgregar;
    }
}