using System.ComponentModel.DataAnnotations;

namespace Magazinme.Models
{
    /*Clase Producers=Info de la productora de anime*/
    public class Producers
    {
        [Key]
        public int id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string ProducerName { get; set; }
        public string Established { get; set; }
    }
}
