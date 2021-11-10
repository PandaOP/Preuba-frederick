
namespace Arka
{
    partial class FrmInicio
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
            this.Fondo = new System.Windows.Forms.Panel();
            this.Panel_botones = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Mascotas_Totales = new System.Windows.Forms.Label();
            this.Lbl_Ventas_Dia = new System.Windows.Forms.Label();
            this.Lbl_Clientes_Totales = new System.Windows.Forms.Label();
            this.Lbl_Citas_Pendientes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Tipo_Usuario = new System.Windows.Forms.Label();
            this.Lbl_Nombre_Usuario = new System.Windows.Forms.Label();
            this.Pic_Usuario = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Pic_Ventas = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Pic_Cliente = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Pic_Mascota = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Pic_Calendario = new Guna.UI2.WinForms.Guna2PictureBox();
            this.logo_letras = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Baner = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Fondo.SuspendLayout();
            this.Panel_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Mascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Calendario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_letras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Baner)).BeginInit();
            this.SuspendLayout();
            // 
            // Fondo
            // 
            this.Fondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.Fondo.Controls.Add(this.Pic_Usuario);
            this.Fondo.Controls.Add(this.Panel_botones);
            this.Fondo.Controls.Add(this.logo_letras);
            this.Fondo.Controls.Add(this.Lbl_Tipo_Usuario);
            this.Fondo.Controls.Add(this.Lbl_Nombre_Usuario);
            this.Fondo.Controls.Add(this.Baner);
            this.Fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fondo.Location = new System.Drawing.Point(0, 0);
            this.Fondo.Name = "Fondo";
            this.Fondo.Size = new System.Drawing.Size(950, 540);
            this.Fondo.TabIndex = 0;
            // 
            // Panel_botones
            // 
            this.Panel_botones.BackColor = System.Drawing.Color.White;
            this.Panel_botones.Controls.Add(this.label4);
            this.Panel_botones.Controls.Add(this.label3);
            this.Panel_botones.Controls.Add(this.label1);
            this.Panel_botones.Controls.Add(this.Lbl_Mascotas_Totales);
            this.Panel_botones.Controls.Add(this.Lbl_Ventas_Dia);
            this.Panel_botones.Controls.Add(this.Lbl_Clientes_Totales);
            this.Panel_botones.Controls.Add(this.Lbl_Citas_Pendientes);
            this.Panel_botones.Controls.Add(this.label2);
            this.Panel_botones.Controls.Add(this.Pic_Ventas);
            this.Panel_botones.Controls.Add(this.Pic_Cliente);
            this.Panel_botones.Controls.Add(this.Pic_Mascota);
            this.Panel_botones.Controls.Add(this.Pic_Calendario);
            this.Panel_botones.Location = new System.Drawing.Point(300, 63);
            this.Panel_botones.Name = "Panel_botones";
            this.Panel_botones.Size = new System.Drawing.Size(609, 416);
            this.Panel_botones.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(388, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ventas del Día";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mascotas Totales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(377, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clientes Totales";
            // 
            // Lbl_Mascotas_Totales
            // 
            this.Lbl_Mascotas_Totales.AutoSize = true;
            this.Lbl_Mascotas_Totales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.Lbl_Mascotas_Totales.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mascotas_Totales.ForeColor = System.Drawing.Color.White;
            this.Lbl_Mascotas_Totales.Location = new System.Drawing.Point(60, 355);
            this.Lbl_Mascotas_Totales.Name = "Lbl_Mascotas_Totales";
            this.Lbl_Mascotas_Totales.Size = new System.Drawing.Size(101, 24);
            this.Lbl_Mascotas_Totales.TabIndex = 2;
            this.Lbl_Mascotas_Totales.Text = "-------------";
            // 
            // Lbl_Ventas_Dia
            // 
            this.Lbl_Ventas_Dia.AutoSize = true;
            this.Lbl_Ventas_Dia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.Lbl_Ventas_Dia.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Ventas_Dia.ForeColor = System.Drawing.Color.White;
            this.Lbl_Ventas_Dia.Location = new System.Drawing.Point(388, 333);
            this.Lbl_Ventas_Dia.Name = "Lbl_Ventas_Dia";
            this.Lbl_Ventas_Dia.Size = new System.Drawing.Size(101, 24);
            this.Lbl_Ventas_Dia.TabIndex = 2;
            this.Lbl_Ventas_Dia.Text = "-------------";
            // 
            // Lbl_Clientes_Totales
            // 
            this.Lbl_Clientes_Totales.AutoSize = true;
            this.Lbl_Clientes_Totales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.Lbl_Clientes_Totales.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Clientes_Totales.ForeColor = System.Drawing.Color.White;
            this.Lbl_Clientes_Totales.Location = new System.Drawing.Point(377, 157);
            this.Lbl_Clientes_Totales.Name = "Lbl_Clientes_Totales";
            this.Lbl_Clientes_Totales.Size = new System.Drawing.Size(101, 24);
            this.Lbl_Clientes_Totales.TabIndex = 2;
            this.Lbl_Clientes_Totales.Text = "-------------";
            // 
            // Lbl_Citas_Pendientes
            // 
            this.Lbl_Citas_Pendientes.AutoSize = true;
            this.Lbl_Citas_Pendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.Lbl_Citas_Pendientes.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Citas_Pendientes.ForeColor = System.Drawing.Color.White;
            this.Lbl_Citas_Pendientes.Location = new System.Drawing.Point(64, 157);
            this.Lbl_Citas_Pendientes.Name = "Lbl_Citas_Pendientes";
            this.Lbl_Citas_Pendientes.Size = new System.Drawing.Size(101, 24);
            this.Lbl_Citas_Pendientes.TabIndex = 2;
            this.Lbl_Citas_Pendientes.Text = "-------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(45)))), ((int)(((byte)(96)))));
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Citas Pendientes";
            // 
            // Lbl_Tipo_Usuario
            // 
            this.Lbl_Tipo_Usuario.AutoSize = true;
            this.Lbl_Tipo_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(142)))));
            this.Lbl_Tipo_Usuario.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tipo_Usuario.ForeColor = System.Drawing.Color.White;
            this.Lbl_Tipo_Usuario.Location = new System.Drawing.Point(41, 202);
            this.Lbl_Tipo_Usuario.Name = "Lbl_Tipo_Usuario";
            this.Lbl_Tipo_Usuario.Size = new System.Drawing.Size(129, 24);
            this.Lbl_Tipo_Usuario.TabIndex = 2;
            this.Lbl_Tipo_Usuario.Text = "-----------------";
            // 
            // Lbl_Nombre_Usuario
            // 
            this.Lbl_Nombre_Usuario.AutoSize = true;
            this.Lbl_Nombre_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(142)))));
            this.Lbl_Nombre_Usuario.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre_Usuario.ForeColor = System.Drawing.Color.White;
            this.Lbl_Nombre_Usuario.Location = new System.Drawing.Point(42, 167);
            this.Lbl_Nombre_Usuario.Name = "Lbl_Nombre_Usuario";
            this.Lbl_Nombre_Usuario.Size = new System.Drawing.Size(129, 24);
            this.Lbl_Nombre_Usuario.TabIndex = 2;
            this.Lbl_Nombre_Usuario.Text = "-----------------";
            // 
            // Pic_Usuario
            // 
            this.Pic_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.Pic_Usuario.Image = global::Arka.Properties.Resources.Usuario;
            this.Pic_Usuario.Location = new System.Drawing.Point(35, 13);
            this.Pic_Usuario.Name = "Pic_Usuario";
            this.Pic_Usuario.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Pic_Usuario.ShadowDecoration.Parent = this.Pic_Usuario;
            this.Pic_Usuario.Size = new System.Drawing.Size(150, 150);
            this.Pic_Usuario.TabIndex = 3;
            this.Pic_Usuario.TabStop = false;
            // 
            // Pic_Ventas
            // 
            this.Pic_Ventas.Image = global::Arka.Properties.Resources.ventas;
            this.Pic_Ventas.Location = new System.Drawing.Point(340, 232);
            this.Pic_Ventas.Name = "Pic_Ventas";
            this.Pic_Ventas.ShadowDecoration.Parent = this.Pic_Ventas;
            this.Pic_Ventas.Size = new System.Drawing.Size(227, 157);
            this.Pic_Ventas.TabIndex = 0;
            this.Pic_Ventas.TabStop = false;
            // 
            // Pic_Cliente
            // 
            this.Pic_Cliente.Image = global::Arka.Properties.Resources.Cliente;
            this.Pic_Cliente.Location = new System.Drawing.Point(340, 40);
            this.Pic_Cliente.Name = "Pic_Cliente";
            this.Pic_Cliente.ShadowDecoration.Parent = this.Pic_Cliente;
            this.Pic_Cliente.Size = new System.Drawing.Size(227, 157);
            this.Pic_Cliente.TabIndex = 0;
            this.Pic_Cliente.TabStop = false;
            // 
            // Pic_Mascota
            // 
            this.Pic_Mascota.Image = global::Arka.Properties.Resources.Mascota;
            this.Pic_Mascota.Location = new System.Drawing.Point(33, 232);
            this.Pic_Mascota.Name = "Pic_Mascota";
            this.Pic_Mascota.ShadowDecoration.Parent = this.Pic_Mascota;
            this.Pic_Mascota.Size = new System.Drawing.Size(227, 157);
            this.Pic_Mascota.TabIndex = 0;
            this.Pic_Mascota.TabStop = false;
            // 
            // Pic_Calendario
            // 
            this.Pic_Calendario.Image = global::Arka.Properties.Resources.Calendario;
            this.Pic_Calendario.Location = new System.Drawing.Point(33, 40);
            this.Pic_Calendario.Name = "Pic_Calendario";
            this.Pic_Calendario.ShadowDecoration.Parent = this.Pic_Calendario;
            this.Pic_Calendario.Size = new System.Drawing.Size(227, 157);
            this.Pic_Calendario.TabIndex = 0;
            this.Pic_Calendario.TabStop = false;
            // 
            // logo_letras
            // 
            this.logo_letras.Image = global::Arka.Properties.Resources.LOGO_VETERINARIA_letras;
            this.logo_letras.Location = new System.Drawing.Point(-13, 258);
            this.logo_letras.Name = "logo_letras";
            this.logo_letras.ShadowDecoration.Parent = this.logo_letras;
            this.logo_letras.Size = new System.Drawing.Size(277, 281);
            this.logo_letras.TabIndex = 0;
            this.logo_letras.TabStop = false;
            // 
            // Baner
            // 
            this.Baner.Image = global::Arka.Properties.Resources.Baner_Inicio;
            this.Baner.Location = new System.Drawing.Point(0, 0);
            this.Baner.Name = "Baner";
            this.Baner.ShadowDecoration.Parent = this.Baner;
            this.Baner.Size = new System.Drawing.Size(250, 250);
            this.Baner.TabIndex = 0;
            this.Baner.TabStop = false;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 540);
            this.Controls.Add(this.Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.Text = "FrmInicio";
            this.Fondo.ResumeLayout(false);
            this.Fondo.PerformLayout();
            this.Panel_botones.ResumeLayout(false);
            this.Panel_botones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Mascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Calendario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_letras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Baner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Fondo;
        private Guna.UI2.WinForms.Guna2PictureBox Baner;
        private Guna.UI2.WinForms.Guna2PictureBox logo_letras;
        private System.Windows.Forms.Panel Panel_botones;
        private Guna.UI2.WinForms.Guna2PictureBox Pic_Ventas;
        private Guna.UI2.WinForms.Guna2PictureBox Pic_Cliente;
        private Guna.UI2.WinForms.Guna2PictureBox Pic_Mascota;
        private Guna.UI2.WinForms.Guna2PictureBox Pic_Calendario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Mascotas_Totales;
        private System.Windows.Forms.Label Lbl_Ventas_Dia;
        private System.Windows.Forms.Label Lbl_Clientes_Totales;
        private System.Windows.Forms.Label Lbl_Citas_Pendientes;
        private System.Windows.Forms.Label Lbl_Tipo_Usuario;
        private System.Windows.Forms.Label Lbl_Nombre_Usuario;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Pic_Usuario;
    }
}