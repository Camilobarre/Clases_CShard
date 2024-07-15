using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models;
public class Calculadora
{
    public int a { get; set; }
    public int b { get; set; }
    public void Sumar()
    {
        int resultado = a + b;
        Console.WriteLine($"La suma de {a} y {b} es: {resultado}");
    }
    public void Restar()
    {
        int resultado = a - b;
        Console.WriteLine($"La resta de {a} y {b} es: {resultado}");
    }
}