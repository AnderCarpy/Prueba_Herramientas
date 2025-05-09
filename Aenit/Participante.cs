using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aenit
{
  public  class Participante
    {
        [Key]
        public int Codigo { get; set; }
         
        public string Nombre { get; set; }

        public string Email { get; set; }

        public string Telefono { get; set; }
        public virtual List<Inscripcion>? Inscripciones { get; set; }


    }
}
