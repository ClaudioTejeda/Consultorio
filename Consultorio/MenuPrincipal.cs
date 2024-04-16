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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void gestionDeMedicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PMedicos Medicos = new PMedicos();
            Medicos.MdiParent = this;
            Medicos.Show();
        }

        private void gestionDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PPacientes Pacientes = new PPacientes();
            Pacientes.MdiParent = this;
            Pacientes.Show();
        }

        private void gestionDeCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PCitas PCitas = new PCitas();
            PCitas.MdiParent = this;
            PCitas.Show();
        }
    }
}
