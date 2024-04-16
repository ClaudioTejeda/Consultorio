namespace Consultorio
{
    partial class BuscarPaciente
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
            this.dgBuscarPaciente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBfiltro = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuscarPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBuscarPaciente
            // 
            this.dgBuscarPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBuscarPaciente.Location = new System.Drawing.Point(25, 76);
            this.dgBuscarPaciente.Name = "dgBuscarPaciente";
            this.dgBuscarPaciente.Size = new System.Drawing.Size(533, 150);
            this.dgBuscarPaciente.TabIndex = 5;
            this.dgBuscarPaciente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBuscarMedico_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione un Medico";
            // 
            // checkBfiltro
            // 
            this.checkBfiltro.AutoSize = true;
            this.checkBfiltro.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBfiltro.Location = new System.Drawing.Point(25, 50);
            this.checkBfiltro.Name = "checkBfiltro";
            this.checkBfiltro.Size = new System.Drawing.Size(98, 20);
            this.checkBfiltro.TabIndex = 3;
            this.checkBfiltro.Text = "Filtrar Activos";
            this.checkBfiltro.UseVisualStyleBackColor = true;
            this.checkBfiltro.CheckedChanged += new System.EventHandler(this.checkBfiltro_CheckedChanged);
            // 
            // BuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.dgBuscarPaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBfiltro);
            this.Name = "BuscarPaciente";
            this.Text = "BuscarPaciente";
            this.Load += new System.EventHandler(this.BuscarPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBuscarPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBuscarPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBfiltro;
    }
}