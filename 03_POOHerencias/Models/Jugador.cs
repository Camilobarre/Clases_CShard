using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_POOHerencias.Models;
public class Jugador: PersonalTecnico
{
    public string? Posicion { get; set; }
    public double Estatura { get; set; }
    public double Peso { get; set; }
    public string? ClubActual { get; set; }
    public string? PieHabil { get; set; }

    // public Jugador(string posicion, double estatura, double peso, string clubActual, string pieHabil)
    // {
    //     Posicion = posicion;
    //     Estatura = estatura;
    //     Peso = peso;
    //     ClubActual = clubActual;
    //     PieHabil = pieHabil;
    // }

    public double CalcularIMC()
    {
        return Peso / (Estatura * Estatura);
    }
}