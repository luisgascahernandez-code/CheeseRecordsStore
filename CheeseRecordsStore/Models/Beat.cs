using System.ComponentModel.DataAnnotations;

namespace CheeseRecordsStore.Models

{
    public enum GeneroMusical
    {
        Cumbia,
        Reggeaton,
        HipHop,
        Trap,
        Rap,
        Corridos,
        Dembow,
        RnB,
        Pop
    }
    public class Beat
    {
        public GeneroMusical Genero { get; set; }

        [Key] // Esto le dice a PostgreSQL que este es el ID principal
        public int Id { get; set; }

        [Required(ErrorMessage = "¡Hey! Olvidaste ponerle nombre al beat.")]
        public string Nombre { get; set; } = "";

        [Required(ErrorMessage = "El archivo de la portada es obligatorio.")]
        public string ImagenUrl { get; set; } = "";
    }
}