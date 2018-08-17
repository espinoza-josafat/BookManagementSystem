using BookManagementSystem.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace BookManagementSystem.Infraestructure.DbContext
{
    public class BookManagementSystemDbContext : System.Data.Entity.DbContext, IBookManagementSystemDbContext
    {
        public BookManagementSystemDbContext() : base("BookManagementSystemDbContext")
        {
            //Disable initializer
            Database.SetInitializer<BookManagementSystemDbContext>(null);
        }
        
        IDbSet<Autor> _autor;

        public IDbSet<Autor> Autor
        {
            get
            {
                if (_autor == null)
                    _autor = base.Set<Autor>();

                return _autor;
            }
        }

        IDbSet<Categoria> _categoria;

        public IDbSet<Categoria> Categoria
        {
            get
            {
                if (_categoria == null)
                    _categoria = base.Set<Categoria>();

                return _categoria;
            }
        }

        IDbSet<DetallePrestamo> _detallePrestamo;

        public IDbSet<DetallePrestamo> DetallePrestamo
        {
            get
            {
                if (_detallePrestamo == null)
                    _detallePrestamo = base.Set<DetallePrestamo>();

                return _detallePrestamo;
            }
        }

        IDbSet<Editorial> _editorial;

        public IDbSet<Editorial> Editorial
        {
            get
            {
                if (_editorial == null)
                    _editorial = base.Set<Editorial>();

                return _editorial;
            }
        }

        IDbSet<Ejemplar> _ejemplar;

        public IDbSet<Ejemplar> Ejemplar
        {
            get
            {
                if (_ejemplar == null)
                    _ejemplar = base.Set<Ejemplar>();

                return _ejemplar;
            }
        }

        IDbSet<EstadoEjemplar> _estadoEjemplar;

        public IDbSet<EstadoEjemplar> EstadoEjemplar
        {
            get
            {
                if (_estadoEjemplar == null)
                    _estadoEjemplar = base.Set<EstadoEjemplar>();

                return _estadoEjemplar;
            }
        }

        IDbSet<Idioma> _idioma;

        public IDbSet<Idioma> Idioma
        {
            get
            {
                if (_idioma == null)
                    _idioma = base.Set<Idioma>();

                return _idioma;
            }
        }

        IDbSet<Libro> _libro;

        public IDbSet<Libro> Libro
        {
            get
            {
                if (_libro == null)
                    _libro = base.Set<Libro>();

                return _libro;
            }
        }

        IDbSet<Pais> _pais;

        public IDbSet<Pais> Pais
        {
            get
            {
                if (_pais == null)
                    _pais = base.Set<Pais>();

                return _pais;
            }
        }

        IDbSet<Prestamo> _prestamo;

        public IDbSet<Prestamo> Prestamo
        {
            get
            {
                if (_prestamo == null)
                    _prestamo = base.Set<Prestamo>();

                return _prestamo;
            }
        }

        IDbSet<SubCategoria> _subCategoria;

        public IDbSet<SubCategoria> SubCategoria
        {
            get
            {
                if (_subCategoria == null)
                    _subCategoria = base.Set<SubCategoria>();

                return _subCategoria;
            }
        }

        IDbSet<SubSubCategoria> _subSubCategoria;

        public IDbSet<SubSubCategoria> SubSubCategoria
        {
            get
            {
                if (_subSubCategoria == null)
                    _subSubCategoria = base.Set<SubSubCategoria>();

                return _subSubCategoria;
            }
        }

        IDbSet<SubSubTema> _subSubTema;

        public IDbSet<SubSubTema> SubSubTema
        {
            get
            {
                if (_subSubTema == null)
                    _subSubTema = base.Set<SubSubTema>();

                return _subSubTema;
            }
        }

        IDbSet<SubTema> _subTema;

        public IDbSet<SubTema> SubTema
        {
            get
            {
                if (_subTema == null)
                    _subTema = base.Set<SubTema>();

                return _subTema;
            }
        }

        IDbSet<Tema> _tema;

        public IDbSet<Tema> Tema
        {
            get
            {
                if (_tema == null)
                    _tema = base.Set<Tema>();

                return _tema;
            }
        }

        IDbSet<TipoUsuario> _tipoUsuario;

        public IDbSet<TipoUsuario> TipoUsuario
        {
            get
            {
                if (_tipoUsuario == null)
                    _tipoUsuario = base.Set<TipoUsuario>();

                return _tipoUsuario;
            }
        }
        
        IDbSet<Usuario> _usuario;

        public IDbSet<Usuario> Usuario
        {
            get
            {
                if (_usuario == null)
                    _usuario = base.Set<Usuario>();

                return _usuario;
            }
        }
        
        IDbSet<Estado> _estado;

        public IDbSet<Estado> Estado
        {
            get
            {
                if (_estado == null)
                    _estado = base.Set<Estado>();

                return _estado;
            }
        }

        IDbSet<Municipio> _municipio;

        public IDbSet<Municipio> Municipio
        {
            get
            {
                if (_municipio == null)
                    _municipio = base.Set<Municipio>();

                return _municipio;
            }
        }

        IDbSet<CodigoPostal> _codigoPostal;

        public IDbSet<CodigoPostal> CodigoPostal
        {
            get
            {
                if (_codigoPostal == null)
                    _codigoPostal = base.Set<CodigoPostal>();

                return _codigoPostal;
            }
        }

        IDbSet<Asentamiento> _asentamiento;

        public IDbSet<Asentamiento> Asentamiento
        {
            get
            {
                if (_asentamiento == null)
                    _asentamiento = base.Set<Asentamiento>();

                return _asentamiento;
            }
        }
        
        // Sobreescribimos el método OnModelCreating de la clase DbContext
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configuration.AutoDetectChangesEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public void Attach<TEntity>(TEntity entity) where TEntity : class
        {
            if (Entry(entity).State == EntityState.Detached)
            {
                base.Set<TEntity>().Attach(entity);
            }
        }

        public IEnumerable<TEntity> ExecuteQuery<TEntity>(string sqlQuery, params object[] parameters)
        {
            return Database.SqlQuery<TEntity>(sqlQuery, parameters);
        }

        public int ExecuteCommand(string sqlCommand, params object[] parameters)
        {
            return Database.ExecuteSqlCommand(sqlCommand, parameters);
        }

        // Implementación de IUnitOfWork
        public void SetModified<TEntity>(TEntity entity) where TEntity : class
        {
            Entry(entity).State = EntityState.Modified;
        }

        public void Commit()
        {
            base.SaveChanges();
        }

        public void CommitAndRefreshChanges()
        {
            bool saveFailed = false;

            do
            {
                try
                {
                    base.SaveChanges();

                    saveFailed = false;

                }
                catch (DbUpdateConcurrencyException exception)
                {
                    saveFailed = true;

                    exception.Entries.ToList()
                                     .ForEach(entry =>
                                     {
                                         entry.OriginalValues.SetValues(entry.GetDatabaseValues());
                                     });
                }
            } while (saveFailed);
        }

        public void Rollback()
        {
            ChangeTracker.Entries()
                         .ToList()
                         .ForEach(entry => entry.State = EntityState.Unchanged);
        }

        public new void Dispose()
        {
            base.Dispose();
        }
    }
}