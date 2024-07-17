using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace _03_POOHerencias.Models;
public class PersonalTecnico
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public string? TipoDocumento { get; set; }
    public string? NumeroDocumento { get; set; }
    public DateOnly FechaNacimiento { get; set; }
    protected string? RH { get; set; }
    public string? TallaSuperior { get; set; }
    public string? TallaInferior { get; set; }
    public double TallaZapatos { get; set; }

    public PersonalTecnico(int id, string nombre, string apellido, string tipoDocumento, string numeroDocumento, DateOnly fechaNacimiento, string rh, string tallaSuperior, string tallaInferior, double tallaZapatos)
    {
        Id = Id;
        Nombre = nombre;
        Apellido = apellido;
        TipoDocumento = tipoDocumento;
        NumeroDocumento = numeroDocumento;
        FechaNacimiento = fechaNacimiento;
        RH = rh;
        TallaSuperior = tallaSuperior;
        TallaInferior = tallaInferior;
        TallaZapatos = tallaZapatos;
    }

    public byte CalcularEdad(){
        return (byte)(DateTime.Now.Year - FechaNacimiento.Year);
    }
}