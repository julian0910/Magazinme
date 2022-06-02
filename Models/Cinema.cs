using System.ComponentModel.DataAnnotations;

namespace Magazinme.Models
{
    /*Clase Cinema= ubicacion de los animes en cines*/
    public class Cinema
    {
        [Key]
        public int id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
