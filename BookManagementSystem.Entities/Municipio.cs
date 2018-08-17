using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagementSystem.Entities
{
    [Table("Municipio")]
    public partial class Municipio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty("id")]
        public virtual short Id { get; set; }

        [JsonProperty("id_estado")]
        public virtual byte IdEstado { get; set; }

        [JsonProperty("nombre")]
        public virtual string Nombre { get; set; }
    }
}