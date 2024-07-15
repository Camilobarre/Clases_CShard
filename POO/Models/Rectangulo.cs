using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models;
public class Rectangulo
{
    public double Ancho { get; set; }
    public double Largo { get; set; }
    public void CalcularArea()
    {
        Console.WriteLine($"El área del rectángulo es: {Ancho * Largo}");
    }
}