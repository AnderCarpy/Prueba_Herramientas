using Api.Consumer;
using Aenit;

namespace Aenit.Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            ProbarParticipantes();
             ProbarPonentes();
            ProbarSalas();
            ProbarSesiones();
            // ProbarCertificados();
            // ProbarEventos();
            //  ProbarInscripciones();
            // ProbarPagos();


            Console.ReadLine();
        }

        private static void ProbarParticipantes()
        {
            Crud<Participante>.EndPoint = "https://localhost:7112/api/Participantes";

            var participante = Crud<Participante>.Create(new Participante
            {
                Codigo = 0,
                Nombre = "Ander Carlosama",
                Telefono = "0993857940",
                Email = "apcarlosama@example.com"
            });

            participante.Nombre = "Ander Carlosama Sarabia";
            Crud<Participante>.Update(participante.Codigo, participante);

            var participantes = Crud<Participante>.GetAll();
            foreach (var p in participantes)
            {
                Console.WriteLine($"Codigo: {p.Codigo}, Nombre: {p.Nombre}, Telefono: {p.Telefono}, Email: {p.Email}");
            }
        }

        private static void ProbarEventos()
        {
            Crud<Evento>.EndPoint = "https://localhost:7112/api/Eventos";

            var evento = Crud<Evento>.Create(new Evento
            {
                Codigo = 0,
                Nombre = "CyberSeguridad",
                Fecha = new DateTime(1990, 1, 1),
                Tipo = "Conversatorio"
            });

            evento.Nombre = "Evento de Seguridad Actualizado";
            Crud<Evento>.Update(evento.Codigo, evento);

            var eventos = Crud<Evento>.GetAll();
            foreach (var e in eventos)
            {
                Console.WriteLine($"Codigo: {e.Codigo}, Nombre: {e.Nombre}, Fecha: {e.Fecha}, Tipo: {e.Tipo}");
            }
        }

        private static void ProbarSalas()
        {
            Crud<Sala>.EndPoint = "https://localhost:7112/api/Salas";

            var sala = Crud<Sala>.Create(new Sala
            {
                Codigo = 0,
                NombreSala = "SALA MAC 2",
                Capacidad = 100
            });

            sala.NombreSala = "Sala MAC 2 Actualizada";
            Crud<Sala>.Update(sala.Codigo, sala);

            var salas = Crud<Sala>.GetAll();
            foreach (var s in salas)
            {
                Console.WriteLine($"Codigo: {s.Codigo}, Nombre: {s.NombreSala}, Capacidad: {s.Capacidad}");
            }
        }

        private static void ProbarSesiones()
        {
            Crud<Sesion>.EndPoint = "https://localhost:7112/api/Sesiones";

            var sesion = Crud<Sesion>.Create(new Sesion
            {
                Codigo = 0,
                EventoCodigo =0,
                SalaCodigo = 0,
                Fecha = new DateTime(2000, 12, 10)
            });

            sesion.Fecha = new DateTime(2000, 12, 11);
            Crud<Sesion>.Update(sesion.Codigo, sesion);

            var sesiones = Crud<Sesion>.GetAll();
            foreach (var s in sesiones)
            {
                Console.WriteLine($"Codigo: {s.Codigo}, Evento: {s.EventoCodigo}, Sala: {s.SalaCodigo}, Fecha: {s.Fecha}");
            }
        }

        private static void ProbarPonentes()
        {
            Crud<Ponente>.EndPoint = "https://localhost:7112/api/Ponentes";

            var ponente = Crud<Ponente>.Create(new Ponente
            {
                Codigo = 0,
                Nombre = "Ana Torres",
                Especialidad = "Criptografía"
            });

            ponente.Nombre = "Ana Torres Actualizada";
            Crud<Ponente>.Update(ponente.Codigo, ponente);

            var ponentes = Crud<Ponente>.GetAll();
            foreach (var p in ponentes)
            {
                Console.WriteLine($"Codigo: {p.Codigo}, Nombre: {p.Nombre}, Especialidad: {p.Especialidad}");
            }
        }

        private static void ProbarInscripciones()
        {
            Crud<Inscripcion>.EndPoint = "https://localhost:7112/api/Inscripciones";

            var inscripcion = Crud<Inscripcion>.Create(new Inscripcion
            {
                Codigo = 0,
                Estado = "Disponible",
                FechaInscripcion = new DateTime(2000, 12, 10),
                EventoCodigo = 0,
                ParticipanteCodigo = 0
            });

            inscripcion.Estado = "Confirmado";
            Crud<Inscripcion>.Update(inscripcion.Codigo, inscripcion);

            var inscripciones = Crud<Inscripcion>.GetAll();
            foreach (var i in inscripciones)
            {
                Console.WriteLine($"Codigo: {i.Codigo}, Estado: {i.Estado}, Fecha: {i.FechaInscripcion}, EventoCodigo: {i.EventoCodigo}, ParticipanteCodigo: {i.ParticipanteCodigo}");
            }
        }

        private static void ProbarPagos()
        {
            Crud<Pago>.EndPoint = "https://localhost:7112/api/Pagos";

            var pago = Crud<Pago>.Create(new Pago
            {
                Codigo = 0,
                FechaPago = new DateTime(2001, 12, 11),
                MontoPago = 0,
                InscripcionCodigo = 0
            });

            pago.MontoPago = 3;
            Crud<Pago>.Update(pago.Codigo, pago);

            var pagos = Crud<Pago>.GetAll();
            foreach (var p in pagos)
            {
                Console.WriteLine($"Codigo: {p.Codigo}, FechaPago: {p.FechaPago}, MontoPago: {p.MontoPago}, InscripcionCodigo: {p.InscripcionCodigo}");
            }
        }

        private static void ProbarCertificados()
        {
            Crud<Certificado>.EndPoint = "https://localhost:7112/api/Certificados";

            var certificado = Crud<Certificado>.Create(new Certificado
            {
                Codigo = 0,
                FechaEmision = new DateTime(2025, 05, 09),
                InscripcionCodigo = 0
            });

            certificado.FechaEmision = new DateTime(2025, 05, 10);
            Crud<Certificado>.Update(certificado.Codigo, certificado);

            var certificados = Crud<Certificado>.GetAll();
            foreach (var c in certificados)
            {
                Console.WriteLine($"Codigo: {c.Codigo}, Fecha Emision: {c.FechaEmision}, InscripcionCodigo: {c.InscripcionCodigo}");
            }
        }



    }
}

