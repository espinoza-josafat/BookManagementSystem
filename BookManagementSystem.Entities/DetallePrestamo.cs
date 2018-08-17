using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagementSystem.Entities
{
    [Table("DetallePrestamo")]
    public class DetallePrestamo
    {
        public DetallePrestamo()
        {
            FechaEntrega = null;
            FechaDevolucion = null;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty("id")]
        public virtual long Id { get; set; }

        [JsonProperty("id_prestamo")]
        public virtual int IdPrestamo { get; set; }

        [JsonProperty("fecha_entrega")]
        public virtual DateTime? FechaEntrega { get; set; }

        [JsonProperty("fecha_devolucion")]
        public virtual DateTime? FechaDevolucion { get; set; }

        [JsonProperty("codigo")]
        public virtual long Codigo { get; set; }

        [JsonProperty("estatus")]
        public virtual byte Estatus { get; set; }
    }
}