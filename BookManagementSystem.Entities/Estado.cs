using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagementSystem.Entities
{
    [Table("Estado")]
    public partial class Estado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [JsonProperty("id")]
        public virtual byte Id { get; set; }

        [JsonProperty("nombre")]
        public virtual string Nombre { get; set; }
    }
}