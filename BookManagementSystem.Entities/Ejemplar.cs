using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagementSystem.Entities
{
    [Table("Ejemplar")]
    public partial class Ejemplar
    {
        public Ejemplar()
        {
            Comentario = null;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [JsonProperty("codigo")]
        public virtual long Codigo { get; set; }

        [JsonProperty("isbn")]
        public virtual long ISBN { get; set; }

        [JsonProperty("id_estado_ejemplar")]
        public virtual byte IdEstadoEjemplar { get; set; }

        [JsonProperty("comentario")]
        public virtual string Comentario { get; set; }

        [JsonProperty("estatus")]
        public virtual byte Estatus { get; set; }
    }
}