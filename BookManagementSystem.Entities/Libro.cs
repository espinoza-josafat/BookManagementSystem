using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagementSystem.Entities
{
    [Table("Libro")]
    public partial class Libro
    {
        public Libro()
        {
            ClavePais = null;
            IdIdioma = null;
            IdCategoria = null;
            IdSubCategoria = null;
            IdSubSubCategoria = null;
            IdTema = null;
            IdSubTema = null;
            IdSubSubTema = null;
            FechaPublicacion = null;
            Anio = null;
            Paginas = null;
            NumeroEdicion = null;
            NumeroEjemplares = null;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [JsonProperty("isbn")]
        public virtual long ISBN { get; set; }

        [JsonProperty("id_editorial")]
        public virtual short IdEditorial { get; set; }

        [JsonProperty("id_autor")]
        public virtual int IdAutor { get; set; }

        [JsonProperty("clave_pais")]
        public virtual string ClavePais { get; set; }

        [JsonProperty("id_idioma")]
        public virtual byte? IdIdioma { get; set; }

        [JsonProperty("id_categoria")]
        public virtual short? IdCategoria { get; set; }

        [JsonProperty("id_subcategoria")]
        public virtual int? IdSubCategoria { get; set; }

        [JsonProperty("id_subsubcategoria")]
        public virtual int? IdSubSubCategoria { get; set; }

        [JsonProperty("id_tema")]
        public virtual int? IdTema { get; set; }

        [JsonProperty("id_subtema")]
        public virtual long? IdSubTema { get; set; }

        [JsonProperty("id_subsubtema")]
        public virtual long? IdSubSubTema { get; set; }

        [JsonProperty("titulo")]
        public virtual string Titulo { get; set; }

        [JsonProperty("fecha_publicacion")]
        public virtual DateTime? FechaPublicacion { get; set; }

        [JsonProperty("anio")]
        public virtual short? Anio { get; set; }

        [JsonProperty("paginas")]
        public virtual short? Paginas { get; set; }

        [JsonProperty("numero_edicion")]
        public virtual byte? NumeroEdicion { get; set; }

        [JsonProperty("numero_ejemplares")]
        public virtual short? NumeroEjemplares { get; set; }

        [JsonProperty("estatus")]
        public virtual byte Estatus { get; set; }
    }
}