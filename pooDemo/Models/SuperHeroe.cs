using System.Text;

namespace pooDemo.Models;

public class SuperHeroe
{

    public int id;
    public string nombre;
    public string identidadSecreta;
    public string ciudad;
    public List<SuperPoder> superPoderes;
    public bool puedeVolar;

    public SuperHeroe()
    {
        id = 1;
        superPoderes = new List<SuperPoder>();
        puedeVolar = false;
    }

    public string usarSuperPoderes()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var poder in superPoderes)
        {
            sb.AppendLine($"{nombre} esta Usando el superpoder {poder.nombre}!!");
        }

        return sb.ToString();
    }

}