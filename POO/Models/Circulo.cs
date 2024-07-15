using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models;
public class Circulo
{
    public double Radio { get; set; }
    public void CalcularCircunferencia()
    {
        Console.WriteLine($"La circunferencia del círculo es: {2 * Math.PI * Radio:F2}"); //F2 redondea a 2 decimales
    }
}