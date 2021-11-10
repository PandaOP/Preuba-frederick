
namespace Arka
{
    partial class FrmCitas
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
            this.Panel_base = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbPropietarios = new System.Windows.Forms.ComboBox();
            this.Btn_Agregar_Cita = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DTP_Hora_Inicio = new System.Windows.Forms.DateTimePicker();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Cmb_Veterinario = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Fecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Notas = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_Cedula = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_Nombre_Cliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.DTP_Hora_Final = new System.Windows.Forms.DateTimePicker();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Panel_base.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_base
            // 
            this.Panel_base.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.Panel_base.Controls.Add(this.panel2);
            this.Panel_base.Controls.Add(this.cmbPropietarios);
            this.Panel_base.Controls.Add(this.Btn_Agregar_Cita);
            this.Panel_base.Controls.Add(this.panel1);
            this.Panel_base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_base.Location = new System.Drawing.Point(0, 0);
            this.Panel_base.Name = "Panel_base";
            this.Panel_base.Size = new System.Drawing.Size(950, 557);
            this.Panel_base.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Location = new System.Drawing.Point(12, 498);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(63, 51);
            this.panel2.TabIndex = 24;
            // 
            // cmbPropietarios
            // 
            this.cmbPropietarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPropietarios.FormattingEnabled = true;
            this.cmbPropietarios.Location = new System.Drawing.Point(35, 506);
            this.cmbPropietarios.Name = "cmbPropietarios";
            this.cmbPropietarios.Size = new System.Drawing.Size(10, 21);
            this.cmbPropietarios.TabIndex = 23;
            this.cmbPropietarios.TextChanged += new System.EventHandler(this.cmbPropietarios_TextChanged);
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
            this.Btn_Agregar_Cita.Location = new System.Drawing.Point(193, 512);
            this.Btn_Agregar_Cita.Name = "Btn_Agregar_Cita";
            this.Btn_Agregar_Cita.ShadowDecoration.Parent = this.Btn_Agregar_Cita;
            this.Btn_Agregar_Cita.Size = new System.Drawing.Size(163, 33);
            this.Btn_Agregar_Cita.TabIndex = 22;
            this.Btn_Agregar_Cita.Text = "Agregar Cita";
            this.Btn_Agregar_Cita.Click += new System.EventHandler(this.Btn_Agregar_Cita_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.DTP_Hora_Final);
            this.panel1.Controls.Add(this.DTP_Hora_Inicio);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.Cmb_Veterinario);
            this.panel1.Controls.Add(this.Fecha);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Txt_Notas);
            this.panel1.Controls.Add(this.Txt_Cedula);
            this.panel1.Controls.Add(this.guna2TextBox3);
            this.panel1.Controls.Add(this.guna2TextBox2);
            this.panel1.Controls.Add(this.Txt_Nombre_Cliente);
            this.panel1.Location = new System.Drawing.Point(73, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 377);
            this.panel1.TabIndex = 0;
            // 
            // DTP_Hora_Inicio
            // 
            this.DTP_Hora_Inicio.CalendarFont = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold);
            this.DTP_Hora_Inicio.CalendarForeColor = System.Drawing.Color.Red;
            this.DTP_Hora_Inicio.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.DTP_Hora_Inicio.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.DTP_Hora_Inicio.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.DTP_Hora_Inicio.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.DTP_Hora_Inicio.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.DTP_Hora_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTP_Hora_Inicio.Location = new System.Drawing.Point(219, 168);
            this.DTP_Hora_Inicio.Name = "DTP_Hora_Inicio";
            this.DTP_Hora_Inicio.ShowUpDown = true;
            this.DTP_Hora_Inicio.Size = new System.Drawing.Size(120, 21);
            this.DTP_Hora_Inicio.TabIndex = 25;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Arka.Properties.Resources.LOGO_VETERINARIA_letras;
            this.guna2PictureBox1.Location = new System.Drawing.Point(480, 67);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(308, 273);
            this.guna2PictureBox1.TabIndex = 9;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Cmb_Veterinario
            // 
            this.Cmb_Veterinario.BackColor = System.Drawing.Color.Transparent;
            this.Cmb_Veterinario.BorderRadius = 10;
            this.Cmb_Veterinario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_Veterinario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Veterinario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.Cmb_Veterinario.FocusedColor = System.Drawing.Color.Empty;
            this.Cmb_Veterinario.FocusedState.Parent = this.Cmb_Veterinario;
            this.Cmb_Veterinario.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Veterinario.ForeColor = System.Drawing.Color.White;
            this.Cmb_Veterinario.FormattingEnabled = true;
            this.Cmb_Veterinario.HoverState.Parent = this.Cmb_Veterinario;
            this.Cmb_Veterinario.ItemHeight = 30;
            this.Cmb_Veterinario.ItemsAppearance.Parent = this.Cmb_Veterinario;
            this.Cmb_Veterinario.Location = new System.Drawing.Point(541, 16);
            this.Cmb_Veterinario.Name = "Cmb_Veterinario";
            this.Cmb_Veterinario.ShadowDecoration.Parent = this.Cmb_Veterinario;
            this.Cmb_Veterinario.Size = new System.Drawing.Size(218, 36);
            this.Cmb_Veterinario.TabIndex = 8;
            // 
            // Fecha
            // 
            this.Fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.Fecha.BorderRadius = 10;
            this.Fecha.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.Fecha.ForeColor = System.Drawing.Color.White;
            this.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fecha.FormatCustom = "yyyy/MM/dd";
            this.Fecha.Location = new System.Drawing.Point(171, 112);
            this.Fecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(219, 32);
            this.Fecha.TabIndex = 7;
            this.Fecha.Value = new System.DateTime(2021, 5, 19, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.label3.Location = new System.Drawing.Point(167, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Notas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.label6.Location = new System.Drawing.Point(51, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.label2.Location = new System.Drawing.Point(51, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hora Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(51, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hora Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.label4.Location = new System.Drawing.Point(465, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Doctor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.label5.Location = new System.Drawing.Point(51, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cédula";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.label8.Location = new System.Drawing.Point(51, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cliente";
            // 
            // Txt_Notas
            // 
            this.Txt_Notas.BorderRadius = 10;
            this.Txt_Notas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Notas.DefaultText = "";
            this.Txt_Notas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_Notas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_Notas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Notas.DisabledState.Parent = this.Txt_Notas;
            this.Txt_Notas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Notas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.Txt_Notas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Notas.FocusedState.Parent = this.Txt_Notas;
            this.Txt_Notas.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Notas.ForeColor = System.Drawing.Color.White;
            this.Txt_Notas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Notas.HoverState.Parent = this.Txt_Notas;
            this.Txt_Notas.Location = new System.Drawing.Point(36, 272);
            this.Txt_Notas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Notas.Multiline = true;
            this.Txt_Notas.Name = "Txt_Notas";
            this.Txt_Notas.PasswordChar = '\0';
            this.Txt_Notas.PlaceholderText = "";
            this.Txt_Notas.SelectedText = "";
            this.Txt_Notas.ShadowDecoration.Parent = this.Txt_Notas;
            this.Txt_Notas.Size = new System.Drawing.Size(354, 91);
            this.Txt_Notas.TabIndex = 5;
            // 
            // Txt_Cedula
            // 
            this.Txt_Cedula.BorderRadius = 10;
            this.Txt_Cedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Cedula.DefaultText = "";
            this.Txt_Cedula.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_Cedula.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_Cedula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Cedula.DisabledState.Parent = this.Txt_Cedula;
            this.Txt_Cedula.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Cedula.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.Txt_Cedula.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Cedula.FocusedState.Parent = this.Txt_Cedula;
            this.Txt_Cedula.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cedula.ForeColor = System.Drawing.Color.White;
            this.Txt_Cedula.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Cedula.HoverState.Parent = this.Txt_Cedula;
            this.Txt_Cedula.Location = new System.Drawing.Point(171, 67);
            this.Txt_Cedula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Cedula.Name = "Txt_Cedula";
            this.Txt_Cedula.PasswordChar = '\0';
            this.Txt_Cedula.PlaceholderText = "";
            this.Txt_Cedula.SelectedText = "";
            this.Txt_Cedula.ShadowDecoration.Parent = this.Txt_Cedula;
            this.Txt_Cedula.Size = new System.Drawing.Size(219, 32);
            this.Txt_Cedula.TabIndex = 5;
            // 
            // Txt_Nombre_Cliente
            // 
            this.Txt_Nombre_Cliente.BorderRadius = 10;
            this.Txt_Nombre_Cliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Nombre_Cliente.DefaultText = "";
            this.Txt_Nombre_Cliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_Nombre_Cliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_Nombre_Cliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Nombre_Cliente.DisabledState.Parent = this.Txt_Nombre_Cliente;
            this.Txt_Nombre_Cliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Nombre_Cliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.Txt_Nombre_Cliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Nombre_Cliente.FocusedState.Parent = this.Txt_Nombre_Cliente;
            this.Txt_Nombre_Cliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre_Cliente.ForeColor = System.Drawing.Color.White;
            this.Txt_Nombre_Cliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Nombre_Cliente.HoverState.Parent = this.Txt_Nombre_Cliente;
            this.Txt_Nombre_Cliente.Location = new System.Drawing.Point(171, 16);
            this.Txt_Nombre_Cliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Nombre_Cliente.Name = "Txt_Nombre_Cliente";
            this.Txt_Nombre_Cliente.PasswordChar = '\0';
            this.Txt_Nombre_Cliente.PlaceholderText = "";
            this.Txt_Nombre_Cliente.SelectedText = "";
            this.Txt_Nombre_Cliente.ShadowDecoration.Parent = this.Txt_Nombre_Cliente;
            this.Txt_Nombre_Cliente.Size = new System.Drawing.Size(219, 32);
            this.Txt_Nombre_Cliente.TabIndex = 5;
            this.Txt_Nombre_Cliente.TextChanged += new System.EventHandler(this.Txt_Nombre_Cliente_TextChanged);
            // 
            // DTP_Hora_Final
            // 
            this.DTP_Hora_Final.CalendarFont = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold);
            this.DTP_Hora_Final.CalendarForeColor = System.Drawing.Color.Red;
            this.DTP_Hora_Final.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.DTP_Hora_Final.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.DTP_Hora_Final.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.DTP_Hora_Final.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.DTP_Hora_Final.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.DTP_Hora_Final.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTP_Hora_Final.Location = new System.Drawing.Point(219, 210);
            this.DTP_Hora_Final.Name = "DTP_Hora_Final";
            this.DTP_Hora_Final.ShowUpDown = true;
            this.DTP_Hora_Final.Size = new System.Drawing.Size(120, 21);
            this.DTP_Hora_Final.TabIndex = 25;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderRadius = 10;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.Enabled = false;
            this.guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox2.ForeColor = System.Drawing.Color.White;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Location = new System.Drawing.Point(171, 162);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(219, 32);
            this.guna2TextBox2.TabIndex = 5;
            this.guna2TextBox2.TextChanged += new System.EventHandler(this.Txt_Nombre_Cliente_TextChanged);
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.BorderRadius = 10;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.Enabled = false;
            this.guna2TextBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.FocusedState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox3.ForeColor = System.Drawing.Color.White;
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.HoverState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Location = new System.Drawing.Point(171, 204);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.ShadowDecoration.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Size = new System.Drawing.Size(219, 32);
            this.guna2TextBox3.TabIndex = 5;
            this.guna2TextBox3.TextChanged += new System.EventHandler(this.Txt_Nombre_Cliente_TextChanged);
            // 
            // FrmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 557);
            this.Controls.Add(this.Panel_base);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCitas";
            this.Text = "FrmCitas";
            this.Load += new System.EventHandler(this.FrmCitas_Load);
            this.Panel_base.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_base;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Nombre_Cliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Notas;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox Cmb_Veterinario;
        private Guna.UI2.WinForms.Guna2Button Btn_Agregar_Cita;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbPropietarios;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Cedula;
        private Bunifu.Framework.UI.BunifuDatepicker Fecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTP_Hora_Inicio;
        private System.Windows.Forms.DateTimePicker DTP_Hora_Final;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
    }
}