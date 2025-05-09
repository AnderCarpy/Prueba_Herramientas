using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aenit.Test
{
     internal class Program
    {
        static void Main(string[] args)
        {
            ProbarPacientes();

            Console.ReadLine();
        }

        private static void ProbarPacientes()
        {
            Crud<Paciente>.EndPoint = "https://localhost:7220/api/Pacientes";

            // crear un objeto de la clase libro
            var libro = Crud<Paciente>.Create(new Paciente
            {
                Codigo = 0,   // para crear un registro nuevo
                Nombre = "Ander",
                Apellido = "carlosama",
                FechaNacimiento = new DateTime(2004, 12, 30),
                Sexo = "masculino",
                Telefono = "0993857940",
                Direccion = "florida",
                Email = "apcarlosama",
                FechaIngreso = new DateTime(1900, 01, 21),
                FechaAlta = new DateTime(1900, 02, 12)
            });

            /* actualizar el libro
            libro.Titulo = "El Principito Actualizado";
            Crud<Libro>.Update(libro.Codigo, libro);*/

            // obtener todos los libros
            var paciente = Crud<Paciente>.GetAll();

            foreach (var l in paciente)
            {
                Console.WriteLine($"Codigo: {l.Codigo}, nombre: {l.Nombre}, apellido: {l.Apellido}, born: {l.FechaNacimiento}, telefono: {l.Telefono}, direccion: {l.Direccion}, email: {l.Email}, fechaingreso: {l.FechaIngreso},FechaAlta{l.FechaAlta}");
            }
        }

        //    private static void ProbarPaises()
        //    {
        //        Crud<Pais>.EndPoint = "https://localhost:7041/api/Paises";

        //        // crear un objeto de la clase pais
        //        var pais = Crud<Pais>.Create(new Pais
        //        {
        //            Codigo = 0,   // para crear un registro nuevo
        //            Nombre = "Argentina",
        //            Continente = "America",
        //            Moneda = "Peso",
        //            Idioma = "Español",
        //            Capital = "Buenos Aires"
        //        });

        //        // actualizar el pais
        //        pais.Nombre = "Argentina Actualizado";
        //        Crud<Pais>.Update(pais.Codigo, pais);

        //        // obtener todos los paises
        //        var paises = Crud<Pais>.GetAll();

        //        foreach (var p in paises)
        //        {
        //            Console.WriteLine($"Codigo: {p.Codigo}, Nombre: {p.Nombre}, Continente: {p.Continente}, Moneda: {p.Moneda}, Idioma: {p.Idioma}, Capital: {p.Capital}");
        //        }
        //    }

        //    private static void ProbarAutores()
        //    {
        //        Crud<Autor>.EndPoint = "https://localhost:7041/api/Autores";
        //        // crear un objeto de la clase autor
        //        var autor = Crud<Autor>.Create(new Autor
        //        {
        //            Codigo = 0,   // para crear un registro nuevo
        //            Nombre = "Juan ",
        //            Apellido = "Lopez",
        //            FechaNacmiento = new DateTime(1990, 1, 1),
        //            PaisCodigo = 1
        //        });

        //        // actualizar el autor
        //        autor.Nombre = "Juan Actualizado";
        //        Crud<Autor>.Update(autor.Codigo, autor);

        //        // obtener todos los autores
        //        var autores = Crud<Autor>.GetAll();
        //        foreach (var a in autores)
        //        {
        //            Console.WriteLine($"Codigo: {a.Codigo}, Nombre: {a.Nombre}, Apellido: {a.Apellido}, FechaNacmiento: {a.FechaNacmiento.ToShortDateString()}, PaisCodigo: {a.Pais.Nombre}");
        //        }
        //    }

        //    private static void ProbarEditoriales()
        //    {
        //        Crud<Editorial>.EndPoint = "https://localhost:7041/api/Editoriales";

        //        // crear un objeto de la clase editorial
        //        var santillana = Crud<Editorial>.Create(new Editorial
        //        {
        //            Codigo = 0,   // para crear un registro nuevo
        //            Nombre = "Santillana 2",
        //            PaisCodigo = 1
        //        });

        //        // actualizar la editorial
        //        santillana.Nombre = "Santillana 2 Actualizado";
        //        Crud<Editorial>.Update(santillana.Codigo, santillana);

        //        // obtener todas las editoriales
        //        var editoriales = Crud<Editorial>.GetAll();
        //        foreach (var e in editoriales)
        //        {
        //            Console.WriteLine($"Codigo: {e.Codigo}, Nombre: {e.Nombre}, PaisCodigo: {e.Pais.Nombre}");
        //        }
        //    }
        //}
    }
}
