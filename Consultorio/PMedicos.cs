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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Consultorio
{
    public partial class PMedicos : Form
    {
        private NMedicos nMedicos;
        public PMedicos()
        {
            InitializeComponent();
            nMedicos = new NMedicos();
            CargarDatos();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PMedicos_Load(object sender, EventArgs e)
        {

        }
        void CargarDatos()
        {
            dgmedicos.DataSource = nMedicos.obtenerMedicosGrid();
        }

        void LimpiarDatos()
        {
            txtMedicoid.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            checkBEstado.Checked = false;
            dateTimeFechaingreso.Value = DateTime.Now;
            errorProvider1.Clear();
        }
        private void checkBFiltro_CheckedChanged(object sender, EventArgs e)
        {
            dgmedicos.DataSource = nMedicos.obtenerMedicosActivosGrid();
            if (checkBFiltro.Checked == false)
            {
                CargarDatos();
            }
        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            var agregar = false;
            var medicoId = txtMedicoid.Text.ToString();
            var nombres = txtNombres.Text.ToString();
            var apellidos = txtApellidos.Text.ToString();
            if (string.IsNullOrEmpty(medicoId) || string.IsNullOrWhiteSpace(medicoId))
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
                nMedicos.AgregarMedicos(new Medicos()
                {
                    Nombres = nombres,
                    Apellidos = apellidos,
                    FechaIngreso = dateTimeFechaingreso.Value,
                    Estado = checkBEstado.Checked,
                });
            }
            else
            {
                nMedicos.EditarMedicos(new Medicos()
                {
                    MedicoId = int.Parse(medicoId),
                    Nombres = nombres,
                    Apellidos = apellidos,
                    FechaIngreso = dateTimeFechaingreso.Value,
                    Estado = checkBEstado.Checked
                });
            }
            CargarDatos();
            LimpiarDatos();
        }

        private void dgmedicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgmedicos.Rows.Count)
            {
                txtMedicoid.Text = dgmedicos.CurrentRow.Cells["MedicoId"].Value.ToString();
                txtNombres.Text = dgmedicos.CurrentRow.Cells["Nombres"].Value.ToString();
                txtApellidos.Text = dgmedicos.CurrentRow.Cells["Apellidos"].Value.ToString();
                if (DateTime.TryParse(dgmedicos.CurrentRow.Cells["Fecha_de_Ingreso"].Value.ToString(), out DateTime fechaingreso))
                {
                    dateTimeFechaingreso.Value = fechaingreso;
                }
                checkBEstado.Checked = bool.Parse(dgmedicos.CurrentRow.Cells["Estado"].Value.ToString());
            }
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            var medicoId = txtMedicoid.Text.ToString();
            if (string.IsNullOrEmpty(medicoId) || string.IsNullOrWhiteSpace(medicoId))
            {
                return;
            }
            nMedicos.EliminarMedicos(int.Parse(medicoId));
            CargarDatos();
            LimpiarDatos();
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
