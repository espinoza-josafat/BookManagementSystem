using BookManagementSystem.Entities.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagementSystem.Entities
{
    [Table("PROCESAMIENTO_OCR_TRANSFER", Schema = "METEPECDIG_USR")]
    public class ProcesamientoOcrTransfer
    {
        public ProcesamientoOcrTransfer()
        {
            Nunicodoc = null;
            Nunicodoct = null;
            Doccod = null;
            Nroidentdoc = null;
            Nroreferenc = null;
            IdImagen = null;
            IdPila = null;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("PT_ID")]
        [Mapping("PT_ID")]
        public long Id { get; set; }

        [Column("PT_RUTA")]
        [Mapping("PT_RUTA")]
        public string Ruta { get; set; }

        [Column("PT_NOMBRE_ARCHIVO")]
        [Mapping("PT_NOMBRE_ARCHIVO")]
        public string NombreArchivo { get; set; }

        [Column("PT_BUCKET")]
        [Mapping("PT_BUCKET")]
        public string Bucket { get; set; }

        [Column("PT_SCLTCOD")]
        [Mapping("PT_SCLTCOD")]
        public short Scltcod { get; set; }

        [Column("PT_IDOPERATORIA")]
        [Mapping("PT_IDOPERATORIA")]
        public int IdOperatoria { get; set; }

        [Column("PT_NUNICODOC")]
        [Mapping("PT_NUNICODOC")]
        public long? Nunicodoc { get; set; }

        [Column("PT_NUNICODOCT")]
        [Mapping("PT_NUNICODOCT")]
        public long? Nunicodoct { get; set; }

        [Column("PT_DOCCOD")]
        [Mapping("PT_DOCCOD")]
        public int? Doccod { get; set; }

        [Column("PT_NROIDENTDOC")]
        [Mapping("PT_NROIDENTDOC")]
        public string Nroidentdoc { get; set; }

        [Column("PT_NROREFERENC")]
        [Mapping("PT_NROREFERENC")]
        public string Nroreferenc { get; set; }

        [Column("PT_IDIMAGEN")]
        [Mapping("PT_IDIMAGEN")]
        public long? IdImagen { get; set; }

        [Column("PT_ESTATUS")]
        [Mapping("PT_ESTATUS")]
        public byte Estatus { get; set; }

        [Column("PT_FECHA")]
        [Mapping("PT_FECHA")]
        public DateTime Fecha { get; set; }

        [Column("PT_IDPILA")]
        [Mapping("PT_IDPILA")]
        public long? IdPila { get; set; }
    }
}