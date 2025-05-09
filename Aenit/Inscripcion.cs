using System.ComponentModel.DataAnnotations;

namespace Aenit
{
    public class Inscripcion
    {
        [Key]
        public int Codigo { get; set; }

       public string Estado { get; set; }
        public DateTime FechaInscripcion { get; set; }

        public int EventoCodigo { get; set; }

        public  int ParticipanteCodigo {  get; set; }

        public Evento? Evento { get; set; }

        public Participante? Participante { get; set; }
    }
}
