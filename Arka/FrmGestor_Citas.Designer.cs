
namespace Arka
{
    partial class FrmGestor_Citas
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
            this.Base = new System.Windows.Forms.Panel();
            this.Panel_Citas = new Guna.UI2.WinForms.Guna2Panel();
            this.Bnt_Editar_Mascota = new Guna.UI2.WinForms.Guna2Button();
            this.Pic_Patita = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Lbl_Id_Cita = new System.Windows.Forms.Label();
            this.Lbl_Id_Mascota = new System.Windows.Forms.Label();
            this.Btn_Agregar_Cita = new Guna.UI2.WinForms.Guna2Button();
            this.CMB_Tipo_Cita = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TxtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVTablaCita = new System.Windows.Forms.DataGridView();
            this.Btn_regresar = new Guna.UI2.WinForms.Guna2Button();
            this.Base.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Patita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTablaCita)).BeginInit();
            this.SuspendLayout();
            // 
            // Base
            // 
            this.Base.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.Base.Controls.Add(this.Bnt_Editar_Mascota);
            this.Base.Controls.Add(this.Pic_Patita);
            this.Base.Controls.Add(this.Lbl_Id_Cita);
            this.Base.Controls.Add(this.Lbl_Id_Mascota);
            this.Base.Controls.Add(this.Btn_Agregar_Cita);
            this.Base.Controls.Add(this.CMB_Tipo_Cita);
            this.Base.Controls.Add(this.TxtNombre);
            this.Base.Controls.Add(this.label1);
            this.Base.Controls.Add(this.label2);
            this.Base.Controls.Add(this.label3);
            this.Base.Controls.Add(this.DGVTablaCita);
            this.Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Base.Location = new System.Drawing.Point(0, 0);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(950, 557);
            this.Base.TabIndex = 1;
            // 
            // Panel_Citas
            // 
            this.Panel_Citas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Citas.Location = new System.Drawing.Point(0, 0);
            this.Panel_Citas.Name = "Panel_Citas";
            this.Panel_Citas.ShadowDecoration.Parent = this.Panel_Citas;
            this.Panel_Citas.Size = new System.Drawing.Size(950, 557);
            this.Panel_Citas.TabIndex = 24;
            this.Panel_Citas.Visible = false;
            // 
            // Bnt_Editar_Mascota
            // 
            this.Bnt_Editar_Mascota.BorderRadius = 20;
            this.Bnt_Editar_Mascota.CheckedState.Parent = this.Bnt_Editar_Mascota;
            this.Bnt_Editar_Mascota.CustomImages.Parent = this.Bnt_Editar_Mascota;
            this.Bnt_Editar_Mascota.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(151)))), ((int)(((byte)(142)))));
            this.Bnt_Editar_Mascota.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.Bnt_Editar_Mascota.ForeColor = System.Drawing.Color.White;
            this.Bnt_Editar_Mascota.HoverState.Parent = this.Bnt_Editar_Mascota;
            this.Bnt_Editar_Mascota.Location = new System.Drawing.Point(649, 500);
            this.Bnt_Editar_Mascota.Name = "Bnt_Editar_Mascota";
            this.Bnt_Editar_Mascota.ShadowDecoration.Parent = this.Bnt_Editar_Mascota;
            this.Bnt_Editar_Mascota.Size = new System.Drawing.Size(180, 45);
            this.Bnt_Editar_Mascota.TabIndex = 20;
            this.Bnt_Editar_Mascota.Text = "Eliminar Cita";
            this.Bnt_Editar_Mascota.Click += new System.EventHandler(this.Bnt_Editar_Mascota_Click);
            // 
            // Pic_Patita
            // 
            this.Pic_Patita.Image = global::Arka.Properties.Resources.paw_solid;
            this.Pic_Patita.Location = new System.Drawing.Point(41, 26);
            this.Pic_Patita.Name = "Pic_Patita";
            this.Pic_Patita.ShadowDecoration.Parent = this.Pic_Patita;
            this.Pic_Patita.Size = new System.Drawing.Size(145, 125);
            this.Pic_Patita.TabIndex = 21;
            this.Pic_Patita.TabStop = false;
            // 
            // Lbl_Id_Cita
            // 
            this.Lbl_Id_Cita.AutoSize = true;
            this.Lbl_Id_Cita.Location = new System.Drawing.Point(83, 107);
            this.Lbl_Id_Cita.Name = "Lbl_Id_Cita";
            this.Lbl_Id_Cita.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Id_Cita.TabIndex = 25;
            this.Lbl_Id_Cita.Text = "label4";
            // 
            // Lbl_Id_Mascota
            // 
            this.Lbl_Id_Mascota.AutoSize = true;
            this.Lbl_Id_Mascota.Location = new System.Drawing.Point(105, 107);
            this.Lbl_Id_Mascota.Name = "Lbl_Id_Mascota";
            this.Lbl_Id_Mascota.Size = new System.Drawing.Size(13, 13);
            this.Lbl_Id_Mascota.TabIndex = 23;
            this.Lbl_Id_Mascota.Text = "--";
            // 
            // Btn_Agregar_Cita
            // 
            this.Btn_Agregar_Cita.BorderRadius = 20;
            this.Btn_Agregar_Cita.CheckedState.Parent = this.Btn_Agregar_Cita;
            this.Btn_Agregar_Cita.CustomImages.Parent = this.Btn_Agregar_Cita;
            this.Btn_Agregar_Cita.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(151)))), ((int)(((byte)(142)))));
            this.Btn_Agregar_Cita.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Agregar_Cita.ForeColor = System.Drawing.Color.White;
            this.Btn_Agregar_Cita.HoverState.Parent = this.Btn_Agregar_Cita;
            this.Btn_Agregar_Cita.Location = new System.Drawing.Point(127, 500);
            this.Btn_Agregar_Cita.Name = "Btn_Agregar_Cita";
            this.Btn_Agregar_Cita.ShadowDecoration.Parent = this.Btn_Agregar_Cita;
            this.Btn_Agregar_Cita.Size = new System.Drawing.Size(180, 45);
            this.Btn_Agregar_Cita.TabIndex = 20;
            this.Btn_Agregar_Cita.Text = "Nueva Cita";
            this.Btn_Agregar_Cita.Click += new System.EventHandler(this.Btn_Agregar_Cita_Click);
            // 
            // CMB_Tipo_Cita
            // 
            this.CMB_Tipo_Cita.BackColor = System.Drawing.Color.Transparent;
            this.CMB_Tipo_Cita.BorderRadius = 10;
            this.CMB_Tipo_Cita.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMB_Tipo_Cita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Tipo_Cita.FocusedColor = System.Drawing.Color.Empty;
            this.CMB_Tipo_Cita.FocusedState.Parent = this.CMB_Tipo_Cita;
            this.CMB_Tipo_Cita.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_Tipo_Cita.ForeColor = System.Drawing.Color.Black;
            this.CMB_Tipo_Cita.FormattingEnabled = true;
            this.CMB_Tipo_Cita.HoverState.Parent = this.CMB_Tipo_Cita;
            this.CMB_Tipo_Cita.ItemHeight = 30;
            this.CMB_Tipo_Cita.ItemsAppearance.Parent = this.CMB_Tipo_Cita;
            this.CMB_Tipo_Cita.Location = new System.Drawing.Point(628, 107);
            this.CMB_Tipo_Cita.Name = "CMB_Tipo_Cita";
            this.CMB_Tipo_Cita.ShadowDecoration.Parent = this.CMB_Tipo_Cita;
            this.CMB_Tipo_Cita.Size = new System.Drawing.Size(183, 36);
            this.CMB_Tipo_Cita.TabIndex = 19;
            this.CMB_Tipo_Cita.SelectedValueChanged += new System.EventHandler(this.CMB_Tipo_Cita_SelectedValueChanged);
            // 
            // TxtNombre
            // 
            this.TxtNombre.BorderRadius = 10;
            this.TxtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombre.DefaultText = "";
            this.TxtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNombre.DisabledState.Parent = this.TxtNombre;
            this.TxtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNombre.FocusedState.Parent = this.TxtNombre;
            this.TxtNombre.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.TxtNombre.ForeColor = System.Drawing.Color.Black;
            this.TxtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNombre.HoverState.Parent = this.TxtNombre;
            this.TxtNombre.Location = new System.Drawing.Point(242, 107);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.PasswordChar = '\0';
            this.TxtNombre.PlaceholderText = "";
            this.TxtNombre.SelectedText = "";
            this.TxtNombre.ShadowDecoration.Parent = this.TxtNombre;
            this.TxtNombre.Size = new System.Drawing.Size(191, 32);
            this.TxtNombre.TabIndex = 18;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(668, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tipo Cita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.label2.Location = new System.Drawing.Point(270, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Buscar Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.label3.Location = new System.Drawing.Point(401, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 35);
            this.label3.TabIndex = 14;
            this.label3.Text = "Gestor de Citas";
            // 
            // DGVTablaCita
            // 
            this.DGVTablaCita.AllowUserToAddRows = false;
            this.DGVTablaCita.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVTablaCita.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVTablaCita.BackgroundColor = System.Drawing.Color.White;
            this.DGVTablaCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTablaCita.GridColor = System.Drawing.Color.Gray;
            this.DGVTablaCita.Location = new System.Drawing.Point(127, 153);
            this.DGVTablaCita.Name = "DGVTablaCita";
            this.DGVTablaCita.ReadOnly = true;
            this.DGVTablaCita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVTablaCita.Size = new System.Drawing.Size(702, 330);
            this.DGVTablaCita.TabIndex = 0;
            this.DGVTablaCita.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTablaCita_CellClick);
            // 
            // Btn_regresar
            // 
            this.Btn_regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.Btn_regresar.BorderRadius = 20;
            this.Btn_regresar.CheckedState.Parent = this.Btn_regresar;
            this.Btn_regresar.CustomImages.Parent = this.Btn_regresar;
            this.Btn_regresar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(151)))), ((int)(((byte)(142)))));
            this.Btn_regresar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_regresar.ForeColor = System.Drawing.Color.White;
            this.Btn_regresar.HoverState.Parent = this.Btn_regresar;
            this.Btn_regresar.Location = new System.Drawing.Point(595, 512);
            this.Btn_regresar.Name = "Btn_regresar";
            this.Btn_regresar.ShadowDecoration.Parent = this.Btn_regresar;
            this.Btn_regresar.Size = new System.Drawing.Size(163, 33);
            this.Btn_regresar.TabIndex = 23;
            this.Btn_regresar.Text = "Regresar";
            this.Btn_regresar.Visible = false;
            this.Btn_regresar.Click += new System.EventHandler(this.Btn_regresar_Click);
            // 
            // FrmGestor_Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 557);
            this.Controls.Add(this.Btn_regresar);
            this.Controls.Add(this.Panel_Citas);
            this.Controls.Add(this.Base);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestor_Citas";
            this.Text = "FrmGestor_Citas";
            this.Base.ResumeLayout(false);
            this.Base.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Patita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTablaCita)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Base;
        private Guna.UI2.WinForms.Guna2Button Bnt_Editar_Mascota;
        private Guna.UI2.WinForms.Guna2PictureBox Pic_Patita;
        private System.Windows.Forms.Label Lbl_Id_Mascota;
        private Guna.UI2.WinForms.Guna2Button Btn_Agregar_Cita;
        private Guna.UI2.WinForms.Guna2ComboBox CMB_Tipo_Cita;
        private Guna.UI2.WinForms.Guna2TextBox TxtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVTablaCita;
        private Guna.UI2.WinForms.Guna2Panel Panel_Citas;
        private System.Windows.Forms.Label Lbl_Id_Cita;
        private Guna.UI2.WinForms.Guna2Button Btn_regresar;
    }
}