using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models;
public class Coche
{
    public string? Marca { get; set; }
    public int Modelo { get; set; }
    public string? Año { get; set; }
    public void MostrarDetalles()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Año}");
    }
    public void ActualizarAño()
    {
        Año = "2021";
        Console.WriteLine($"El año del coche ha sido actualizado a {Año}");
    }
}