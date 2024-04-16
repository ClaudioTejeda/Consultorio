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
    public partial class BuscarMedico : Form
    {
        NMedicos nMedicos;
        public string MedicoId { get; set; }
        public string Nombre_Completo { get; set; }
        public string FechaIngreso { get; set; }
        public string Estado {  get; set; }
        public BuscarMedico()
        {
            InitializeComponent();
            nMedicos = new NMedicos();
            cargardatos();
        }
        private void BuscarMedico_Load(object sender, EventArgs e)
        {

        }
        private void cargardatos()
        {
            var datos = nMedicos.BuscarMedicosGrid();
            dgBuscarMedico.DataSource = datos;
        }

        private void checkBfiltro_CheckedChanged(object sender, EventArgs e)
        {
            dgBuscarMedico.DataSource = nMedicos.BuscarMedicosActivosGrid();
            if (checkBfiltro.Checked == false)
            {
                cargardatos();
            }
        }

        private void dgBuscarMedico_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MedicoId = dgBuscarMedico.CurrentRow.Cells["MedicoId"].Value.ToString();
            Nombre_Completo = dgBuscarMedico.CurrentRow.Cells["Nombre_Completo"].Value.ToString();
            FechaIngreso = dgBuscarMedico.CurrentRow.Cells["Fecha_de_Ingreso"].Value.ToString();
            Estado = dgBuscarMedico.CurrentRow.Cells["Estado"].Value.ToString();
            this.Visible = false;
        }
    }
}
