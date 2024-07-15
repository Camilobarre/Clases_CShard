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
var miPrimeraPersonaMetodo = new Persona ();
miPrimeraPersonaMetodo.Nombre = "Camilo Barreneche Escobar";
miPrimeraPersonaMetodo.Edad = 28;
miPrimeraPersonaMetodo.Saludar();
miPrimeraPersonaMetodo.MostrarDetalle();

// //Instancia Persona con constructor
// var miPrimeraPersonaConstructor = new Persona ("Camilo Barreneche Escobar", 28 );
// miPrimeraPersonaConstructor.Saludar();

//Instancia Coche
var miPrimerCocheMetodo= new Coche();
miPrimerCocheMetodo.Marca = "Toyota";
miPrimerCocheMetodo.Modelo = 2022;
miPrimerCocheMetodo.Año="2020";
miPrimerCocheMetodo.MostrarDetalles();
miPrimerCocheMetodo.ActualizarAño();

//Instancia Libro
var miPrimerLibroMetodo= new Libro();
miPrimerLibroMetodo.Titulo = "El Quijote de la Mancha";
miPrimerLibroMetodo.Autor = "Miguel de Cervantes";
miPrimerLibroMetodo.MostrarDetalles();
miPrimerLibroMetodo.ContarPalabras();