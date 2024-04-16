using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSULTORIO.BasedeDatos
{
    public class ConsultorioContext: DbContext
    {

        public ConsultorioContext() : base("Consultorio")
        { 
        
        }
    }
}
