
namespace ApiCineV2.Models;

public class Pelicula
{
    public int Id_pelicula { get; set; }
    public string Nombre_pelicula { get; set; }
    public string Director_pelicula { get; set; }
    public string Sinopsis_pelicula { get; set; }
    public string Fecha_estreno { get; set; }
    public string Duracion_pelicula { get; set; }
    public string Genero_pelicula { get; set; }
    public List<Sesion> sesiones { get; set; } = new List<Sesion>();

    // Constructor
    public Pelicula(int id_pelicula, string nombre_pelicula, string director_pelicula, string sinopsis_pelicula, string fecha_estreno, string duracion_pelicula, string genero_pelicula)
    {
        Id_pelicula = id_pelicula;
        Nombre_pelicula = nombre_pelicula;
        Director_pelicula = director_pelicula;
        Sinopsis_pelicula = sinopsis_pelicula;
        Fecha_estreno = fecha_estreno;
        Duracion_pelicula = duracion_pelicula;
        Genero_pelicula = genero_pelicula;
    }
}