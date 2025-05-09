using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aenit
{
   public class Sala
    {
        [Key]
        public int Codigo { get; set; }

        public string NombreSala { get; set; }

        public int Capacidad { get; set; }

        public List<Sesion>? Sesiones { get; set; }

    }
}
