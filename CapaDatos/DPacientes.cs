using CapaDatos.BasedeDatos.Modelos;
using CapaDatos.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DPacientes
    {
        UnitofWork _unitOfWork;

        public DPacientes()
        {
            _unitOfWork = new UnitofWork();
        }
        public int PacienteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }
        public List<Pacientes> TodosLosPacientes()
        {
            return _unitOfWork.Repository<Pacientes>().Consulta().ToList();
        }
        public int Guardar(Pacientes pacientes)
        {
            if (pacientes.PacienteId == 0)
            {
                _unitOfWork.Repository<Pacientes>().Agregar(pacientes);
                return _unitOfWork.Guardar();
            }
            else
            {
                var pacienteInDb = _unitOfWork.Repository<Pacientes>().Consulta().FirstOrDefault(c => c.PacienteId == pacientes.PacienteId);
                if (pacienteInDb != null)
                {
                    pacienteInDb.Nombres = pacientes.Nombres;
                    pacienteInDb.Apellidos = pacientes.Apellidos;
                    pacienteInDb.FechaIngreso = pacientes.FechaIngreso;
                    pacienteInDb.Estado = pacientes.Estado;
                    _unitOfWork.Repository<Pacientes>().Editar(pacienteInDb);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }
        }
        public int Eliminar(int pacienteId)
        {
            var pacienteInDb = _unitOfWork.Repository<Pacientes>().Consulta().FirstOrDefault(c => c.PacienteId == pacienteId);
            if (pacienteInDb != null)
            {
                _unitOfWork.Repository<Pacientes>().Eliminar(pacienteInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}

