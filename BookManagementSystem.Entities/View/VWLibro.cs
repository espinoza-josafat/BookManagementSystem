using Newtonsoft.Json;
using System;

namespace BookManagementSystem.Entities.View
{
    public class VWLibro
    {
        public VWLibro()
        {
            Editorial = null;
            NombreAutor = null;
            ApellidoPaternoAutor = null;
            ApellidoMaternoAutor = null;
            ClavePais = null;
            Pais = null;
            IdIdioma = null;
            AbreviacionIdioma = null;
            Idioma = null;
            IdCategoria = null;
            Categoria = null;
            IdSubCategoria = null;
            SubCategoria = null;
            IdSubSubCategoria = null;
            SubSubCategoria = null;
            IdTema = null;
            Tema = null;
            IdSubTema = null;
            SubTema = null;
            IdSubSubTema = null;
            SubSubTema = null;
            FechaPublicacion = null;
            Anio = null;
            Paginas = null;
            NumeroEdicion = null;
            NumeroEjemplares = null;
        }

        [JsonProperty("isbn")]
        public virtual long ISBN { get; set; }

        [JsonProperty("id_editorial")]
        public virtual short IdEditorial { get; set; }

        [JsonProperty("editorial")]
        public virtual string Editorial { get; set; }

        [JsonProperty("id_autor")]
        public virtual int IdAutor { get; set; }

        [JsonProperty("nombre_autor")]
        public virtual string NombreAutor { get; set; }

        [JsonProperty("apellido_paterno_autor")]
        public virtual string ApellidoPaternoAutor { get; set; }

        [JsonProperty("apellido_materno_autor")]
        public virtual string ApellidoMaternoAutor { get; set; }

        [JsonProperty("clave_pais")]
        public virtual string ClavePais { get; set; }

        [JsonProperty("pais")]
        public virtual string Pais { get; set; }

        [JsonProperty("id_idioma")]
        public virtual byte? IdIdioma { get; set; }

        [JsonProperty("abreviacion_idioma")]
        public virtual string AbreviacionIdioma { get; set; }

        [JsonProperty("idioma")]
        public virtual string Idioma { get; set; }

        [JsonProperty("id_categoria")]
        public virtual short? IdCategoria { get; set; }

        [JsonProperty("categoria")]
        public virtual string Categoria { get; set; }

        [JsonProperty("id_subcategoria")]
        public virtual int? IdSubCategoria { get; set; }

        [JsonProperty("subcategoria")]
        public virtual string SubCategoria { get; set; }

        [JsonProperty("id_subsubcategoria")]
        public virtual int? IdSubSubCategoria { get; set; }

        [JsonProperty("subsubcategoria")]
        public virtual string SubSubCategoria { get; set; }

        [JsonProperty("id_tema")]
        public virtual int? IdTema { get; set; }

        [JsonProperty("tema")]
        public virtual string Tema { get; set; }

        [JsonProperty("id_subtema")]
        public virtual long? IdSubTema { get; set; }

        [JsonProperty("subtema")]
        public virtual string SubTema { get; set; }

        [JsonProperty("id_subsubtema")]
        public virtual long? IdSubSubTema { get; set; }

        [JsonProperty("subsubtema")]
        public virtual string SubSubTema { get; set; }

        [JsonProperty("titulo")]
        public virtual string Titulo { get; set; }

        [JsonIgnore]
        public virtual DateTime? FechaPublicacion { get; set; }

        [JsonProperty("fecha_publicacion")]
        public virtual string sFechaPublicacion
        {
            get
            {
                return FechaPublicacion.HasValue ? FechaPublicacion.Value.ToString("dd/MM/yyyy") : null;
            }
        }

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