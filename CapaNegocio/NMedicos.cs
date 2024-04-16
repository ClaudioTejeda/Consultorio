using CapaDatos;
using CapaDatos.BasedeDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NMedicos
    {
        private DMedicos dMedicos;

        public NMedicos()
        {
            dMedicos = new DMedicos();
        }

        public List<Medicos> TodasLosMedicos()
        {
            return dMedicos.TodosLosMedicos();
        }
        public List<Medicos> MedicosActivos()
        {
            return dMedicos.TodosLosMedicos().Where(c => c.Estado == true).ToList();
        }
        public List<object> obtenerMedicosGrid()
        {
            var Medicos = dMedicos.TodosLosMedicos().Select(c => new
            {
                c.MedicoId,
                c.Nombres,
                c.Apellidos,
                Fecha_de_Ingreso = c.FechaIngreso,
                c.Estado
            });
            return Medicos.Cast<object>().ToList();
        }
        public List<object> BuscarMedicosGrid()
        {
            var Medicos = dMedicos.TodosLosMedicos().Select(c => new
            {
                c.MedicoId,
                Nombre_Completo = c.Nombres + " " + c.Apellidos, 
                Fecha_de_Ingreso = c.FechaIngreso,
                c.Estado
            });
            return Medicos.Cast<object>().ToList();
        }
        public List<object> BuscarMedicosActivosGrid()
        {
            var Medicos = dMedicos.TodosLosMedicos().Select(c => new
            {
                c.MedicoId,
                Nombre_Completo = c.Nombres + " " + c.Apellidos,
                Fecha_de_Ingreso = c.FechaIngreso,
                c.Estado
            });
            return Medicos.Where(c => c.Estado ==true).Cast<object>().ToList();
        }
        public List<object> obtenerMedicosActivosGrid()
        {
            var Medicos = dMedicos.TodosLosMedicos().Select(c => new
            {
                c.MedicoId,
                c.Nombres,
                c.Apellidos,
                Fecha_de_Ingreso = c.FechaIngreso,
                c.Estado
            });
            return Medicos.Where(c => c.Estado == true).Cast<object>().ToList();
        }
        public int AgregarMedicos(Medicos medicos)
        {
            return dMedicos.Guardar(medicos);
        }
        public int EditarMedicos(Medicos medicos)
        {
            return dMedicos.Guardar(medicos);
        }
        public int EliminarMedicos(int MedicoId)
        {
            return dMedicos.Eliminar(MedicoId);
        }
    }
}
