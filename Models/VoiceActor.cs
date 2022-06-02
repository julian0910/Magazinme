using System.ComponentModel.DataAnnotations;

namespace Magazinme.Models
{
    /*Clase VoiceActor= info de los actores de voz */
    public class VoiceActor
    {
        [Key]
        public int id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Age { get; set; }
    }
}
