
namespace Arka
{
    partial class Principal_Arka
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal_Arka));
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.Btn_ocultar = new System.Windows.Forms.PictureBox();
            this.Btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.Panel_visual = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Elipse_Curva = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Desplegar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Panel_Menu = new System.Windows.Forms.Panel();
            this.Btn_Estadistica = new Guna.UI2.WinForms.Guna2TileButton();
            this.Btn_Animales = new Guna.UI2.WinForms.Guna2TileButton();
            this.Btn_Proveedores = new Guna.UI2.WinForms.Guna2TileButton();
            this.Btn_Ventas = new Guna.UI2.WinForms.Guna2TileButton();
            this.Btn_Clientes = new Guna.UI2.WinForms.Guna2TileButton();
            this.Btn_Citas = new Guna.UI2.WinForms.Guna2TileButton();
            this.Btn_Inicio = new Guna.UI2.WinForms.Guna2TileButton();
            this.ocultar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_ocultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).BeginInit();
            this.Panel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(52)))), ((int)(((byte)(114)))));
            this.MenuTop.Controls.Add(this.Btn_ocultar);
            this.MenuTop.Controls.Add(this.Btn_Cerrar);
            this.ocultar.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.Desplegar.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(950, 43);
            this.MenuTop.TabIndex = 0;
            this.MenuTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseDown);
            // 
            // Btn_ocultar
            // 
            this.Btn_ocultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Desplegar.SetDecoration(this.Btn_ocultar, BunifuAnimatorNS.DecorationType.None);
            this.ocultar.SetDecoration(this.Btn_ocultar, BunifuAnimatorNS.DecorationType.None);
            this.Btn_ocultar.Image = global::Arka.Properties.Resources.minus_solid;
            this.Btn_ocultar.Location = new System.Drawing.Point(865, 17);
            this.Btn_ocultar.Name = "Btn_ocultar";
            this.Btn_ocultar.Size = new System.Drawing.Size(32, 15);
            this.Btn_ocultar.TabIndex = 0;
            this.Btn_ocultar.TabStop = false;
            this.Btn_ocultar.Tag = "";
            this.Btn_ocultar.Click += new System.EventHandler(this.Btn_ocultar_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Desplegar.SetDecoration(this.Btn_Cerrar, BunifuAnimatorNS.DecorationType.None);
            this.ocultar.SetDecoration(this.Btn_Cerrar, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Cerrar.Image = global::Arka.Properties.Resources.times_solid;
            this.Btn_Cerrar.Location = new System.Drawing.Point(913, 6);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(30, 30);
            this.Btn_Cerrar.TabIndex = 0;
            this.Btn_Cerrar.TabStop = false;
            this.Btn_Cerrar.Tag = "";
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Panel_visual
            // 
            this.Panel_visual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(216)))));
            this.ocultar.SetDecoration(this.Panel_visual, BunifuAnimatorNS.DecorationType.None);
            this.Desplegar.SetDecoration(this.Panel_visual, BunifuAnimatorNS.DecorationType.None);
            this.Panel_visual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_visual.Location = new System.Drawing.Point(0, 43);
            this.Panel_visual.Name = "Panel_visual";
            this.Panel_visual.Size = new System.Drawing.Size(950, 557);
            this.Panel_visual.TabIndex = 1;
            // 
            // Elipse_Curva
            // 
            this.Elipse_Curva.ElipseRadius = 7;
            this.Elipse_Curva.TargetControl = this;
            // 
            // Desplegar
            // 
            this.Desplegar.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.Desplegar.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.Desplegar.DefaultAnimation = animation5;
            // 
            // Panel_Menu
            // 
            this.Panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(142)))));
            this.Panel_Menu.Controls.Add(this.Btn_Estadistica);
            this.Panel_Menu.Controls.Add(this.Btn_Animales);
            this.Panel_Menu.Controls.Add(this.Btn_Proveedores);
            this.Panel_Menu.Controls.Add(this.Btn_Ventas);
            this.Panel_Menu.Controls.Add(this.Btn_Clientes);
            this.Panel_Menu.Controls.Add(this.Btn_Citas);
            this.Panel_Menu.Controls.Add(this.Btn_Inicio);
            this.ocultar.SetDecoration(this.Panel_Menu, BunifuAnimatorNS.DecorationType.None);
            this.Desplegar.SetDecoration(this.Panel_Menu, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Menu.Location = new System.Drawing.Point(0, 43);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(950, 25);
            this.Panel_Menu.TabIndex = 2;
            // 
            // Btn_Estadistica
            // 
            this.Btn_Estadistica.CheckedState.Parent = this.Btn_Estadistica;
            this.Btn_Estadistica.CustomImages.Parent = this.Btn_Estadistica;
            this.ocultar.SetDecoration(this.Btn_Estadistica, BunifuAnimatorNS.DecorationType.None);
            this.Desplegar.SetDecoration(this.Btn_Estadistica, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Estadistica.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Estadistica.ForeColor = System.Drawing.Color.White;
            this.Btn_Estadistica.HoverState.Parent = this.Btn_Estadistica;
            this.Btn_Estadistica.Location = new System.Drawing.Point(501, 2);
            this.Btn_Estadistica.Name = "Btn_Estadistica";
            this.Btn_Estadistica.ShadowDecoration.Parent = this.Btn_Estadistica;
            this.Btn_Estadistica.Size = new System.Drawing.Size(102, 21);
            this.Btn_Estadistica.TabIndex = 0;
            this.Btn_Estadistica.Text = "Estadísticas";
            // 
            // Btn_Animales
            // 
            this.Btn_Animales.CheckedState.Parent = this.Btn_Animales;
            this.Btn_Animales.CustomImages.Parent = this.Btn_Animales;
            this.ocultar.SetDecoration(this.Btn_Animales, BunifuAnimatorNS.DecorationType.None);
            this.Desplegar.SetDecoration(this.Btn_Animales, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Animales.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Animales.ForeColor = System.Drawing.Color.White;
            this.Btn_Animales.HoverState.Parent = this.Btn_Animales;
            this.Btn_Animales.Location = new System.Drawing.Point(396, 2);
            this.Btn_Animales.Name = "Btn_Animales";
            this.Btn_Animales.ShadowDecoration.Parent = this.Btn_Animales;
            this.Btn_Animales.Size = new System.Drawing.Size(102, 21);
            this.Btn_Animales.TabIndex = 0;
            this.Btn_Animales.Text = "Animales";
            this.Btn_Animales.Click += new System.EventHandler(this.Btn_Animales_Click);
            // 
            // Btn_Proveedores
            // 
            this.Btn_Proveedores.CheckedState.Parent = this.Btn_Proveedores;
            this.Btn_Proveedores.CustomImages.Parent = this.Btn_Proveedores;
            this.ocultar.SetDecoration(this.Btn_Proveedores, BunifuAnimatorNS.DecorationType.None);
            this.Desplegar.SetDecoration(this.Btn_Proveedores, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Proveedores.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Proveedores.ForeColor = System.Drawing.Color.White;
            this.Btn_Proveedores.HoverState.Parent = this.Btn_Proveedores;
            this.Btn_Proveedores.Location = new System.Drawing.Point(276, 2);
            this.Btn_Proveedores.Name = "Btn_Proveedores";
            this.Btn_Proveedores.ShadowDecoration.Parent = this.Btn_Proveedores;
            this.Btn_Proveedores.Size = new System.Drawing.Size(116, 21);
            this.Btn_Proveedores.TabIndex = 0;
            this.Btn_Proveedores.Text = "Proveedores";
            // 
            // Btn_Ventas
            // 
            this.Btn_Ventas.CheckedState.Parent = this.Btn_Ventas;
            this.Btn_Ventas.CustomImages.Parent = this.Btn_Ventas;
            this.ocultar.SetDecoration(this.Btn_Ventas, BunifuAnimatorNS.DecorationType.None);
            this.Desplegar.SetDecoration(this.Btn_Ventas, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Ventas.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ventas.ForeColor = System.Drawing.Color.White;
            this.Btn_Ventas.HoverState.Parent = this.Btn_Ventas;
            this.Btn_Ventas.Location = new System.Drawing.Point(211, 2);
            this.Btn_Ventas.Name = "Btn_Ventas";
            this.Btn_Ventas.ShadowDecoration.Parent = this.Btn_Ventas;
            this.Btn_Ventas.Size = new System.Drawing.Size(63, 21);
            this.Btn_Ventas.TabIndex = 0;
            this.Btn_Ventas.Text = "Ventas";
            // 
            // Btn_Clientes
            // 
            this.Btn_Clientes.CheckedState.Parent = this.Btn_Clientes;
            this.Btn_Clientes.CustomImages.Parent = this.Btn_Clientes;
            this.ocultar.SetDecoration(this.Btn_Clientes, BunifuAnimatorNS.DecorationType.None);
            this.Desplegar.SetDecoration(this.Btn_Clientes, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Clientes.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clientes.ForeColor = System.Drawing.Color.White;
            this.Btn_Clientes.HoverState.Parent = this.Btn_Clientes;
            this.Btn_Clientes.Location = new System.Drawing.Point(133, 2);
            this.Btn_Clientes.Name = "Btn_Clientes";
            this.Btn_Clientes.ShadowDecoration.Parent = this.Btn_Clientes;
            this.Btn_Clientes.Size = new System.Drawing.Size(75, 21);
            this.Btn_Clientes.TabIndex = 0;
            this.Btn_Clientes.Text = "Clientes";
            // 
            // Btn_Citas
            // 
            this.Btn_Citas.CheckedState.Parent = this.Btn_Citas;
            this.Btn_Citas.CustomImages.Parent = this.Btn_Citas;
            this.ocultar.SetDecoration(this.Btn_Citas, BunifuAnimatorNS.DecorationType.None);
            this.Desplegar.SetDecoration(this.Btn_Citas, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Citas.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Citas.ForeColor = System.Drawing.Color.White;
            this.Btn_Citas.HoverState.Parent = this.Btn_Citas;
            this.Btn_Citas.Location = new System.Drawing.Point(68, 2);
            this.Btn_Citas.Name = "Btn_Citas";
            this.Btn_Citas.ShadowDecoration.Parent = this.Btn_Citas;
            this.Btn_Citas.Size = new System.Drawing.Size(61, 21);
            this.Btn_Citas.TabIndex = 0;
            this.Btn_Citas.Text = "Citas";
            this.Btn_Citas.Click += new System.EventHandler(this.Btn_Citas_Click);
            // 
            // Btn_Inicio
            // 
            this.Btn_Inicio.CheckedState.Parent = this.Btn_Inicio;
            this.Btn_Inicio.CustomImages.Parent = this.Btn_Inicio;
            this.ocultar.SetDecoration(this.Btn_Inicio, BunifuAnimatorNS.DecorationType.None);
            this.Desplegar.SetDecoration(this.Btn_Inicio, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Inicio.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Inicio.ForeColor = System.Drawing.Color.White;
            this.Btn_Inicio.HoverState.Parent = this.Btn_Inicio;
            this.Btn_Inicio.Location = new System.Drawing.Point(3, 1);
            this.Btn_Inicio.Name = "Btn_Inicio";
            this.Btn_Inicio.ShadowDecoration.Parent = this.Btn_Inicio;
            this.Btn_Inicio.Size = new System.Drawing.Size(61, 21);
            this.Btn_Inicio.TabIndex = 0;
            this.Btn_Inicio.Text = "Inicio";
            this.Btn_Inicio.Click += new System.EventHandler(this.Btn_Inicio_Click);
            // 
            // ocultar
            // 
            this.ocultar.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.ocultar.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.ocultar.DefaultAnimation = animation6;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Principal_Arka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.Panel_Menu);
            this.Controls.Add(this.Panel_visual);
            this.Controls.Add(this.MenuTop);
            this.ocultar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Desplegar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal_Arka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio del Arka";
            this.Load += new System.EventHandler(this.Principal_Arka_Load);
            this.MenuTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_ocultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).EndInit();
            this.Panel_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.Panel Panel_visual;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox Btn_Cerrar;
        private System.Windows.Forms.PictureBox Btn_ocultar;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Curva;
        private BunifuAnimatorNS.BunifuTransition Desplegar;
        private BunifuAnimatorNS.BunifuTransition ocultar;
        private System.Windows.Forms.Panel Panel_Menu;
        private Guna.UI2.WinForms.Guna2TileButton Btn_Inicio;
        private Guna.UI2.WinForms.Guna2TileButton Btn_Estadistica;
        private Guna.UI2.WinForms.Guna2TileButton Btn_Animales;
        private Guna.UI2.WinForms.Guna2TileButton Btn_Proveedores;
        private Guna.UI2.WinForms.Guna2TileButton Btn_Ventas;
        private Guna.UI2.WinForms.Guna2TileButton Btn_Clientes;
        private Guna.UI2.WinForms.Guna2TileButton Btn_Citas;
        private System.Windows.Forms.Timer timer1;
    }
}