using Newtonsoft.Json;

namespace BookManagementSystem.Entities.View
{
    public class VWEjemplar
    {
        public VWEjemplar()
        {
            Comentario = null;
        }

        [JsonProperty("codigo")]
        public virtual long Codigo { get; set; }

        [JsonProperty("isbn")]
        public virtual long ISBN { get; set; }

        [JsonProperty("id_estado_ejemplar")]
        public virtual byte IdEstadoEjemplar { get; set; }

        [JsonProperty("estado_ejemplar")]
        public virtual string EstadoEjemplar { get; set; }

        [JsonProperty("comentario")]
        public virtual string Comentario { get; set; }

        [JsonProperty("estatus")]
        public virtual byte Estatus { get; set; }
    }
}