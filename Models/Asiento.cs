namespace ApiCineV2.Models; 

public class Asiento
{
    public int IdAsiento { get; set; }
    public int Precio {get; set;} //=/?
    public int Fila { get; set; }
    public int Columna { get; set; }
    
    
    public bool EstaReservado { get; set; } = false;

     public Asiento(int id, int fila, int columna) {
        IdAsiento = id;
        Fila = fila;
        Columna = columna;
    }
}