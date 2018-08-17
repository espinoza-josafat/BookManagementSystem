using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagementSystem.Entities
{
    [Table("SubSubCategoria")]
    public class SubSubCategoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("id_subcategoria")]
        public virtual int IdSubCategoria { get; set; }

        [JsonProperty("descripcion")]
        public virtual string Descripcion { get; set; }
    }
}