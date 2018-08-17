using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.Web.Models
{
    public class UserLoginModel
    {
        [Display(Name = "Usuario")]
        [JsonProperty(PropertyName = "user_name")]
        public string UserName { get; set; }

        [Display(Name = "Contraseña")]
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
    }
}