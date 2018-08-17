using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagementSystem.Entities
{
    [Table("SubCategoria")]
    public class SubCategoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("id_categoria")]
        public virtual short IdCategoria { get; set; }

        [JsonProperty("descripcion")]
        public virtual string Descripcion { get; set; }
    }
}