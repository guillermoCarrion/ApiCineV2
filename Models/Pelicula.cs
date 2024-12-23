
namespace ApiCineV2.Models;


public class Pelicula {

public int Id_pelicula {get;set;}
public string Nombre_pelicula {get;set;}
public string Director_pelicula{get;set;}
public string Sinopsis_pelicula {get;set;}
public string Fecha_estreno {get;set;}
public string Duracion_pelicula {get;set;}
public string Genero_pelicula {get;set;}
public List<Sesion> sesiones {get;set;} = new List<Sesion>();

}
