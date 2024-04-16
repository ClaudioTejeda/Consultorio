using CapaDatos.BasedeDatos.Modelos;
using CapaDatos.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DCitas
    {
        UnitofWork _unitOfWork;

        public DCitas()
        {
            _unitOfWork = new UnitofWork();
        }
        [Key]
        public int CitaId { get; set; }
        public int MedicoId { get; set; }
        public int PacienteId { get; set; }
        public DateTime FechaCita { get; set; }
        public bool Estado { get; set; }

        public List<Citas> Todaslascitas()
        {
            return _unitOfWork.Repository<Citas>().Consulta().Include(c => c.Medicos)
                                         .Include(c => c.Pacientes)
                                         .ToList();
        }
        public int Guardar(Citas cita)
        {
            if (cita.CitaId == 0)
            {
                _unitOfWork.Repository<Citas>().Agregar(cita);
                return _unitOfWork.Guardar();
            }
            else
            {
                var citaInDb = _unitOfWork.Repository<Citas>().Consulta().FirstOrDefault(c => c.CitaId == cita.CitaId);
                if (citaInDb != null)
                {
                    citaInDb.MedicoId = cita.MedicoId;
                    citaInDb.Medico = cita.Medico;
                    citaInDb.Paciente = cita.Paciente;
                    citaInDb.PacienteId = cita.PacienteId;
                    citaInDb.FechaCita = cita.FechaCita;
                    citaInDb.Estado = cita.Estado;
                    _unitOfWork.Repository<Citas>().Editar(citaInDb);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }
        }

        public int Eliminar(int citaId)
        {
            var citaInDb = _unitOfWork.Repository<Citas>().Consulta().FirstOrDefault(c => c.CitaId == citaId);
            if (citaInDb != null)
            {
                _unitOfWork.Repository<Citas>().Eliminar(citaInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}