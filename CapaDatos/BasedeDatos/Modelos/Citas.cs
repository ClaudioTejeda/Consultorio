using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.BasedeDatos.Modelos
{
    public class Citas
    {
        [Key]
        public int CitaId { get; set; }
        public int MedicoId { get; set; }
        public Medicos Medicos { get; set; }
        public int PacienteId { get; set; }
        public Medicos Pacientes { get; set; }
        public DateTime FechaCita { get; set; }
        public bool Estado {  get; set; }
    }
}
