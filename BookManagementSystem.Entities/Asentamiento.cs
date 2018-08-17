using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagementSystem.Entities
{
    [Table("Asentamiento")]
    public partial class Asentamiento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("codigo")]
        public virtual int Codigo { get; set; }

        [JsonProperty("nombre")]
        public virtual string Nombre { get; set; }
    }
}