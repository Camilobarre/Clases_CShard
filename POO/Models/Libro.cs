using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models;
public class Libro
{
    public string? Titulo { get; set; }
    public string? Autor { get; set; }
    public void MostrarDetalles()
    {
        string tituloMayusculas = Titulo?.ToUpper(); // Convertir título a mayúsculas
        Console.WriteLine($"Título: {tituloMayusculas}, Autor: {Autor}");
    }
    public void ContarPalabras(){
        string[] palabras = Titulo?.Split(' '); // Dividir el título en palabras
        Console.WriteLine($"Cantidad de palabras en Titulo: {palabras?.Length?? 0}"); // Mostrar la cantidad de palabras o 0 si el título es null o vacío
    }
}