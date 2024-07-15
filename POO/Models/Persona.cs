using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models;
public class Persona
{
    public string? Nombre { get; set; }
    public int Edad { get; set; }

    //Constructor en Persona
    // public Persona(string nombre, int edad)
    // {
    //     this.Nombre = nombre;
    //     this.Edad = edad;
    // }
    //Metodo en Persona
    public void Saludar()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
    }
    public void MostrarDetalle(){
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}".ToLower());
    }
}