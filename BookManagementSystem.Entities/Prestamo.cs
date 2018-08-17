using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagementSystem.Entities
{
    [Table("Prestamo")]
    public class Prestamo
    {
        public Prestamo()
        {
            FechaEntrega = null;
            FechaDevolucion = null;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("fecha_prestamo")]
        public virtual DateTime FechaPrestamo { get; set; }

        [JsonProperty("fecha_entrega")]
        public virtual DateTime? FechaEntrega { get; set; }

        [JsonProperty("fecha_devolucion")]
        public virtual DateTime? FechaDevolucion { get; set; }

        [JsonProperty("id_usuario_prestado")]
        public virtual int IdUsuarioPrestado { get; set; }

        [JsonProperty("id_usuario_presta")]
        public virtual int IdUsuarioPresta { get; set; }

        [JsonProperty("cantidad_libros")]
        public virtual short CantidadLibros { get; set; }

        [JsonProperty("estatus")]
        public virtual byte Estatus { get; set; }
    }
}