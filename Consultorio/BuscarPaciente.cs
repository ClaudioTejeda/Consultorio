using CapaDatos.BasedeDatos.Modelos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class BuscarPaciente : Form
    {
        NPacientes nPacientes;
        public string PacienteId { get; set; }
        public string Nombre_Completo { get; set; }
        public string FechaIngreso { get; set; }
        public string Estado { get; set; }
        public BuscarPaciente()
        {
            InitializeComponent();
            nPacientes = new NPacientes();
            cargardatos();
        }

        private void BuscarPaciente_Load(object sender, EventArgs e)
        {
            
        }
        private void cargardatos()
        {
            var datos = nPacientes.BuscarPacientesGrid();
            dgBuscarPaciente.DataSource = datos;
        }

        private void checkBfiltro_CheckedChanged(object sender, EventArgs e)
        {
            dgBuscarPaciente.DataSource = nPacientes.BuscarPacientesActivosGrid();
            if (checkBfiltro.Checked == false)
            {
                cargardatos();
            }
        }

        private void dgBuscarMedico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PacienteId = dgBuscarPaciente.CurrentRow.Cells["PacienteId"].Value.ToString();
            Nombre_Completo = dgBuscarPaciente.CurrentRow.Cells["Nombre_Completo"].Value.ToString();
            FechaIngreso = dgBuscarPaciente.CurrentRow.Cells["Fecha_de_Ingreso"].Value.ToString();
            Estado = dgBuscarPaciente.CurrentRow.Cells["Estado"].Value.ToString();
            this.Visible = false;
        }
    }
}
