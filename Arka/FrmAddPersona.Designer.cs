
namespace Arka
{
    partial class FrmEditarMascota
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
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Txt_Cedula = new System.Windows.Forms.TextBox();
            this.Txt_Telefono = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Cedula = new System.Windows.Forms.Label();
            this.Lbl_Telefono = new System.Windows.Forms.Label();
            this.Txt_Apellido = new System.Windows.Forms.TextBox();
            this.Lbl_apellido = new System.Windows.Forms.Label();
            this.cmb_Tipo_telefono = new System.Windows.Forms.ComboBox();
            this.cmb_Municipio_Dep = new System.Windows.Forms.ComboBox();
            this.Lbl_Municipio_Dep = new System.Windows.Forms.Label();
            this.Lbl_Direccion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblconfirmacion = new System.Windows.Forms.Label();
            this.CmbUsuario = new System.Windows.Forms.ComboBox();
            this.lblTipo_usuario = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtpassrepit = new System.Windows.Forms.TextBox();
            this.Txtpass = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Cerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(40, 68);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(169, 20);
            this.Txt_nombre.TabIndex = 0;
            this.Txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_nombre_KeyPress);
            // 
            // Txt_Cedula
            // 
            this.Txt_Cedula.Location = new System.Drawing.Point(40, 124);
            this.Txt_Cedula.MaxLength = 16;
            this.Txt_Cedula.Name = "Txt_Cedula";
            this.Txt_Cedula.Size = new System.Drawing.Size(169, 20);
            this.Txt_Cedula.TabIndex = 0;
            // 
            // Txt_Telefono
            // 
            this.Txt_Telefono.Location = new System.Drawing.Point(104, 306);
            this.Txt_Telefono.MaxLength = 8;
            this.Txt_Telefono.Name = "Txt_Telefono";
            this.Txt_Telefono.Size = new System.Drawing.Size(131, 20);
            this.Txt_Telefono.TabIndex = 0;
            this.Txt_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Telefono_KeyPress);
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre.Location = new System.Drawing.Point(85, 46);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(58, 20);
            this.Lbl_Nombre.TabIndex = 1;
            this.Lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Cedula
            // 
            this.lbl_Cedula.AutoSize = true;
            this.lbl_Cedula.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cedula.Location = new System.Drawing.Point(85, 102);
            this.lbl_Cedula.Name = "lbl_Cedula";
            this.lbl_Cedula.Size = new System.Drawing.Size(52, 20);
            this.lbl_Cedula.TabIndex = 1;
            this.lbl_Cedula.Text = "Cedula";
            // 
            // Lbl_Telefono
            // 
            this.Lbl_Telefono.AutoSize = true;
            this.Lbl_Telefono.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Telefono.Location = new System.Drawing.Point(203, 278);
            this.Lbl_Telefono.Name = "Lbl_Telefono";
            this.Lbl_Telefono.Size = new System.Drawing.Size(63, 20);
            this.Lbl_Telefono.TabIndex = 1;
            this.Lbl_Telefono.Text = "Teléfono";
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Location = new System.Drawing.Point(261, 68);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Size = new System.Drawing.Size(169, 20);
            this.Txt_Apellido.TabIndex = 0;
            this.Txt_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Apellido_KeyPress);
            // 
            // Lbl_apellido
            // 
            this.Lbl_apellido.AutoSize = true;
            this.Lbl_apellido.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_apellido.Location = new System.Drawing.Point(308, 46);
            this.Lbl_apellido.Name = "Lbl_apellido";
            this.Lbl_apellido.Size = new System.Drawing.Size(61, 20);
            this.Lbl_apellido.TabIndex = 1;
            this.Lbl_apellido.Text = "Apellido";
            // 
            // cmb_Tipo_telefono
            // 
            this.cmb_Tipo_telefono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tipo_telefono.FormattingEnabled = true;
            this.cmb_Tipo_telefono.Location = new System.Drawing.Point(241, 305);
            this.cmb_Tipo_telefono.Name = "cmb_Tipo_telefono";
            this.cmb_Tipo_telefono.Size = new System.Drawing.Size(121, 21);
            this.cmb_Tipo_telefono.TabIndex = 2;
            // 
            // cmb_Municipio_Dep
            // 
            this.cmb_Municipio_Dep.FormattingEnabled = true;
            this.cmb_Municipio_Dep.Location = new System.Drawing.Point(261, 123);
            this.cmb_Municipio_Dep.Name = "cmb_Municipio_Dep";
            this.cmb_Municipio_Dep.Size = new System.Drawing.Size(169, 21);
            this.cmb_Municipio_Dep.TabIndex = 3;
            // 
            // Lbl_Municipio_Dep
            // 
            this.Lbl_Municipio_Dep.AutoSize = true;
            this.Lbl_Municipio_Dep.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Municipio_Dep.Location = new System.Drawing.Point(269, 102);
            this.Lbl_Municipio_Dep.Name = "Lbl_Municipio_Dep";
            this.Lbl_Municipio_Dep.Size = new System.Drawing.Size(161, 20);
            this.Lbl_Municipio_Dep.TabIndex = 4;
            this.Lbl_Municipio_Dep.Text = "Municipio-Departamento";
            // 
            // Lbl_Direccion
            // 
            this.Lbl_Direccion.AutoSize = true;
            this.Lbl_Direccion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Direccion.Location = new System.Drawing.Point(203, 340);
            this.Lbl_Direccion.Name = "Lbl_Direccion";
            this.Lbl_Direccion.Size = new System.Drawing.Size(68, 20);
            this.Lbl_Direccion.TabIndex = 5;
            this.Lbl_Direccion.Text = "Direccion";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(40, 363);
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_direccion.Size = new System.Drawing.Size(390, 94);
            this.txt_direccion.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblconfirmacion);
            this.panel1.Controls.Add(this.CmbUsuario);
            this.panel1.Controls.Add(this.lblTipo_usuario);
            this.panel1.Controls.Add(this.usuario);
            this.panel1.Controls.Add(this.TxtUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Txtpassrepit);
            this.panel1.Controls.Add(this.Txtpass);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Btn_Agregar);
            this.panel1.Controls.Add(this.txt_direccion);
            this.panel1.Controls.Add(this.Lbl_Direccion);
            this.panel1.Controls.Add(this.Lbl_Municipio_Dep);
            this.panel1.Controls.Add(this.cmb_Municipio_Dep);
            this.panel1.Controls.Add(this.cmb_Tipo_telefono);
            this.panel1.Controls.Add(this.Lbl_apellido);
            this.panel1.Controls.Add(this.Txt_Apellido);
            this.panel1.Controls.Add(this.Lbl_Telefono);
            this.panel1.Controls.Add(this.lbl_Cedula);
            this.panel1.Controls.Add(this.Lbl_Nombre);
            this.panel1.Controls.Add(this.Txt_Telefono);
            this.panel1.Controls.Add(this.Txt_Cedula);
            this.panel1.Controls.Add(this.Txt_nombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 511);
            this.panel1.TabIndex = 0;
            // 
            // lblconfirmacion
            // 
            this.lblconfirmacion.ForeColor = System.Drawing.Color.Red;
            this.lblconfirmacion.Location = new System.Drawing.Point(258, 266);
            this.lblconfirmacion.Name = "lblconfirmacion";
            this.lblconfirmacion.Size = new System.Drawing.Size(162, 20);
            this.lblconfirmacion.TabIndex = 16;
            this.lblconfirmacion.Text = "CONTRASEÑA NO COINSIDEN";
            this.lblconfirmacion.Visible = false;
            // 
            // CmbUsuario
            // 
            this.CmbUsuario.FormattingEnabled = true;
            this.CmbUsuario.Location = new System.Drawing.Point(261, 183);
            this.CmbUsuario.Name = "CmbUsuario";
            this.CmbUsuario.Size = new System.Drawing.Size(169, 21);
            this.CmbUsuario.TabIndex = 14;
            // 
            // lblTipo_usuario
            // 
            this.lblTipo_usuario.AutoSize = true;
            this.lblTipo_usuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo_usuario.Location = new System.Drawing.Point(296, 160);
            this.lblTipo_usuario.Name = "lblTipo_usuario";
            this.lblTipo_usuario.Size = new System.Drawing.Size(89, 20);
            this.lblTipo_usuario.TabIndex = 13;
            this.lblTipo_usuario.Text = "Tipo Usuario";
            this.lblTipo_usuario.Click += new System.EventHandler(this.label3_Click);
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(86, 160);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(57, 20);
            this.usuario.TabIndex = 13;
            this.usuario.Text = "Usuario";
            this.usuario.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(40, 183);
            this.TxtUsuario.MaxLength = 255;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(171, 20);
            this.TxtUsuario.TabIndex = 12;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Confirmar Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Contraseña";
            // 
            // Txtpassrepit
            // 
            this.Txtpassrepit.Location = new System.Drawing.Point(261, 243);
            this.Txtpassrepit.Name = "Txtpassrepit";
            this.Txtpassrepit.PasswordChar = '*';
            this.Txtpassrepit.Size = new System.Drawing.Size(169, 20);
            this.Txtpassrepit.TabIndex = 10;
            this.Txtpassrepit.UseSystemPasswordChar = true;
            this.Txtpassrepit.TextChanged += new System.EventHandler(this.Txtpassrepit_TextChanged);
            // 
            // Txtpass
            // 
            this.Txtpass.Location = new System.Drawing.Point(42, 243);
            this.Txtpass.Name = "Txtpass";
            this.Txtpass.PasswordChar = '*';
            this.Txtpass.Size = new System.Drawing.Size(169, 20);
            this.Txtpass.TabIndex = 9;
            this.Txtpass.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.Btn_Cerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 35);
            this.panel2.TabIndex = 8;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Cerrar.Image = global::Arka.Properties.Resources.cerrar_Blanco;
            this.Btn_Cerrar.ImageActive = null;
            this.Btn_Cerrar.Location = new System.Drawing.Point(446, 5);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(24, 25);
            this.Btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Cerrar.TabIndex = 0;
            this.Btn_Cerrar.TabStop = false;
            this.Btn_Cerrar.Zoom = 10;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Location = new System.Drawing.Point(173, 476);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(115, 23);
            this.Btn_Agregar.TabIndex = 7;
            this.Btn_Agregar.Text = "Agregar Persona";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblUsuario.Location = new System.Drawing.Point(39, 206);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(162, 20);
            this.lblUsuario.TabIndex = 17;
            this.lblUsuario.Text = "USUARIO YA EXISTE";
            this.lblUsuario.Visible = false;
            // 
            // FrmAddPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(478, 511);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddPersona";
            this.Text = "FrmAddPersona";
            this.Load += new System.EventHandler(this.FrmAddPersona_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.TextBox Txt_Cedula;
        private System.Windows.Forms.TextBox Txt_Telefono;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Label lbl_Cedula;
        private System.Windows.Forms.Label Lbl_Telefono;
        private System.Windows.Forms.TextBox Txt_Apellido;
        private System.Windows.Forms.Label Lbl_apellido;
        private System.Windows.Forms.ComboBox cmb_Tipo_telefono;
        private System.Windows.Forms.ComboBox cmb_Municipio_Dep;
        private System.Windows.Forms.Label Lbl_Municipio_Dep;
        private System.Windows.Forms.Label Lbl_Direccion;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Agregar;
        private Bunifu.Framework.UI.BunifuImageButton Btn_Cerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtpassrepit;
        private System.Windows.Forms.TextBox Txtpass;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.ComboBox CmbUsuario;
        private System.Windows.Forms.Label lblTipo_usuario;
        private System.Windows.Forms.Label lblconfirmacion;
        private System.Windows.Forms.Label lblUsuario;
    }
}