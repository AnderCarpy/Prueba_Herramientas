using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aenit;

    public class AppContext : DbContext
    {
        public AppContext (DbContextOptions<AppContext> options)
            : base(options)
        {
        } 


    public DbSet<Aenit.Certificado> Certificados { get; set; } = default!;

public DbSet<Aenit.Evento> Eventos { get; set; } = default!;

public DbSet<Aenit.Inscripcion> Inscripciones { get; set; } = default!;

public DbSet<Aenit.Pago> Pagos { get; set; } = default!;

public DbSet<Aenit.Participante> Participantes { get; set; } = default!;

public DbSet<Aenit.Ponente> Ponentes { get; set; } = default!;

public DbSet<Aenit.Sala> Salas { get; set; } = default!;

public DbSet<Aenit.Sesion> Sesiones { get; set; } = default!;
    }
