using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagementSystem.Entities
{
    [Table("Idioma")]
    public class Idioma
    {
        [Key]
        [JsonProperty("id")]
        public virtual byte Id { get; set; }

        [JsonProperty("abreviacion")]
        public virtual string Abreviacion { get; set; }

        [JsonProperty("descripcion")]
        public virtual string Descripcion { get; set; }
    }
}