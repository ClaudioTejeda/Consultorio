using CapaDatos;
using CapaDatos.BasedeDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NPacientes
    {
        private DPacientes dPacientes;

        public NPacientes()
        {
            dPacientes = new DPacientes();
        }

        public List<Pacientes> Todoslospacientes()
        {
            return dPacientes.TodosLosPacientes();
        }
        public List<Pacientes> PacientesActivos()
        {
            return dPacientes.TodosLosPacientes().Where(c => c.Estado == true).ToList();
        }
        public List<object> obtenerPacientesGrid()
        {
            var Pacientes = dPacientes.TodosLosPacientes().Select(c => new
            {
                c.PacienteId,
                c.Nombres,
                c.Apellidos,
                Fecha_de_Ingreso = c.FechaIngreso,
                c.Estado
            });
            return Pacientes.Cast<object>().ToList();
        }
        public List<object> BuscarPacientesGrid()
        {
            var Pacientes = dPacientes.TodosLosPacientes().Select(c => new
            {
                c.PacienteId,
                Nombre_Completo = c.Nombres + " " + c.Apellidos,
                Fecha_de_Ingreso = c.FechaIngreso,
                c.Estado
            });
            return Pacientes.Cast<object>().ToList();
        }
        public List<object> BuscarPacientesActivosGrid()
        {
            var Pacientes = dPacientes.TodosLosPacientes().Select(c => new
            {
                c.PacienteId,
                Nombre_Completo = c.Nombres + " " + c.Apellidos,
                Fecha_de_Ingreso = c.FechaIngreso,
                c.Estado
            });
            return Pacientes.Where(c => c.Estado == true).Cast<object>().ToList();
        }
        public List<object> obtenerMedicosActivosGrid()
        {
            var Pacientes = dPacientes.TodosLosPacientes().Select(c => new
            {
                c.PacienteId,
                c.Nombres,
                c.Apellidos,
                Fecha_de_Ingreso = c.FechaIngreso,
                c.Estado
            });
            return Pacientes.Where(c => c.Estado == true).Cast<object>().ToList();
        }
        public int AgregarPacientes(Pacientes pacientes)
        {
            return dPacientes.Guardar(pacientes);
        }
        public int EditarPacientes(Pacientes pacientes)
        {
            return dPacientes.Guardar(pacientes);
        }
        public int EliminarPacientes(int PacienteId)
        {
            return dPacientes.Eliminar(PacienteId);
        }
    }
}
