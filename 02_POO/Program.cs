using _02_POO.Models;

Console.Clear();

// Instanciando una clase
var estudianteNuevo = new Estudiante(1,"lucas","martinez",32,"lucas.martinez@gmail");

// estudianteNuevo.Id = 1;
// estudianteNuevo.Nombre = "lucas";
// estudianteNuevo.Apellido = "martinez";
// estudianteNuevo.Edad = 32;
// estudianteNuevo.Correo= "lucas.martinez@gmail.com";

Console.WriteLine(estudianteNuevo.Correo);
estudianteNuevo.Saludar();
estudianteNuevo.Despedir();

Console.WriteLine("----------------------------------------");

var empleadoNuevo = new Empleado("Juan", "Perez", "juan.perez@gmail", 5000000, 10);
var sueldoCompleto = empleadoNuevo.CalcularSueldoEmleado();
Console.WriteLine(sueldoCompleto);
empleadoNuevo.SueldoNetoEmpleado();
empleadoNuevo.DescontarSueldo();