using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models;
public class Empleado
{
    public string? Nombre { get; set; }
    public string? Puesto { get; set; }
    public double Salario { get; set; }
    public void MostrarDetalle()
    {
        string? nombreMinusculas = Nombre?.ToLower();
        Console.WriteLine($"Nombre: {nombreMinusculas}, Puesto: {Puesto}, Salario: {Salario}");
    }
}