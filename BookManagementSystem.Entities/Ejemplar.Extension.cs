using BookManagementSystem.Entities.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagementSystem.Entities
{
    public partial class Ejemplar
    {
        [NotMapped]
        [NotMapping]
        [JsonProperty("edicion")]
        public virtual bool Edicion { get; set; }
    }
}