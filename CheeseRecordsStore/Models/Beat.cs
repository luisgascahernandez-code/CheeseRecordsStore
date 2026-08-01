using System.ComponentModel.DataAnnotations;

namespace CheeseRecordsStore.Models
{
    public class Artista
    {
        public int Id { get; set; }
        public string NombreArtistico { get; set; } = "";
        public string Rol { get; set; } = "";
        public List<Album> Albumes { get; set; } = new();
    }

    public class Genero
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public List<Beat> Beats { get; set; } = new();
    }

    public class Licencia
    {
        public int Id { get; set; }
        public string Tipo { get; set; } = "";
        public decimal Precio { get; set; }
        public List<Beat> Beats { get; set; } = new();
    }

    public class Album
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = "";
        public int ArtistaId { get; set; }
        public Artista Artista { get; set; } = null!;
        public List<Beat> Beats { get; set; } = new();
    }

    public class Beat
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; } = "";
        public string ImagenUrl { get; set; } = "";

        public string? Letra { get; set; }
        public string? NombresArtistas { get; set; }

        // Campo para el archivo de audio
        public string? AudioUrl { get; set; }

        // Relaciones (Claves foraneas)
        public int? GeneroId { get; set; }
        public Genero? Genero { get; set; }

        public int? AlbumId { get; set; }
        public Album? Album { get; set; }

        public int? LicenciaId { get; set; }
        public Licencia? Licencia { get; set; }
    }
}