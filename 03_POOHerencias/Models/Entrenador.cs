using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_POOHerencias.Models;
public class Entrenador
{
    public byte ExperienciaEnAños { get; set; }
    public byte CantidadTitulos { get; set; }
    public double Salario { get; set; }
    public string Nacionalidad { get; set; }

    public Entrenador(byte experienciaEnAños, byte cantidadTitulos, double salario, string nacionalidad)
    {
        ExperienciaEnAños = experienciaEnAños;
        CantidadTitulos = cantidadTitulos;
        Salario = salario;
        Nacionalidad = nacionalidad;
    }
}