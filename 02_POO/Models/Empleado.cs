using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;

namespace _02_POO.Models;
public class Empleado
{
    private Guid Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Correo { get; set; }
    private double SueldoBase { get; set; }
    public double PorcentajePension { get; set; }
    public double PorcentajeSalud { get; set; }
    private double PorcentajeAhorroCooperativa { get; set; }

    public Empleado(string nombre, string apellido, string correo, double sueldoBase, double porcentajeAhorroCooperativa)
    {
        this.Id = Guid.NewGuid();
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Correo = correo;
        this.SueldoBase = sueldoBase;
        this.PorcentajePension = 4;
        this.PorcentajeSalud = 4;
        this.PorcentajeAhorroCooperativa = porcentajeAhorroCooperativa;
    }
    public double SueldoNetoEmpleado()
    {
        Console.WriteLine($"Hola {this.Nombre}{this.Apellido}, tu sueldo es de {this.SueldoBase}");
        return this.SueldoBase;
    }
    public void DescontarSueldo()
    {
        Console.WriteLine($"Te descuentan {this.PorcentajePension}% de pension y {this.PorcentajeSalud}% de salud");
    }
    public double CalcularSueldoEmleado()
    {
        return this.SueldoBase - CalcularDeducciones() - CalcularAhorro();
    }
    private double CalcularDeducciones()
    {
        return (this.SueldoBase * this.PorcentajePension / 100) + (this.SueldoBase * this.PorcentajeSalud / 100);
    }
    private double CalcularAhorro()
    {
        return this.SueldoBase * this.PorcentajeAhorroCooperativa / 100;
    }
}