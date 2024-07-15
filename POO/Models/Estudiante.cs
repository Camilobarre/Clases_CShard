using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models;
public class Estudiante
{
    public string? Nombre { get; set; }
    public string? Grado { get; set; }
    public int Edad { get; set; }
    private int EdadNueva;
    public void MostrarDetalle()
    {
        string? nombreMinusculas = Nombre?.ToLower();
        Console.WriteLine($"Nombre: {nombreMinusculas}, Edad: {Edad}, Grado: {Grado}");
    }

    public int GetEdad()
    {
        return EdadNueva;
    }

    public void SetEdad(int EdadNueva)
    {
        if (EdadNueva >= 0)
        {
            this.EdadNueva = EdadNueva;
        }
        else
        {
            Console.WriteLine("La edad no puede ser negativa");
        }
    }
    public void MostrarDetallesSET()
    {
        string? nombreMinusculas = Nombre?.ToLower();
        Console.WriteLine($"Nombre: {nombreMinusculas}, Edad: {EdadNueva}, Grado: {Grado}");
    }
}