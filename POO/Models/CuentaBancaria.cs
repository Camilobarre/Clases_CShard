using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models;
public class CuentaBancaria
{
    public string? Titular { get; set; }
    public double Saldo { get; set; }
    public void Depositar(double cantidad)
    {
        Saldo += cantidad;
        Console.WriteLine($"Se ha depositado ${cantidad}, su nuevo saldo es ${Saldo}");
    }
    public void Retirar(double cantidad)
    {
        if (Saldo >= cantidad)
        {
            Saldo -= cantidad;
            Console.WriteLine($"Se ha retirado ${cantidad}, su nuevo saldo es ${Saldo}");
        }
        else
        {
            Console.WriteLine("No hay suficiente saldo para retirar.");
        }
    }
}