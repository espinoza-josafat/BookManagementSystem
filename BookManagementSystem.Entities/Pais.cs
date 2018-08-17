using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagementSystem.Entities
{
    [Table("Pais")]
    public class Pais
    {
        [Key]
        [JsonProperty("clave")]
        public virtual string Clave { get; set; }

        [JsonProperty("nombre")]
        public virtual string Nombre { get; set; }
    }
}