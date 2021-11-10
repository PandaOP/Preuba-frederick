
namespace Arka
{
    partial class FrmConsulta
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
            this.panel_Formulario = new System.Windows.Forms.Panel();
            this.Fecha_Consulta = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_persona = new System.Windows.Forms.Button();
            this.Btn_Agregar_Consulta = new System.Windows.Forms.Button();
            this.Txt_Nombre_Animal = new System.Windows.Forms.TextBox();
            this.Txt_descripcion_consulta = new System.Windows.Forms.TextBox();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.TxtTemperatura = new System.Windows.Forms.TextBox();
            this.Txt_Cliente = new System.Windows.Forms.TextBox();
            this.Cmb_mascotas = new System.Windows.Forms.ComboBox();
            this.txtestado = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.Cmb_Enfermedades = new System.Windows.Forms.ComboBox();
            this.Cmb_Veterinario = new System.Windows.Forms.ComboBox();
            this.panel_Formulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Formulario
            // 
            this.panel_Formulario.BackColor = System.Drawing.Color.Transparent;
            this.panel_Formulario.Controls.Add(this.Fecha_Consulta);
            this.panel_Formulario.Controls.Add(this.label4);
            this.panel_Formulario.Controls.Add(this.label6);
            this.panel_Formulario.Controls.Add(this.label3);
            this.panel_Formulario.Controls.Add(this.label5);
            this.panel_Formulario.Controls.Add(this.label9);
            this.panel_Formulario.Controls.Add(this.label10);
            this.panel_Formulario.Controls.Add(this.label8);
            this.panel_Formulario.Controls.Add(this.label2);
            this.panel_Formulario.Controls.Add(this.label1);
            this.panel_Formulario.Controls.Add(this.Btn_persona);
            this.panel_Formulario.Controls.Add(this.Btn_Agregar_Consulta);
            this.panel_Formulario.Controls.Add(this.Txt_Nombre_Animal);
            this.panel_Formulario.Controls.Add(this.Txt_descripcion_consulta);
            this.panel_Formulario.Controls.Add(this.TxtPeso);
            this.panel_Formulario.Controls.Add(this.TxtTemperatura);
            this.panel_Formulario.Controls.Add(this.Txt_Cliente);
            this.panel_Formulario.Controls.Add(this.Cmb_mascotas);
            this.panel_Formulario.Controls.Add(this.txtestado);
            this.panel_Formulario.Controls.Add(this.cmbCliente);
            this.panel_Formulario.Controls.Add(this.Cmb_Enfermedades);
            this.panel_Formulario.Controls.Add(this.Cmb_Veterinario);
            this.panel_Formulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Formulario.Location = new System.Drawing.Point(0, 0);
            this.panel_Formulario.Name = "panel_Formulario";
            this.panel_Formulario.Size = new System.Drawing.Size(800, 450);
            this.panel_Formulario.TabIndex = 0;
            // 
            // Fecha_Consulta
            // 
            this.Fecha_Consulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Fecha_Consulta.BorderRadius = 0;
            this.Fecha_Consulta.ForeColor = System.Drawing.Color.White;
            this.Fecha_Consulta.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Fecha_Consulta.FormatCustom = null;
            this.Fecha_Consulta.Location = new System.Drawing.Point(63, 140);
            this.Fecha_Consulta.Name = "Fecha_Consulta";
            this.Fecha_Consulta.Size = new System.Drawing.Size(179, 36);
            this.Fecha_Consulta.TabIndex = 5;
            this.Fecha_Consulta.Value = new System.DateTime(2021, 5, 21, 0, 51, 50, 735);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(81)))), ((int)(((byte)(69)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(546, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre del animal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(81)))), ((int)(((byte)(69)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(311, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Descripcion de la consulta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(81)))), ((int)(((byte)(69)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(112, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(81)))), ((int)(((byte)(69)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(567, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enfermedad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(81)))), ((int)(((byte)(69)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(371, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Peso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(81)))), ((int)(((byte)(69)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(112, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Fecha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(81)))), ((int)(((byte)(69)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(350, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(81)))), ((int)(((byte)(69)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(586, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(81)))), ((int)(((byte)(69)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Veterinario";
            // 
            // Btn_persona
            // 
            this.Btn_persona.Location = new System.Drawing.Point(713, 49);
            this.Btn_persona.Name = "Btn_persona";
            this.Btn_persona.Size = new System.Drawing.Size(38, 20);
            this.Btn_persona.TabIndex = 3;
            this.Btn_persona.Text = "...";
            this.Btn_persona.UseVisualStyleBackColor = true;
            // 
            // Btn_Agregar_Consulta
            // 
            this.Btn_Agregar_Consulta.Location = new System.Drawing.Point(345, 408);
            this.Btn_Agregar_Consulta.Name = "Btn_Agregar_Consulta";
            this.Btn_Agregar_Consulta.Size = new System.Drawing.Size(75, 23);
            this.Btn_Agregar_Consulta.TabIndex = 3;
            this.Btn_Agregar_Consulta.Text = "Agregar";
            this.Btn_Agregar_Consulta.UseVisualStyleBackColor = true;
            this.Btn_Agregar_Consulta.Click += new System.EventHandler(this.Btn_Agregar_Consulta_Click);
            // 
            // Txt_Nombre_Animal
            // 
            this.Txt_Nombre_Animal.Location = new System.Drawing.Point(526, 140);
            this.Txt_Nombre_Animal.Name = "Txt_Nombre_Animal";
            this.Txt_Nombre_Animal.Size = new System.Drawing.Size(181, 20);
            this.Txt_Nombre_Animal.TabIndex = 2;
            this.Txt_Nombre_Animal.TextChanged += new System.EventHandler(this.Txt_Nombre_Animal_TextChanged);
            this.Txt_Nombre_Animal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombre_Animal_KeyPress);
            // 
            // Txt_descripcion_consulta
            // 
            this.Txt_descripcion_consulta.Location = new System.Drawing.Point(216, 295);
            this.Txt_descripcion_consulta.Multiline = true;
            this.Txt_descripcion_consulta.Name = "Txt_descripcion_consulta";
            this.Txt_descripcion_consulta.Size = new System.Drawing.Size(353, 80);
            this.Txt_descripcion_consulta.TabIndex = 2;
            this.Txt_descripcion_consulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_descripcion_consulta_KeyPress);
            // 
            // TxtPeso
            // 
            this.TxtPeso.Location = new System.Drawing.Point(353, 98);
            this.TxtPeso.MaxLength = 20;
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(81, 20);
            this.TxtPeso.TabIndex = 2;
            this.TxtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPeso_KeyPress);
            // 
            // TxtTemperatura
            // 
            this.TxtTemperatura.Location = new System.Drawing.Point(345, 193);
            this.TxtTemperatura.MaxLength = 20;
            this.TxtTemperatura.Name = "TxtTemperatura";
            this.TxtTemperatura.Size = new System.Drawing.Size(89, 20);
            this.TxtTemperatura.TabIndex = 2;
            this.TxtTemperatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTemperatura_KeyPress);
            // 
            // Txt_Cliente
            // 
            this.Txt_Cliente.Location = new System.Drawing.Point(526, 51);
            this.Txt_Cliente.Name = "Txt_Cliente";
            this.Txt_Cliente.Size = new System.Drawing.Size(176, 20);
            this.Txt_Cliente.TabIndex = 2;
            this.Txt_Cliente.TextChanged += new System.EventHandler(this.Txt_Cliente_TextChanged);
            this.Txt_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cliente_KeyPress);
            // 
            // Cmb_mascotas
            // 
            this.Cmb_mascotas.FormattingEnabled = true;
            this.Cmb_mascotas.Location = new System.Drawing.Point(681, 408);
            this.Cmb_mascotas.Name = "Cmb_mascotas";
            this.Cmb_mascotas.Size = new System.Drawing.Size(63, 21);
            this.Cmb_mascotas.TabIndex = 1;
            this.Cmb_mascotas.Visible = false;
            // 
            // txtestado
            // 
            this.txtestado.FormattingEnabled = true;
            this.txtestado.Items.AddRange(new object[] {
            "saludable",
            "enfermo",
            "observacion",
            "muerto"});
            this.txtestado.Location = new System.Drawing.Point(71, 216);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(181, 21);
            this.txtestado.TabIndex = 1;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(681, 381);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(63, 21);
            this.cmbCliente.TabIndex = 1;
            this.cmbCliente.Visible = false;
            // 
            // Cmb_Enfermedades
            // 
            this.Cmb_Enfermedades.FormattingEnabled = true;
            this.Cmb_Enfermedades.Location = new System.Drawing.Point(526, 216);
            this.Cmb_Enfermedades.Name = "Cmb_Enfermedades";
            this.Cmb_Enfermedades.Size = new System.Drawing.Size(181, 21);
            this.Cmb_Enfermedades.TabIndex = 1;
            // 
            // Cmb_Veterinario
            // 
            this.Cmb_Veterinario.FormattingEnabled = true;
            this.Cmb_Veterinario.Location = new System.Drawing.Point(63, 50);
            this.Cmb_Veterinario.Name = "Cmb_Veterinario";
            this.Cmb_Veterinario.Size = new System.Drawing.Size(176, 21);
            this.Cmb_Veterinario.TabIndex = 0;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_Formulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsulta";
            this.Text = "FrmConsulta";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            this.panel_Formulario.ResumeLayout(false);
            this.panel_Formulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Formulario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Agregar_Consulta;
        private System.Windows.Forms.TextBox Txt_Nombre_Animal;
        private System.Windows.Forms.TextBox Txt_descripcion_consulta;
        private System.Windows.Forms.TextBox Txt_Cliente;
        private System.Windows.Forms.ComboBox Cmb_Enfermedades;
        private System.Windows.Forms.ComboBox Cmb_Veterinario;
        private System.Windows.Forms.Panel panel_Grid;
        private System.Windows.Forms.DataGridView DGV_Historial;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDatepicker Fecha_Consulta;
        private System.Windows.Forms.Button Btn_persona;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox Cmb_mascotas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.TextBox TxtTemperatura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtestado;
        private System.Windows.Forms.Label label10;
    }
}