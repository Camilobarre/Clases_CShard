using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models;
public class Producto
{
    public string? nombre;
    public double Precio { get; set; }
    public string? GetNombre()
    {
        return nombre;
    }

    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public void MostrarDetalle()
    {
        string nombreMinusculas = nombre?.ToLower();
        Console.WriteLine($"Nombre: {nombreMinusculas}, Precio: {Precio}");
    }
}