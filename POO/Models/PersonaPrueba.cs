using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models;
public class PersonaPrueba
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Genero { get; set; }

    public string? Nacionalidad { get; set; }
    public string? Telefono { get; set; }
    public string? Correo { get; set; }
    public string? FechaDeNacimiento { get; set; }
    //Creamos un constructor (Su nombre debe ser el mismo que la clase)
    public PersonaPrueba(int id, string nombre, string genero, string nacionalidad, string telefono, string correo, string fechaDeNacimiento)
    {
        this.Id=id;
        this.Nombre=nombre;
        this.Genero=genero;
        this.Nacionalidad=nacionalidad;
        this.Telefono=telefono;
        this.Correo=correo;
        this.FechaDeNacimiento=fechaDeNacimiento;
    }
    //Creamos una metodo para saludar (Se usa Void cuando no retorna nada)
    public void Saludar()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre}");
    }
}
