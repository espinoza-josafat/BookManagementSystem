using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagementSystem.Entities
{
    [Table("CodigoPostal")]
    public partial class CodigoPostal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [JsonProperty("codigo")]
        public virtual int Codigo { get; set; }

        [JsonProperty("id_municipio")]
        public virtual short IdMunicipio { get; set; }
    }
}