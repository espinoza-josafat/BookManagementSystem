using BookManagementSystem.Entities;
using BookManagementSystem.Infraestructure.UnitOfWork;
using System.Data.Entity;

namespace BookManagementSystem.Infraestructure.DbContext
{
    public interface IBookManagementSystemDbContext : IEntityFrameworkUnitOfWork
    {
        IDbSet<Autor> Autor { get; }

        IDbSet<Categoria> Categoria { get; }

        IDbSet<DetallePrestamo> DetallePrestamo { get; }

        IDbSet<Editorial> Editorial { get; }

        IDbSet<Ejemplar> Ejemplar { get; }

        IDbSet<EstadoEjemplar> EstadoEjemplar { get; }

        IDbSet<Idioma> Idioma { get; }

        IDbSet<Libro> Libro { get; }

        IDbSet<Pais> Pais { get; }

        IDbSet<Prestamo> Prestamo { get; }

        IDbSet<SubCategoria> SubCategoria { get; }

        IDbSet<SubSubCategoria> SubSubCategoria { get; }

        IDbSet<SubSubTema> SubSubTema { get; }

        IDbSet<SubTema> SubTema { get; }

        IDbSet<Tema> Tema { get; }

        IDbSet<TipoUsuario> TipoUsuario { get; }

        IDbSet<Usuario> Usuario { get; }
        
        IDbSet<Estado> Estado { get; }

        IDbSet<Municipio> Municipio { get; }

        IDbSet<CodigoPostal> CodigoPostal { get; }

        IDbSet<Asentamiento> Asentamiento { get; }
    }
}