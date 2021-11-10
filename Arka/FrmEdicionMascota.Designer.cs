
namespace Arka
{
    partial class FrmEdicionMascota
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
            this.lbl_ID_Mascota = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.Solucion = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Eliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_guardar = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Editar = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CmbSexo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CmbEstado_mascota = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CmbPropietario = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CmbRaza = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Cmb_tipo_animal = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Nombre_Mascota = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_Persona = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.DTP_edad = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Lbl_ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Solucion)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ID_Mascota
            // 
            this.lbl_ID_Mascota.AutoSize = true;
            this.lbl_ID_Mascota.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_ID_Mascota.Location = new System.Drawing.Point(68, 42);
            this.lbl_ID_Mascota.Name = "lbl_ID_Mascota";
            this.lbl_ID_Mascota.Size = new System.Drawing.Size(123, 24);
            this.lbl_ID_Mascota.TabIndex = 0;
            this.lbl_ID_Mascota.Text = "ID MASCOTA:";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Id.Location = new System.Drawing.Point(191, 42);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(24, 24);
            this.lbl_Id.TabIndex = 1;
            this.lbl_Id.Text = "--";
            // 
            // Solucion
            // 
            this.Solucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Solucion.Location = new System.Drawing.Point(32, 471);
            this.Solucion.Name = "Solucion";
            this.Solucion.Size = new System.Drawing.Size(22, 13);
            this.Solucion.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.Solucion);
            this.panel1.Controls.Add(this.Btn_Eliminar);
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Controls.Add(this.Btn_Editar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbl_Id);
            this.panel1.Controls.Add(this.lbl_ID_Mascota);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 518);
            this.panel1.TabIndex = 22;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BorderRadius = 20;
            this.Btn_Eliminar.CheckedState.Parent = this.Btn_Eliminar;
            this.Btn_Eliminar.CustomImages.Parent = this.Btn_Eliminar;
            this.Btn_Eliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.Btn_Eliminar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_Eliminar.HoverState.Parent = this.Btn_Eliminar;
            this.Btn_Eliminar.Location = new System.Drawing.Point(381, 471);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.ShadowDecoration.Parent = this.Btn_Eliminar;
            this.Btn_Eliminar.Size = new System.Drawing.Size(118, 33);
            this.Btn_Eliminar.TabIndex = 21;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click_1);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BorderRadius = 20;
            this.btn_guardar.CheckedState.Parent = this.btn_guardar;
            this.btn_guardar.CustomImages.Parent = this.btn_guardar;
            this.btn_guardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(151)))), ((int)(((byte)(142)))));
            this.btn_guardar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.HoverState.Parent = this.btn_guardar;
            this.btn_guardar.Location = new System.Drawing.Point(246, 471);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.ShadowDecoration.Parent = this.btn_guardar;
            this.btn_guardar.Size = new System.Drawing.Size(123, 33);
            this.btn_guardar.TabIndex = 21;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click_1);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BorderRadius = 20;
            this.Btn_Editar.CheckedState.Parent = this.Btn_Editar;
            this.Btn_Editar.CustomImages.Parent = this.Btn_Editar;
            this.Btn_Editar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(161)))), ((int)(((byte)(188)))));
            this.Btn_Editar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Editar.ForeColor = System.Drawing.Color.White;
            this.Btn_Editar.HoverState.Parent = this.Btn_Editar;
            this.Btn_Editar.Location = new System.Drawing.Point(116, 471);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.ShadowDecoration.Parent = this.Btn_Editar;
            this.Btn_Editar.Size = new System.Drawing.Size(119, 33);
            this.Btn_Editar.TabIndex = 21;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.CmbSexo);
            this.panel3.Controls.Add(this.CmbEstado_mascota);
            this.panel3.Controls.Add(this.CmbPropietario);
            this.panel3.Controls.Add(this.CmbRaza);
            this.panel3.Controls.Add(this.Cmb_tipo_animal);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.Txt_Nombre_Mascota);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.Btn_Persona);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.DTP_edad);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.Lbl_);
            this.panel3.Location = new System.Drawing.Point(32, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(874, 396);
            this.panel3.TabIndex = 11;
            // 
            // CmbSexo
            // 
            this.CmbSexo.BackColor = System.Drawing.Color.Transparent;
            this.CmbSexo.BorderRadius = 10;
            this.CmbSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSexo.Enabled = false;
            this.CmbSexo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.CmbSexo.FocusedColor = System.Drawing.Color.Empty;
            this.CmbSexo.FocusedState.Parent = this.CmbSexo;
            this.CmbSexo.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSexo.ForeColor = System.Drawing.Color.White;
            this.CmbSexo.HoverState.Parent = this.CmbSexo;
            this.CmbSexo.ItemHeight = 30;
            this.CmbSexo.Items.AddRange(new object[] {
            "Macho",
            "Hembra"});
            this.CmbSexo.ItemsAppearance.Parent = this.CmbSexo;
            this.CmbSexo.Location = new System.Drawing.Point(241, 229);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.ShadowDecoration.Parent = this.CmbSexo;
            this.CmbSexo.Size = new System.Drawing.Size(207, 36);
            this.CmbSexo.TabIndex = 11;
            // 
            // CmbEstado_mascota
            // 
            this.CmbEstado_mascota.BackColor = System.Drawing.Color.Transparent;
            this.CmbEstado_mascota.BorderRadius = 10;
            this.CmbEstado_mascota.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbEstado_mascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstado_mascota.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.CmbEstado_mascota.FocusedColor = System.Drawing.Color.Empty;
            this.CmbEstado_mascota.FocusedState.Parent = this.CmbEstado_mascota;
            this.CmbEstado_mascota.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEstado_mascota.ForeColor = System.Drawing.Color.White;
            this.CmbEstado_mascota.HoverState.Parent = this.CmbEstado_mascota;
            this.CmbEstado_mascota.ItemHeight = 30;
            this.CmbEstado_mascota.ItemsAppearance.Parent = this.CmbEstado_mascota;
            this.CmbEstado_mascota.Location = new System.Drawing.Point(240, 341);
            this.CmbEstado_mascota.Name = "CmbEstado_mascota";
            this.CmbEstado_mascota.ShadowDecoration.Parent = this.CmbEstado_mascota;
            this.CmbEstado_mascota.Size = new System.Drawing.Size(207, 36);
            this.CmbEstado_mascota.TabIndex = 10;
            // 
            // CmbPropietario
            // 
            this.CmbPropietario.BackColor = System.Drawing.Color.Transparent;
            this.CmbPropietario.BorderRadius = 10;
            this.CmbPropietario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbPropietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPropietario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.CmbPropietario.FocusedColor = System.Drawing.Color.Empty;
            this.CmbPropietario.FocusedState.Parent = this.CmbPropietario;
            this.CmbPropietario.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPropietario.ForeColor = System.Drawing.Color.White;
            this.CmbPropietario.HoverState.Parent = this.CmbPropietario;
            this.CmbPropietario.ItemHeight = 30;
            this.CmbPropietario.ItemsAppearance.Parent = this.CmbPropietario;
            this.CmbPropietario.Location = new System.Drawing.Point(240, 289);
            this.CmbPropietario.Name = "CmbPropietario";
            this.CmbPropietario.ShadowDecoration.Parent = this.CmbPropietario;
            this.CmbPropietario.Size = new System.Drawing.Size(207, 36);
            this.CmbPropietario.TabIndex = 9;
            // 
            // CmbRaza
            // 
            this.CmbRaza.BackColor = System.Drawing.Color.Transparent;
            this.CmbRaza.BorderRadius = 10;
            this.CmbRaza.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbRaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRaza.Enabled = false;
            this.CmbRaza.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.CmbRaza.FocusedColor = System.Drawing.Color.Empty;
            this.CmbRaza.FocusedState.Parent = this.CmbRaza;
            this.CmbRaza.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbRaza.ForeColor = System.Drawing.Color.White;
            this.CmbRaza.HoverState.Parent = this.CmbRaza;
            this.CmbRaza.ItemHeight = 30;
            this.CmbRaza.ItemsAppearance.Parent = this.CmbRaza;
            this.CmbRaza.Location = new System.Drawing.Point(241, 79);
            this.CmbRaza.Name = "CmbRaza";
            this.CmbRaza.ShadowDecoration.Parent = this.CmbRaza;
            this.CmbRaza.Size = new System.Drawing.Size(207, 36);
            this.CmbRaza.TabIndex = 7;
            // 
            // Cmb_tipo_animal
            // 
            this.Cmb_tipo_animal.BackColor = System.Drawing.Color.Transparent;
            this.Cmb_tipo_animal.BorderRadius = 10;
            this.Cmb_tipo_animal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_tipo_animal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_tipo_animal.Enabled = false;
            this.Cmb_tipo_animal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.Cmb_tipo_animal.FocusedColor = System.Drawing.Color.Empty;
            this.Cmb_tipo_animal.FocusedState.Parent = this.Cmb_tipo_animal;
            this.Cmb_tipo_animal.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_tipo_animal.ForeColor = System.Drawing.Color.White;
            this.Cmb_tipo_animal.HoverState.Parent = this.Cmb_tipo_animal;
            this.Cmb_tipo_animal.ItemHeight = 30;
            this.Cmb_tipo_animal.ItemsAppearance.Parent = this.Cmb_tipo_animal;
            this.Cmb_tipo_animal.Location = new System.Drawing.Point(241, 19);
            this.Cmb_tipo_animal.Name = "Cmb_tipo_animal";
            this.Cmb_tipo_animal.ShadowDecoration.Parent = this.Cmb_tipo_animal;
            this.Cmb_tipo_animal.Size = new System.Drawing.Size(207, 36);
            this.Cmb_tipo_animal.TabIndex = 6;
            this.Cmb_tipo_animal.SelectedValueChanged += new System.EventHandler(this.CmbTipo_Animal_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.label6.Location = new System.Drawing.Point(46, 19);
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
            this.label7.Location = new System.Drawing.Point(47, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sexo";
            // 
            // Txt_Nombre_Mascota
            // 
            this.Txt_Nombre_Mascota.BorderRadius = 10;
            this.Txt_Nombre_Mascota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Nombre_Mascota.DefaultText = "";
            this.Txt_Nombre_Mascota.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_Nombre_Mascota.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_Nombre_Mascota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Nombre_Mascota.DisabledState.Parent = this.Txt_Nombre_Mascota;
            this.Txt_Nombre_Mascota.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Nombre_Mascota.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.Txt_Nombre_Mascota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Nombre_Mascota.FocusedState.Parent = this.Txt_Nombre_Mascota;
            this.Txt_Nombre_Mascota.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.Txt_Nombre_Mascota.ForeColor = System.Drawing.Color.White;
            this.Txt_Nombre_Mascota.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Nombre_Mascota.HoverState.Parent = this.Txt_Nombre_Mascota;
            this.Txt_Nombre_Mascota.Location = new System.Drawing.Point(241, 130);
            this.Txt_Nombre_Mascota.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Nombre_Mascota.Name = "Txt_Nombre_Mascota";
            this.Txt_Nombre_Mascota.PasswordChar = '\0';
            this.Txt_Nombre_Mascota.PlaceholderText = "";
            this.Txt_Nombre_Mascota.SelectedText = "";
            this.Txt_Nombre_Mascota.ShadowDecoration.Parent = this.Txt_Nombre_Mascota;
            this.Txt_Nombre_Mascota.Size = new System.Drawing.Size(207, 32);
            this.Txt_Nombre_Mascota.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.label9.Location = new System.Drawing.Point(47, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Estado";
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
            this.Btn_Persona.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.label8.Location = new System.Drawing.Point(46, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Propietario";
            // 
            // DTP_edad
            // 
            this.DTP_edad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.DTP_edad.BorderRadius = 10;
            this.DTP_edad.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.DTP_edad.ForeColor = System.Drawing.Color.White;
            this.DTP_edad.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_edad.FormatCustom = "yyyy/MM/dd";
            this.DTP_edad.Location = new System.Drawing.Point(241, 178);
            this.DTP_edad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTP_edad.Name = "DTP_edad";
            this.DTP_edad.Size = new System.Drawing.Size(207, 32);
            this.DTP_edad.TabIndex = 2;
            this.DTP_edad.Value = new System.DateTime(2021, 5, 19, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.label10.Location = new System.Drawing.Point(47, 77);
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
            this.label11.Location = new System.Drawing.Point(47, 178);
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
            this.Lbl_.Location = new System.Drawing.Point(46, 130);
            this.Lbl_.Name = "Lbl_";
            this.Lbl_.Size = new System.Drawing.Size(157, 24);
            this.Lbl_.TabIndex = 3;
            this.Lbl_.Text = "Nombre Mascota";
            // 
            // FrmEdicionMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 518);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEdicionMascota";
            this.Text = "FrmEdicionMascota";
            this.Load += new System.EventHandler(this.FrmEdicionMascota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Solucion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_ID_Mascota;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.DataGridView Solucion;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button Btn_Editar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Nombre_Mascota;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Btn_Persona;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuDatepicker DTP_edad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Lbl_;
        private Guna.UI2.WinForms.Guna2Button btn_guardar;
        private Guna.UI2.WinForms.Guna2Button Btn_Eliminar;
        private Guna.UI2.WinForms.Guna2ComboBox Cmb_tipo_animal;
        private Guna.UI2.WinForms.Guna2ComboBox CmbRaza;
        private Guna.UI2.WinForms.Guna2ComboBox CmbEstado_mascota;
        private Guna.UI2.WinForms.Guna2ComboBox CmbPropietario;
        private Guna.UI2.WinForms.Guna2ComboBox CmbSexo;
    }
}