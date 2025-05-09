using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aenit
{
   public class Sesion
    {
        [Key]
        public int Codigo { get; set; }

        public DateTime Fecha { get; set; }

        public int EventoCodigo { get; set; }

        public int SalaCodigo { get; set; }

        //Navegacion
        public Evento? Evento { get; set; }
        public Sala? Sala { get; set; }

    }
}
