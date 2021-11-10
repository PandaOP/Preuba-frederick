
namespace Arka
{
    partial class FrmMascotas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Agregar = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CMB_Sexo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Cmb_Raza = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_Tipo_Animal = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCedula = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtPropietario = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_Nombre_mascota = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_Persona = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Fecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Lbl_ = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbPropietarios = new System.Windows.Forms.ComboBox();
            this.tool_persona = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.Btn_Agregar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cmbPropietarios);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 557);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BorderRadius = 20;
            this.Btn_Agregar.CheckedState.Parent = this.Btn_Agregar;
            this.Btn_Agregar.CustomImages.Parent = this.Btn_Agregar;
            this.Btn_Agregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(151)))), ((int)(((byte)(142)))));
            this.Btn_Agregar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Agregar.ForeColor = System.Drawing.Color.White;
            this.Btn_Agregar.HoverState.Parent = this.Btn_Agregar;
            this.Btn_Agregar.Location = new System.Drawing.Point(295, 512);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.ShadowDecoration.Parent = this.Btn_Agregar;
            this.Btn_Agregar.Size = new System.Drawing.Size(163, 33);
            this.Btn_Agregar.TabIndex = 21;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.CMB_Sexo);
            this.panel3.Controls.Add(this.Cmb_Raza);
            this.panel3.Controls.Add(this.cmb_Tipo_Animal);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.TxtCedula);
            this.panel3.Controls.Add(this.TxtPropietario);
            this.panel3.Controls.Add(this.Txt_Nombre_mascota);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.Btn_Persona);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.Fecha);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.Lbl_);
            this.panel3.Location = new System.Drawing.Point(41, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(874, 396);
            this.panel3.TabIndex = 11;
            // 
            // CMB_Sexo
            // 
            this.CMB_Sexo.BackColor = System.Drawing.Color.Transparent;
            this.CMB_Sexo.BorderRadius = 10;
            this.CMB_Sexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMB_Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Sexo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.CMB_Sexo.FocusedColor = System.Drawing.Color.Empty;
            this.CMB_Sexo.FocusedState.Parent = this.CMB_Sexo;
            this.CMB_Sexo.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_Sexo.ForeColor = System.Drawing.Color.White;
            this.CMB_Sexo.FormattingEnabled = true;
            this.CMB_Sexo.HoverState.Parent = this.CMB_Sexo;
            this.CMB_Sexo.ItemHeight = 30;
            this.CMB_Sexo.ItemsAppearance.Parent = this.CMB_Sexo;
            this.CMB_Sexo.Location = new System.Drawing.Point(241, 227);
            this.CMB_Sexo.Name = "CMB_Sexo";
            this.CMB_Sexo.ShadowDecoration.Parent = this.CMB_Sexo;
            this.CMB_Sexo.Size = new System.Drawing.Size(207, 36);
            this.CMB_Sexo.TabIndex = 5;
            // 
            // Cmb_Raza
            // 
            this.Cmb_Raza.BackColor = System.Drawing.Color.Transparent;
            this.Cmb_Raza.BorderRadius = 10;
            this.Cmb_Raza.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_Raza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Raza.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.Cmb_Raza.FocusedColor = System.Drawing.Color.Empty;
            this.Cmb_Raza.FocusedState.Parent = this.Cmb_Raza;
            this.Cmb_Raza.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Raza.ForeColor = System.Drawing.Color.White;
            this.Cmb_Raza.FormattingEnabled = true;
            this.Cmb_Raza.HoverState.Parent = this.Cmb_Raza;
            this.Cmb_Raza.ItemHeight = 30;
            this.Cmb_Raza.ItemsAppearance.Parent = this.Cmb_Raza;
            this.Cmb_Raza.Location = new System.Drawing.Point(241, 77);
            this.Cmb_Raza.Name = "Cmb_Raza";
            this.Cmb_Raza.ShadowDecoration.Parent = this.Cmb_Raza;
            this.Cmb_Raza.Size = new System.Drawing.Size(207, 36);
            this.Cmb_Raza.TabIndex = 5;
            // 
            // cmb_Tipo_Animal
            // 
            this.cmb_Tipo_Animal.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Tipo_Animal.BorderRadius = 10;
            this.cmb_Tipo_Animal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Tipo_Animal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tipo_Animal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.cmb_Tipo_Animal.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_Tipo_Animal.FocusedState.Parent = this.cmb_Tipo_Animal;
            this.cmb_Tipo_Animal.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Tipo_Animal.ForeColor = System.Drawing.Color.White;
            this.cmb_Tipo_Animal.FormattingEnabled = true;
            this.cmb_Tipo_Animal.HoverState.Parent = this.cmb_Tipo_Animal;
            this.cmb_Tipo_Animal.ItemHeight = 30;
            this.cmb_Tipo_Animal.ItemsAppearance.Parent = this.cmb_Tipo_Animal;
            this.cmb_Tipo_Animal.Location = new System.Drawing.Point(241, 19);
            this.cmb_Tipo_Animal.Name = "cmb_Tipo_Animal";
            this.cmb_Tipo_Animal.ShadowDecoration.Parent = this.cmb_Tipo_Animal;
            this.cmb_Tipo_Animal.Size = new System.Drawing.Size(207, 36);
            this.cmb_Tipo_Animal.TabIndex = 5;
            this.cmb_Tipo_Animal.SelectedValueChanged += new System.EventHandler(this.cmb_Tipo_Animal_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.label6.Location = new System.Drawing.Point(46, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Especie Animal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.label7.Location = new System.Drawing.Point(47, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sexo";
            // 
            // TxtCedula
            // 
            this.TxtCedula.BorderRadius = 10;
            this.TxtCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCedula.DefaultText = "";
            this.TxtCedula.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCedula.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCedula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCedula.DisabledState.Parent = this.TxtCedula;
            this.TxtCedula.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCedula.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.TxtCedula.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCedula.FocusedState.Parent = this.TxtCedula;
            this.TxtCedula.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.TxtCedula.ForeColor = System.Drawing.Color.White;
            this.TxtCedula.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCedula.HoverState.Parent = this.TxtCedula;
            this.TxtCedula.Location = new System.Drawing.Point(241, 339);
            this.TxtCedula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.PasswordChar = '\0';
            this.TxtCedula.PlaceholderText = "";
            this.TxtCedula.SelectedText = "";
            this.TxtCedula.ShadowDecoration.Parent = this.TxtCedula;
            this.TxtCedula.Size = new System.Drawing.Size(207, 32);
            this.TxtCedula.TabIndex = 4;
            // 
            // TxtPropietario
            // 
            this.TxtPropietario.BorderRadius = 10;
            this.TxtPropietario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPropietario.DefaultText = "";
            this.TxtPropietario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPropietario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPropietario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPropietario.DisabledState.Parent = this.TxtPropietario;
            this.TxtPropietario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPropietario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.TxtPropietario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPropietario.FocusedState.Parent = this.TxtPropietario;
            this.TxtPropietario.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.TxtPropietario.ForeColor = System.Drawing.Color.White;
            this.TxtPropietario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPropietario.HoverState.Parent = this.TxtPropietario;
            this.TxtPropietario.Location = new System.Drawing.Point(241, 289);
            this.TxtPropietario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPropietario.Name = "TxtPropietario";
            this.TxtPropietario.PasswordChar = '\0';
            this.TxtPropietario.PlaceholderText = "";
            this.TxtPropietario.SelectedText = "";
            this.TxtPropietario.ShadowDecoration.Parent = this.TxtPropietario;
            this.TxtPropietario.Size = new System.Drawing.Size(207, 32);
            this.TxtPropietario.TabIndex = 4;
            this.TxtPropietario.TextChanged += new System.EventHandler(this.TxtPropietario_TextChanged);
            this.TxtPropietario.Leave += new System.EventHandler(this.TxtPropietario_Leave);
            // 
            // Txt_Nombre_mascota
            // 
            this.Txt_Nombre_mascota.BorderRadius = 10;
            this.Txt_Nombre_mascota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Nombre_mascota.DefaultText = "";
            this.Txt_Nombre_mascota.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_Nombre_mascota.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_Nombre_mascota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Nombre_mascota.DisabledState.Parent = this.Txt_Nombre_mascota;
            this.Txt_Nombre_mascota.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Nombre_mascota.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.Txt_Nombre_mascota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Nombre_mascota.FocusedState.Parent = this.Txt_Nombre_mascota;
            this.Txt_Nombre_mascota.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.Txt_Nombre_mascota.ForeColor = System.Drawing.Color.White;
            this.Txt_Nombre_mascota.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Nombre_mascota.HoverState.Parent = this.Txt_Nombre_mascota;
            this.Txt_Nombre_mascota.Location = new System.Drawing.Point(241, 130);
            this.Txt_Nombre_mascota.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Nombre_mascota.Name = "Txt_Nombre_mascota";
            this.Txt_Nombre_mascota.PasswordChar = '\0';
            this.Txt_Nombre_mascota.PlaceholderText = "";
            this.Txt_Nombre_mascota.SelectedText = "";
            this.Txt_Nombre_mascota.ShadowDecoration.Parent = this.Txt_Nombre_mascota;
            this.Txt_Nombre_mascota.Size = new System.Drawing.Size(207, 32);
            this.Txt_Nombre_mascota.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.label9.Location = new System.Drawing.Point(46, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Cédula";
            // 
            // Btn_Persona
            // 
            this.Btn_Persona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Persona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(144)))), ((int)(((byte)(132)))));
            this.Btn_Persona.Location = new System.Drawing.Point(455, 296);
            this.Btn_Persona.Name = "Btn_Persona";
            this.Btn_Persona.Size = new System.Drawing.Size(61, 25);
            this.Btn_Persona.TabIndex = 4;
            this.Btn_Persona.Text = "...";
            this.tool_persona.SetToolTip(this.Btn_Persona, "Agregar Persona");
            this.Btn_Persona.UseVisualStyleBackColor = false;
            this.Btn_Persona.Click += new System.EventHandler(this.Btn_Persona_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.label8.Location = new System.Drawing.Point(46, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Propietario";
            // 
            // Fecha
            // 
            this.Fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.Fecha.BorderRadius = 10;
            this.Fecha.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.Fecha.ForeColor = System.Drawing.Color.White;
            this.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fecha.FormatCustom = "yyyy/MM/dd";
            this.Fecha.Location = new System.Drawing.Point(241, 178);
            this.Fecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(207, 32);
            this.Fecha.TabIndex = 2;
            this.Fecha.Value = new System.DateTime(2021, 5, 19, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.label10.Location = new System.Drawing.Point(48, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "Raza";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.label11.Location = new System.Drawing.Point(47, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 24);
            this.label11.TabIndex = 3;
            this.label11.Text = "Edad";
            // 
            // Lbl_
            // 
            this.Lbl_.AutoSize = true;
            this.Lbl_.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.Lbl_.Location = new System.Drawing.Point(46, 138);
            this.Lbl_.Name = "Lbl_";
            this.Lbl_.Size = new System.Drawing.Size(157, 24);
            this.Lbl_.TabIndex = 3;
            this.Lbl_.Text = "Nombre Mascota";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Location = new System.Drawing.Point(30, 506);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(63, 51);
            this.panel2.TabIndex = 7;
            // 
            // cmbPropietarios
            // 
            this.cmbPropietarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPropietarios.FormattingEnabled = true;
            this.cmbPropietarios.Location = new System.Drawing.Point(42, 524);
            this.cmbPropietarios.Name = "cmbPropietarios";
            this.cmbPropietarios.Size = new System.Drawing.Size(10, 21);
            this.cmbPropietarios.TabIndex = 5;
            this.cmbPropietarios.TextChanged += new System.EventHandler(this.cmbPropietarios_TextChanged);
            // 
            // FrmMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(950, 557);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMascotas";
            this.Text = "FrmMascotas";
            this.Load += new System.EventHandler(this.FrmMascotas_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDatepicker Fecha;
        private System.Windows.Forms.Button Btn_Persona;
        private System.Windows.Forms.ToolTip tool_persona;
        private System.Windows.Forms.ComboBox cmbPropietarios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ComboBox CMB_Sexo;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_Tipo_Animal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox TxtCedula;
        private Guna.UI2.WinForms.Guna2TextBox TxtPropietario;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Nombre_mascota;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Lbl_;
        private Guna.UI2.WinForms.Guna2ComboBox Cmb_Raza;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Button Btn_Agregar;
    }
}