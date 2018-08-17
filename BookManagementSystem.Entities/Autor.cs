using BookManagementSystem.Entities.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagementSystem.Entities
{
    [Table("Autor")]
    public class Autor
    {
        public Autor()
        {
            ApellidoMaterno = null;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("nombre")]
        public virtual string Nombre { get; set; }

        [JsonProperty("apellido_paterno")]
        public virtual string ApellidoPaterno { get; set; }

        [JsonProperty("apellido_materno")]
        public virtual string ApellidoMaterno { get; set; }

        [NotMapped]
        [NotMapping]
        [JsonProperty("nombre_completo")]
        public string NombreCompleto
        {
            get
            {
                return ((string.IsNullOrWhiteSpace(Nombre) ? string.Empty : (Nombre.Trim())) + " " + (string.IsNullOrWhiteSpace(ApellidoPaterno) ? string.Empty : (ApellidoPaterno.Trim())) + " " + (string.IsNullOrWhiteSpace(ApellidoMaterno) ? string.Empty : (ApellidoMaterno.Trim()))).Trim();
            }
        }
    }
}