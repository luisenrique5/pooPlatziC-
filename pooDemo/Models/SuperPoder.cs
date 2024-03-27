namespace pooDemo.Models;

public class SuperPoder
{

    public string nombre;
    public string descripcion;
    public NivelPoder nivel;

    public SuperPoder()
    {
        descripcion = "Sin descripción";
        nivel = NivelPoder.Bajo;
    }

    public enum NivelPoder
    {
        Bajo = 1,
        Medio = 2,
        Alto = 3
    }
}
