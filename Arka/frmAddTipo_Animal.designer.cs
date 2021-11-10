
namespace Arka
{
    partial class frmAddTipo_Animal
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
            this.dgvTipoAnimal = new System.Windows.Forms.DataGridView();
            this.gbucarTipoAnimal = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.gbAgregarDepartamento = new System.Windows.Forms.GroupBox();
            this.txtAgregarAnimal = new System.Windows.Forms.TextBox();
            this.btnAgregarAnimal = new System.Windows.Forms.Button();
            this.gbAgregar_raza = new System.Windows.Forms.GroupBox();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Txt_Raza = new System.Windows.Forms.TextBox();
            this.cmbTipoanimal = new System.Windows.Forms.ComboBox();
            this.gbDepartamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoAnimal)).BeginInit();
            this.gbucarTipoAnimal.SuspendLayout();
            this.gbAgregarDepartamento.SuspendLayout();
            this.gbAgregar_raza.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDepartamentos
            // 
            this.gbDepartamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDepartamentos.Controls.Add(this.dgvTipoAnimal);
            this.gbDepartamentos.Location = new System.Drawing.Point(12, 211);
            this.gbDepartamentos.Name = "gbDepartamentos";
            this.gbDepartamentos.Size = new System.Drawing.Size(520, 215);
            this.gbDepartamentos.TabIndex = 8;
            this.gbDepartamentos.TabStop = false;
            this.gbDepartamentos.Text = "Departamentos";
            // 
            // dgvTipoAnimal
            // 
            this.dgvTipoAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTipoAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoAnimal.Location = new System.Drawing.Point(7, 20);
            this.dgvTipoAnimal.Name = "dgvTipoAnimal";
            this.dgvTipoAnimal.ReadOnly = true;
            this.dgvTipoAnimal.Size = new System.Drawing.Size(507, 175);
            this.dgvTipoAnimal.TabIndex = 0;
            // 
            // gbucarTipoAnimal
            // 
            this.gbucarTipoAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbucarTipoAnimal.Controls.Add(this.txtBuscar);
            this.gbucarTipoAnimal.Location = new System.Drawing.Point(12, 149);
            this.gbucarTipoAnimal.Name = "gbucarTipoAnimal";
            this.gbucarTipoAnimal.Size = new System.Drawing.Size(520, 56);
            this.gbucarTipoAnimal.TabIndex = 7;
            this.gbucarTipoAnimal.TabStop = false;
            this.gbucarTipoAnimal.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(6, 19);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(508, 20);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // gbAgregarDepartamento
            // 
            this.gbAgregarDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAgregarDepartamento.Controls.Add(this.txtAgregarAnimal);
            this.gbAgregarDepartamento.Controls.Add(this.btnAgregarAnimal);
            this.gbAgregarDepartamento.Location = new System.Drawing.Point(12, 12);
            this.gbAgregarDepartamento.Name = "gbAgregarDepartamento";
            this.gbAgregarDepartamento.Size = new System.Drawing.Size(520, 75);
            this.gbAgregarDepartamento.TabIndex = 6;
            this.gbAgregarDepartamento.TabStop = false;
            this.gbAgregarDepartamento.Text = "agregar Tipo Animal";
            // 
            // txtAgregarAnimal
            // 
            this.txtAgregarAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAgregarAnimal.Location = new System.Drawing.Point(6, 28);
            this.txtAgregarAnimal.Name = "txtAgregarAnimal";
            this.txtAgregarAnimal.Size = new System.Drawing.Size(427, 20);
            this.txtAgregarAnimal.TabIndex = 1;
            this.txtAgregarAnimal.TextChanged += new System.EventHandler(this.txtAgregarAnimal_TextChanged);
            this.txtAgregarAnimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgregarAnimal_KeyPress);
            // 
            // btnAgregarAnimal
            // 
            this.btnAgregarAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarAnimal.Location = new System.Drawing.Point(439, 25);
            this.btnAgregarAnimal.Name = "btnAgregarAnimal";
            this.btnAgregarAnimal.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarAnimal.TabIndex = 0;
            this.btnAgregarAnimal.Text = "Agregar";
            this.btnAgregarAnimal.UseVisualStyleBackColor = true;
            this.btnAgregarAnimal.Click += new System.EventHandler(this.btnAgregarAnimal_Click);
            // 
            // gbAgregar_raza
            // 
            this.gbAgregar_raza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAgregar_raza.Controls.Add(this.cmbTipoanimal);
            this.gbAgregar_raza.Controls.Add(this.Btn_Agregar);
            this.gbAgregar_raza.Controls.Add(this.Txt_Raza);
            this.gbAgregar_raza.Location = new System.Drawing.Point(12, 93);
            this.gbAgregar_raza.Name = "gbAgregar_raza";
            this.gbAgregar_raza.Size = new System.Drawing.Size(520, 56);
            this.gbAgregar_raza.TabIndex = 8;
            this.gbAgregar_raza.TabStop = false;
            this.gbAgregar_raza.Text = "agregar  raza";
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Agregar.Location = new System.Drawing.Point(439, 20);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Agregar.TabIndex = 2;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Txt_Raza
            // 
            this.Txt_Raza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Raza.Location = new System.Drawing.Point(188, 20);
            this.Txt_Raza.Name = "Txt_Raza";
            this.Txt_Raza.Size = new System.Drawing.Size(244, 20);
            this.Txt_Raza.TabIndex = 2;
            this.Txt_Raza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Raza_KeyPress);
            // 
            // cmbTipoanimal
            // 
            this.cmbTipoanimal.FormattingEnabled = true;
            this.cmbTipoanimal.Location = new System.Drawing.Point(7, 19);
            this.cmbTipoanimal.Name = "cmbTipoanimal";
            this.cmbTipoanimal.Size = new System.Drawing.Size(175, 21);
            this.cmbTipoanimal.TabIndex = 4;
            // 
            // frmAddTipo_Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(549, 448);
            this.Controls.Add(this.gbAgregar_raza);
            this.Controls.Add(this.gbDepartamentos);
            this.Controls.Add(this.gbucarTipoAnimal);
            this.Controls.Add(this.gbAgregarDepartamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddTipo_Animal";
            this.Text = "frmAddTipo_Animal";
            this.gbDepartamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoAnimal)).EndInit();
            this.gbucarTipoAnimal.ResumeLayout(false);
            this.gbucarTipoAnimal.PerformLayout();
            this.gbAgregarDepartamento.ResumeLayout(false);
            this.gbAgregarDepartamento.PerformLayout();
            this.gbAgregar_raza.ResumeLayout(false);
            this.gbAgregar_raza.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDepartamentos;
        private System.Windows.Forms.DataGridView dgvTipoAnimal;
        private System.Windows.Forms.GroupBox gbucarTipoAnimal;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox gbAgregarDepartamento;
        private System.Windows.Forms.TextBox txtAgregarAnimal;
        private System.Windows.Forms.Button btnAgregarAnimal;
        private System.Windows.Forms.GroupBox gbAgregar_raza;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.TextBox Txt_Raza;
        private System.Windows.Forms.ComboBox cmbTipoanimal;
    }
}