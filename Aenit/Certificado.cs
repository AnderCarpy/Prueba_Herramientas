using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aenit
{
   public  class Certificado
    {
        [Key]
        public int Codigo { get; set; }
        
        public DateTime FechaEmision { get; set; }

        public int InscripcionCodigo { get; set; }

        public Inscripcion? Inscripcion { get; set; }
    }
}
