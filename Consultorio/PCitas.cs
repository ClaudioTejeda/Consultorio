using CapaDatos;
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
    public partial class PCitas : Form
    {
        NCitas nCitas;
        public PCitas()
        {
            InitializeComponent();
            nCitas = new NCitas();
            CargarDatos();
        }
        void CargarDatos()
        {
            var datos = nCitas.obtenerCitasGrid();
            dgPacientes.DataSource = datos;
        }
        void LimpiarDatos()
        {
            txtMedico.Text = "";
            txtPaciente.Text = "";
            idmedico.Text = "";
            idpaciente.Text = "";
            txtCitaId.Text = "";
            checkBEstado.Checked = false;
            dateTimeFechaingreso.Value = DateTime.Now;
            errorProvider1.Clear();
        }
        private bool ValidarDatos()
        {
            var FormularioValido = true;
            if (string.IsNullOrEmpty(txtMedico.Text.ToString()) || string.IsNullOrWhiteSpace(txtMedico.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtMedico, "Debe de buscar y seleccionar un Medico");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtPaciente.Text.ToString()) || string.IsNullOrWhiteSpace(txtPaciente.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtPaciente, "Debe buscar y seleccionar un Paciente");
                return FormularioValido;
            }
            return FormularioValido;
        }

        private void PCitas_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscarMedico_Click(object sender, EventArgs e)
        {
            BuscarMedico medico = new BuscarMedico();
            medico.ShowDialog();
            idmedico.Text = medico.MedicoId;
            txtMedico.Text = medico.Nombre_Completo;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            BuscarPaciente paciente = new BuscarPaciente();
            paciente.ShowDialog();
            idpaciente.Text = paciente.PacienteId;
            txtPaciente.Text = paciente.Nombre_Completo;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Citas cita = new Citas()
                {
                    MedicoId = int.Parse(idmedico.Text.ToString()),
                    PacienteId = int.Parse(idpaciente.Text.ToString()),
                    Medico = txtMedico.Text,
                    Paciente = txtPaciente.Text,
                    FechaCita = dateTimeFechaingreso.Value,
                    Estado = checkBEstado.Checked,
                };
                if (!string.IsNullOrEmpty(txtCitaId.Text) && int.TryParse(txtCitaId.Text.ToString(), out int citaid) && citaid != 0)
                {
                    cita.CitaId = citaid;
                    nCitas.EditarCitas(cita);
                }
                else
                {
                    nCitas.AgregarCitas(cita);
                }
                LimpiarDatos();
                CargarDatos();
            }
        }

        private void dgPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgPacientes.Rows.Count)
            {
                txtCitaId.Text = dgPacientes.CurrentRow.Cells["CitaId"].Value.ToString();
                idmedico.Text = dgPacientes.CurrentRow.Cells["MedicoId"].Value.ToString();
                idpaciente.Text = dgPacientes.CurrentRow.Cells["PacienteId"].Value.ToString();
                txtMedico.Text = dgPacientes.CurrentRow.Cells["Medico"].Value.ToString();
                txtPaciente.Text = dgPacientes.CurrentRow.Cells["Paciente"].Value.ToString();
                dateTimeFechaingreso.Text = dgPacientes.CurrentRow.Cells["FechaCita"].Value.ToString();
                checkBEstado.Checked = bool.Parse(dgPacientes.CurrentRow.Cells["Estado"].Value.ToString());
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            var citaid = txtCitaId.Text.ToString();
            if (string.IsNullOrEmpty(citaid) || string.IsNullOrWhiteSpace(citaid))
            {
                return;
            }
            nCitas.Eliminar(int.Parse(citaid));
            CargarDatos();
            LimpiarDatos();
        }

        private void checkBFiltro_CheckedChanged(object sender, EventArgs e)
        {
            dgPacientes.DataSource = nCitas.obtenerCitasActivasGrid();
            if (checkBFiltro.Checked == false)
            {
                CargarDatos();
            }
        }
    }
}
