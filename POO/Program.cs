using POO.Models;

Console.Clear();

// var miPrimerPersona = new PersonaPrueba(1,"Javier Combita Tellez","Masculino","Colombiana","3015465236","javier.combita@riwi.io","1996/07/12"); //Aca instanciamos una clase
// // miPrimerPersona.Id = 1;
// // miPrimerPersona.Nombre = "Javier Combita Tellez";
// // miPrimerPersona.Genero = "Masculino";
// // miPrimerPersona.Nacionalidad = "Colombiana";
// // miPrimerPersona.Telefono = "+57 301 2222 3333";
// // miPrimerPersona.Correo = "javier.combita@riwi.io";
// // miPrimerPersona.FechaDeNacimiento = "1998/04/23";
// miPrimerPersona.Saludar();

//Instancia Persona con metodo
var miPrimeraPersonaMetodo = new Persona();
miPrimeraPersonaMetodo.Nombre = "Camilo Barreneche Escobar";
miPrimeraPersonaMetodo.Edad = 28;
miPrimeraPersonaMetodo.Saludar();
miPrimeraPersonaMetodo.MostrarDetalle();

// //Instancia Persona con constructor
// var miPrimeraPersonaConstructor = new Persona ("Camilo Barreneche Escobar", 28 );
// miPrimeraPersonaConstructor.Saludar();

//Instancia Coche
var miPrimerCocheMetodo = new Coche();
miPrimerCocheMetodo.Marca = "Toyota";
miPrimerCocheMetodo.Modelo = 2022;
miPrimerCocheMetodo.Año = "2020";
miPrimerCocheMetodo.MostrarDetalles();
miPrimerCocheMetodo.ActualizarAño();

//Instancia Libro
var miPrimerLibroMetodo = new Libro();
miPrimerLibroMetodo.Titulo = "El Quijote de la Mancha";
miPrimerLibroMetodo.Autor = "Miguel de Cervantes";
miPrimerLibroMetodo.MostrarDetalles();
miPrimerLibroMetodo.ContarPalabras();

//Instancia Calculadora
var miprimeraCaculadora = new Calculadora();
miprimeraCaculadora.a = 5;
miprimeraCaculadora.b = 10;
miprimeraCaculadora.Sumar();
miprimeraCaculadora.Restar();

//Instancia Producto
var miPrimerProducto = new Producto();
miPrimerProducto.nombre = "LAPTOP"; //Nombre en mayúscula para comprobar que se convierta en minúsculas
miPrimerProducto.Precio = 15000;
miPrimerProducto.MostrarDetalle();

//Instancia Producto con metodo GET, SET
var miPrimerProductoMetodo = new Producto();
miPrimerProductoMetodo.nombre = "Mouse Gamer";
miPrimerProductoMetodo.Precio = 200;
miPrimerProductoMetodo.MostrarDetalle();


//Instancia CuentaBancaria
var miPrimeraCuentaBancaria = new CuentaBancaria();
miPrimeraCuentaBancaria.Titular = "Camilo Barreneche Escobar";
miPrimeraCuentaBancaria.Saldo = 10000;
miPrimeraCuentaBancaria.Depositar(500);
miPrimeraCuentaBancaria.Retirar(8000);

//Instancia Estudiante
var miPrimerEstudiante = new Estudiante();
miPrimerEstudiante.Nombre = "Camilo Barreneche Escobar";
miPrimerEstudiante.Edad = 28;
miPrimerEstudiante.Grado = "Developer Junior";
miPrimerEstudiante.MostrarDetalle();

//Instancia Estudiante con metodo GET, SET
var miPrimerEstudianteMetodo = new Estudiante();
miPrimerEstudianteMetodo.Nombre = "Javier Combita Tellez";
miPrimerEstudianteMetodo.Edad = 30;
miPrimerEstudianteMetodo.Grado = "Developer Senior";
miPrimerEstudianteMetodo.SetEdad(15);
miPrimerEstudianteMetodo.MostrarDetallesSET();

//Instancia Rectangulo
var miPrimerRectangulo = new Rectangulo();
miPrimerRectangulo.Ancho = 5;
miPrimerRectangulo.Largo = 10;
miPrimerRectangulo.CalcularArea();

//Instancia Circulo
var miPrimerCirculo = new Circulo();
miPrimerCirculo.Radio = 3;
miPrimerCirculo.CalcularCircunferencia();

// Instancia Empleado
var miPrimerEmpleado = new Empleado();
miPrimerEmpleado.Nombre = "Camilo Barreneche Escobar";
miPrimerEmpleado.Puesto = "Ingeniero";
miPrimerEmpleado.Salario = 5000;
miPrimerEmpleado.MostrarDetalle();