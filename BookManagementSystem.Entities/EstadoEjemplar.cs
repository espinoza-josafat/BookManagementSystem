using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagementSystem.Entities
{
    [Table("EstadoEjemplar")]
    public partial class EstadoEjemplar
    {
        [Key]
        [JsonProperty("id")]
        public virtual byte Id { get; set; }

        [JsonProperty("descripcion")]
        public virtual string Descripcion { get; set; }
    }
}