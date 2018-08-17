using BookManagementSystem.Entities.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagementSystem.Entities
{
    [Table("PROCESAMIENTO_TRANSFORM", Schema = "METEPECDIG_USR")]
    public class ProcesamientoTransform
    {
        public ProcesamientoTransform()
        {
            IdOperatoria = null;
            Nunicodoct = null;
            Doccod = null;
            Nroidentdoc = null;
            Nroreferenc = null;
            FechaFin = null;
            RutaLocal = null;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID")]
        [Mapping("ID")]
        public virtual long Id { get; set; }

        [Column("RUTA")]
        [Mapping("RUTA")]
        public virtual string Ruta { get; set; }

        [Column("NOMBRE_ARCHIVO")]
        [Mapping("NOMBRE_ARCHIVO")]
        public virtual string NombreArchivo { get; set; }

        [Column("BUCKET")]
        [Mapping("BUCKET")]
        public virtual string Bucket { get; set; }

        [Column("SCLTCOD")]
        [Mapping("SCLTCOD")]
        public virtual short Scltcod { get; set; }

        [Column("IDOPERATORIA")]
        [Mapping("IDOPERATORIA")]
        public virtual int? IdOperatoria { get; set; }

        [Column("NUNICODOC")]
        [Mapping("NUNICODOC")]
        public virtual long Nunicodoc { get; set; }

        [Column("NUNICODOCT")]
        [Mapping("NUNICODOCT")]
        public virtual long? Nunicodoct { get; set; }

        [Column("DOCCOD")]
        [Mapping("DOCCOD")]
        public virtual int? Doccod { get; set; }

        [Column("NROIDENTDOC")]
        [Mapping("NROIDENTDOC")]
        public virtual string Nroidentdoc { get; set; }

        [Column("NROREFERENC")]
        [Mapping("NROREFERENC")]
        public virtual string Nroreferenc { get; set; }

        [Column("ESTATUS")]
        [Mapping("ESTATUS")]
        public virtual short Estatus { get; set; }

        [Column("FECHA_INICIO")]
        [Mapping("FECHA_INICIO")]
        public virtual DateTime FechaInicio { get; set; }

        [Column("FECHA_FIN")]
        [Mapping("FECHA_FIN")]
        public virtual DateTime? FechaFin { get; set; }

        [Column("RUTA_LOCAL")]
        [Mapping("RUTA_LOCAL")]
        public virtual string RutaLocal { get; set; }
    }
}