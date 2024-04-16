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
    public class DMedicos
    {
        UnitofWork _unitOfWork;

        public DMedicos()
        {
            _unitOfWork = new UnitofWork();
        }
        public int MedicoId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }
        public List<Medicos> TodosLosMedicos()
        {
            return _unitOfWork.Repository<Medicos>().Consulta().ToList();
        }
        public List<Medicos> MedicosActivos()
        {
            return _unitOfWork.Repository<Medicos>().Consulta().ToList();
        }
        public int Guardar(Medicos medicos)
        {
            if (medicos.MedicoId == 0)
            {
                _unitOfWork.Repository<Medicos>().Agregar(medicos);
                return _unitOfWork.Guardar();
            }
            else
            {
                var medicoInDb = _unitOfWork.Repository<Medicos>().Consulta().FirstOrDefault(c => c.MedicoId == medicos.MedicoId);
                if (medicoInDb != null)
                {
                    medicoInDb.Nombres = medicos.Nombres;
                    medicoInDb.Apellidos = medicos.Apellidos;
                    medicoInDb.FechaIngreso = medicos.FechaIngreso;
                    medicoInDb.Estado = medicos.Estado;
                    _unitOfWork.Repository<Medicos>().Editar(medicoInDb);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }
        }
        public int Eliminar(int medicoId)
        {
            var medicoInDb = _unitOfWork.Repository<Medicos>().Consulta().FirstOrDefault(c => c.MedicoId == medicoId);
            if (medicoInDb != null)
            {
                _unitOfWork.Repository<Medicos>().Eliminar(medicoInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}
