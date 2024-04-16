namespace Consultorio
{
    partial class PCitas
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
            this.dgPacientes = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.checkBFiltro = new System.Windows.Forms.CheckBox();
            this.checkBEstado = new System.Windows.Forms.CheckBox();
            this.dateTimeFechaingreso = new System.Windows.Forms.DateTimePicker();
            this.txtCitaId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscarMedico = new System.Windows.Forms.Button();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.idmedico = new System.Windows.Forms.TextBox();
            this.idpaciente = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPacientes
            // 
            this.dgPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPacientes.Location = new System.Drawing.Point(78, 252);
            this.dgPacientes.Name = "dgPacientes";
            this.dgPacientes.Size = new System.Drawing.Size(593, 150);
            this.dgPacientes.TabIndex = 44;
            this.dgPacientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPacientes_CellDoubleClick);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(389, 212);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 43;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(277, 212);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 42;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // checkBFiltro
            // 
            this.checkBFiltro.AutoSize = true;
            this.checkBFiltro.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBFiltro.Location = new System.Drawing.Point(93, 212);
            this.checkBFiltro.Name = "checkBFiltro";
            this.checkBFiltro.Size = new System.Drawing.Size(121, 23);
            this.checkBFiltro.TabIndex = 41;
            this.checkBFiltro.Text = "Filtrar Activos";
            this.checkBFiltro.UseVisualStyleBackColor = true;
            this.checkBFiltro.CheckedChanged += new System.EventHandler(this.checkBFiltro_CheckedChanged);
            // 
            // checkBEstado
            // 
            this.checkBEstado.AutoSize = true;
            this.checkBEstado.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBEstado.Location = new System.Drawing.Point(242, 153);
            this.checkBEstado.Name = "checkBEstado";
            this.checkBEstado.Size = new System.Drawing.Size(65, 21);
            this.checkBEstado.TabIndex = 40;
            this.checkBEstado.Text = "Activa";
            this.checkBEstado.UseVisualStyleBackColor = true;
            // 
            // dateTimeFechaingreso
            // 
            this.dateTimeFechaingreso.Location = new System.Drawing.Point(478, 117);
            this.dateTimeFechaingreso.Name = "dateTimeFechaingreso";
            this.dateTimeFechaingreso.Size = new System.Drawing.Size(193, 20);
            this.dateTimeFechaingreso.TabIndex = 39;
            // 
            // txtCitaId
            // 
            this.txtCitaId.Enabled = false;
            this.txtCitaId.Location = new System.Drawing.Point(242, 55);
            this.txtCitaId.Name = "txtCitaId";
            this.txtCitaId.ReadOnly = true;
            this.txtCitaId.Size = new System.Drawing.Size(110, 20);
            this.txtCitaId.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Estado Cita";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(383, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Fecha Cita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Busque un Paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Busque un Medico";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab2.Location = new System.Drawing.Point(76, 58);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(56, 18);
            this.lab2.TabIndex = 31;
            this.lab2.Text = "Cita ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Gestion de Citas";
            // 
            // btnbuscarMedico
            // 
            this.btnbuscarMedico.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarMedico.Location = new System.Drawing.Point(242, 87);
            this.btnbuscarMedico.Name = "btnbuscarMedico";
            this.btnbuscarMedico.Size = new System.Drawing.Size(110, 22);
            this.btnbuscarMedico.TabIndex = 45;
            this.btnbuscarMedico.Text = "Buscar";
            this.btnbuscarMedico.UseVisualStyleBackColor = true;
            this.btnbuscarMedico.Click += new System.EventHandler(this.btnbuscarMedico_Click);
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPaciente.Location = new System.Drawing.Point(242, 115);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(110, 22);
            this.btnBuscarPaciente.TabIndex = 46;
            this.btnBuscarPaciente.Text = "Buscar";
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 47;
            this.label2.Text = "Medico";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(383, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 48;
            this.label7.Text = "Paciente";
            // 
            // txtMedico
            // 
            this.txtMedico.Enabled = false;
            this.txtMedico.Location = new System.Drawing.Point(478, 55);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.ReadOnly = true;
            this.txtMedico.Size = new System.Drawing.Size(193, 20);
            this.txtMedico.TabIndex = 49;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Enabled = false;
            this.txtPaciente.Location = new System.Drawing.Point(478, 84);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(193, 20);
            this.txtPaciente.TabIndex = 50;
            // 
            // idmedico
            // 
            this.idmedico.Enabled = false;
            this.idmedico.Location = new System.Drawing.Point(463, 22);
            this.idmedico.Name = "idmedico";
            this.idmedico.ReadOnly = true;
            this.idmedico.Size = new System.Drawing.Size(57, 20);
            this.idmedico.TabIndex = 51;
            this.idmedico.Visible = false;
            // 
            // idpaciente
            // 
            this.idpaciente.Enabled = false;
            this.idpaciente.Location = new System.Drawing.Point(526, 22);
            this.idpaciente.Name = "idpaciente";
            this.idpaciente.ReadOnly = true;
            this.idpaciente.Size = new System.Drawing.Size(57, 20);
            this.idpaciente.TabIndex = 52;
            this.idpaciente.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idpaciente);
            this.Controls.Add(this.idmedico);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.txtMedico);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.btnbuscarMedico);
            this.Controls.Add(this.dgPacientes);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.checkBFiltro);
            this.Controls.Add(this.checkBEstado);
            this.Controls.Add(this.dateTimeFechaingreso);
            this.Controls.Add(this.txtCitaId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.label1);
            this.Name = "PCitas";
            this.Text = "PCitas";
            this.Load += new System.EventHandler(this.PCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPacientes;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.CheckBox checkBFiltro;
        private System.Windows.Forms.CheckBox checkBEstado;
        private System.Windows.Forms.DateTimePicker dateTimeFechaingreso;
        private System.Windows.Forms.TextBox txtCitaId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbuscarMedico;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.TextBox idmedico;
        private System.Windows.Forms.TextBox idpaciente;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}