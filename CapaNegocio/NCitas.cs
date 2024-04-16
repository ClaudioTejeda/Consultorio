using CapaDatos;
using CapaDatos.BasedeDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NCitas
    {
        private DCitas dcitas;

        public NCitas()
        {
            dcitas = new DCitas();
        }

        public List<Citas> Todaslascitas()
        {
            return dcitas.Todaslascitas();
        }
        public int AgregarCitas(Citas citas)
        {
            return dcitas.Guardar(citas);
        }
        public int EditarCitas(Citas citas)
        {

            return dcitas.Guardar(citas);
        }

        public int Eliminar(int CitaId)
        {
            return dcitas.Eliminar(CitaId);
        }
        public List<object> obtenerCitasGrid()
        {
            var pedidodetalles = dcitas.Todaslascitas().Select(c => new
            {
                c.CitaId,
                c.MedicoId,
                c.Medico,
                c.PacienteId,
                c.Paciente,
                c.Estado,
                c.FechaCita
            });
            return pedidodetalles.Cast<object>().ToList();
        }
        public List<object> obtenerCitasActivasGrid()
        {
            var pedidodetalles = dcitas.Todaslascitas().Select(c => new
            {
                c.CitaId,
                c.MedicoId,
                c.Medico,
                c.PacienteId,
                c.Paciente,
                c.Estado,
                c.FechaCita
            });
            return pedidodetalles.Where(c=> c.Estado == true).Cast<object>().ToList();
        }
    }
}

