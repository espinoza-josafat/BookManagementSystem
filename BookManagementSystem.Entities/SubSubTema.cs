using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagementSystem.Entities
{
    [Table("SubSubTema")]
    public class SubSubTema
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty("id")]
        public virtual long Id { get; set; }

        [JsonProperty("id_subtema")]
        public virtual long IdSubTema { get; set; }

        [JsonProperty("descripcion")]
        public virtual string Descripcion { get; set; }
    }
}