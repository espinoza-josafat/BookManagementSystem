using BookManagementSystem.Entities.Attributes;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagementSystem.Entities
{
    [Table("Usuario")]
    public partial class Usuario
    {
        public Usuario()
        {
            ApellidoMaterno = null;
            Username = null;
            Password = null;
            Alta = null;
            Modificacion = null;
            UltimaModificacionPassword = null;
            UltimaAutenticacionValida = null;
            NumeroFallosAutenticacion = null;
            RecuperacionPassword = null;
            Nacimiento = null;
            NoExterior = null;
            NoInterior = null;
            Calle = null;
            Referencia = null;
            Telefono1 = null;
            Telefono2 = null;
            Telefono3 = null;
            CorreoElectronico1 = null;
            CorreoElectronico2 = null;
            CorreoElectronico3 = null;
            MotivoSuspencion = null;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("id_tipo_usuario")]
        public virtual byte IdTipoUsuario { get; set; }

        [JsonProperty("id_asentamiento")]
        public virtual int IdAsentamiento { get; set; }

        [JsonProperty("nombre")]
        public virtual string Nombre { get; set; }

        [JsonProperty("apellido_paterno")]
        public virtual string ApellidoPaterno { get; set; }

        [JsonProperty("apellido_materno")]
        public virtual string ApellidoMaterno { get; set; }

        [JsonProperty("username")]
        public virtual string Username { get; set; }

        [JsonProperty("password")]
        public virtual string Password { get; set; }

        [JsonProperty("alta")]
        public virtual DateTime? Alta { get; set; }

        [JsonProperty("modificacion")]
        public virtual DateTime? Modificacion { get; set; }

        [JsonProperty("ultima_modificacion_password")]
        public virtual DateTime? UltimaModificacionPassword { get; set; }

        [JsonProperty("ultima_autenticacion_valida")]
        public virtual DateTime? UltimaAutenticacionValida { get; set; }

        [JsonProperty("numero_fallos_autenticacion")]
        public virtual int? NumeroFallosAutenticacion { get; set; }

        [JsonProperty("recuperacion_password")]
        public virtual bool? RecuperacionPassword { get; set; }

        [JsonProperty("nacimiento")]
        public virtual DateTime? Nacimiento { get; set; }
        
        [JsonProperty("no_exterior")]
        public virtual string NoExterior { get; set; }

        [JsonProperty("no_interior")]
        public virtual string NoInterior { get; set; }

        [JsonProperty("calle")]
        public virtual string Calle { get; set; }
        
        [JsonProperty("referencia")]
        public virtual string Referencia { get; set; }
        
        [JsonProperty("telefono_1")]
        public virtual string Telefono1 { get; set; }

        [JsonProperty("telefono_2")]
        public virtual string Telefono2 { get; set; }

        [JsonProperty("telefono_3")]
        public virtual string Telefono3 { get; set; }

        [JsonProperty("correo_electronico_1")]
        public virtual string CorreoElectronico1 { get; set; }

        [JsonProperty("correo_electronico_2")]
        public virtual string CorreoElectronico2 { get; set; }

        [JsonProperty("correo_electronico_3")]
        public virtual string CorreoElectronico3 { get; set; }

        [JsonProperty("esta_suspendido")]
        public virtual bool EstaSuspendido { get; set; }

        [JsonProperty("motivo_suspencion")]
        public virtual string MotivoSuspencion { get; set; }

        [JsonProperty("esta_bloqueado")]
        public virtual bool EstaBloqueado { get; set; }

        [JsonProperty("activo")]
        public virtual bool Activo { get; set; }

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