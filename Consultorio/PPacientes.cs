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
    public partial class PPacientes : Form
    {
        private NPacientes nPacientes;
        public PPacientes()
        {
            InitializeComponent();
            nPacientes = new NPacientes();
            CargarDatos();
        }

        private void PPacientes_Load(object sender, EventArgs e)
        {

        }
        void CargarDatos()
        {
            dgPacientes.DataSource = nPacientes.obtenerPacientesGrid();
        }

        void LimpiarDatos()
        {
            txtPacienteid.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            checkBEstado.Checked = false;
            dateTimeFechaingreso.Value = DateTime.Now;
            errorProvider1.Clear();
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            var agregar = false;
            var pacienteId = txtPacienteid.Text.ToString();
            var nombres = txtNombres.Text.ToString();
            var apellidos = txtApellidos.Text.ToString();
            if (string.IsNullOrEmpty(pacienteId) || string.IsNullOrWhiteSpace(pacienteId))
            {
                agregar = true;
            }
            if (string.IsNullOrEmpty(nombres) || string.IsNullOrWhiteSpace(nombres))
            {
                errorProvider1.SetError(txtNombres, "Debe ingresar Nombres");
                return;
            }
            if (string.IsNullOrEmpty(apellidos) || string.IsNullOrWhiteSpace(apellidos))
            {
                errorProvider1.SetError(txtApellidos, "Debe ingresar Apellidos");
                return;
            }

            if (agregar)
            {
                nPacientes.AgregarPacientes(new Pacientes()
                {
                    Nombres = nombres,
                    Apellidos = apellidos,
                    FechaIngreso = dateTimeFechaingreso.Value,
                    Estado = checkBEstado.Checked,
                });
            }
            else
            {
                nPacientes.EditarPacientes(new Pacientes()
                {
                    PacienteId = int.Parse(pacienteId),
                    Nombres = nombres,
                    Apellidos = apellidos,
                    FechaIngreso = dateTimeFechaingreso.Value,
                    Estado = checkBEstado.Checked
                });
            }
            CargarDatos();
            LimpiarDatos();
        }

        private void dgPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgPacientes.Rows.Count)
            {
                txtPacienteid.Text = dgPacientes.CurrentRow.Cells["PacienteId"].Value.ToString();
                txtNombres.Text = dgPacientes.CurrentRow.Cells["Nombres"].Value.ToString();
                txtApellidos.Text = dgPacientes.CurrentRow.Cells["Apellidos"].Value.ToString();
                if (DateTime.TryParse(dgPacientes.CurrentRow.Cells["Fecha_de_Ingreso"].Value.ToString(), out DateTime fechaingreso))
                {
                    dateTimeFechaingreso.Value = fechaingreso;
                }
                checkBEstado.Checked = bool.Parse(dgPacientes.CurrentRow.Cells["Estado"].Value.ToString());
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            var pacienteId = txtPacienteid.Text.ToString();
            if (string.IsNullOrEmpty(pacienteId) || string.IsNullOrWhiteSpace(pacienteId))
            {
                return;
            }
            nPacientes.EliminarPacientes(int.Parse(pacienteId));
            CargarDatos();
            LimpiarDatos();
        }
        private void checkBFiltro_CheckedChanged(object sender, EventArgs e)
        {
            dgPacientes.DataSource = nPacientes.obtenerMedicosActivosGrid();
            if (checkBFiltro.Checked == false)
            {
                CargarDatos();
            }
        }
    }
}
