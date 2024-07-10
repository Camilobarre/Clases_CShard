// // Ejercicio 1: Filtra los números mayores a 10 en una lista de enteros.
// List<int> numeros = new List<int> { 5, 12, 18, 3, 7, 22, 9, 10 };
// var mayoresA10 = numeros.Where(n => n > 10).ToList();
// Console.WriteLine("Números mayores a 10: " + string.Join(", ", mayoresA10));

// // Ejercicio 2: Obtén una lista con los cuadrados de cada número en una lista de enteros.
// var cuadrados = numeros.Select(n => n * n).ToList();
// Console.WriteLine("Cuadrados de los números: " + string.Join(", ", cuadrados));

// // Ejercicio 3: Ordena alfabéticamente una lista de nombres.
// List<string> nombres = new List<string> { "Carlos", "Ana", "Pedro", "Juan", "Lucía" };
// var nombresOrdenados = nombres.OrderBy(n => n).ToList();
// Console.WriteLine("Nombres ordenados: " + string.Join(", ", nombresOrdenados));

// // Ejercicio 4: Ordena una lista de precios de mayor a menor.
// List<decimal> precios = new List<decimal> { 10.99m, 5.50m, 20.00m, 7.75m };
// var preciosOrdenados = precios.OrderByDescending(p => p).ToList();
// Console.WriteLine("Precios ordenados de mayor a menor: " + string.Join(", ", preciosOrdenados));

// // Ejercicio 5: Encuentra el primer número par en una lista de enteros.
// var primerPar = numeros.FirstOrDefault(n => n % 2 == 0);
// Console.WriteLine("Primer número par: " + primerPar);

// // Ejercicio 6: Encuentra el último nombre en una lista de nombres.
// var ultimoNombre = nombres.LastOrDefault();
// Console.WriteLine("Último nombre: " + ultimoNombre);

// // Ejercicio 7: Obtén el primer número negativo en una lista de enteros, o un valor por defecto si no hay ninguno.
// List<int> numerosConNegativos = new List<int> { 5, 12, -18, 3, -7, 22, 9, 10 };
// var primerNegativo = numerosConNegativos.FirstOrDefault(n => n < 0);
// Console.WriteLine("Primer número negativo: " + primerNegativo);

// // Ejercicio 8: Encuentra el último número mayor a 50 en una lista de enteros, o un valor por defecto si no hay ninguno.
// var ultimoMayorA50 = numeros.LastOrDefault(n => n > 50);
// Console.WriteLine("Último número mayor a 50: " + ultimoMayorA50);

// // Ejercicio 9: Verifica si algún elemento en una lista de booleanos es verdadero.
// List<bool> booleanos = new List<bool> { false, false, true, false };
// var algunVerdadero = booleanos.Any(b => b);
// Console.WriteLine("¿Algún elemento es verdadero? " + algunVerdadero);

// // Ejercicio 10: Verifica si todos los elementos en una lista de números son mayores a 0.
// var todosMayoresACero = numeros.All(n => n > 0);
// Console.WriteLine("¿Todos los números son mayores a 0? " + todosMayoresACero);

// // Ejercicio 11: Comprueba si una lista de palabras contiene la palabra "LINQ".
// List<string> palabras = new List<string> { "C#", "LINQ", "EntityFramework", "ASP.NET" };
// var contieneLINQ = palabras.Contains("LINQ");
// Console.WriteLine("¿La lista contiene la palabra 'LINQ'? " + contieneLINQ);

// // Ejercicio 12: Cuenta cuántos números pares hay en una lista de enteros.
// var cantidadPares = numeros.Count(n => n % 2 == 0);
// Console.WriteLine("Cantidad de números pares: " + cantidadPares);

// // Ejercicio 13: Calcula la suma de los elementos en una lista de precios.
// var sumaPrecios = precios.Sum();
// Console.WriteLine("Suma de los precios: " + sumaPrecios);

// // Ejercicio 14: Calcula el promedio de una lista de edades.
// List<int> edades = new List<int> { 25, 30, 35, 40, 45 };
// var promedioEdades = edades.Average();
// Console.WriteLine("Promedio de las edades: " + promedioEdades);

// // Ejercicio 15: Encuentra el número mínimo en una lista de temperaturas.
// List<int> temperaturas = new List<int> { 15, 20, 12, 25, 18 };
// var temperaturaMinima = temperaturas.Min();
// Console.WriteLine("Temperatura mínima: " + temperaturaMinima);

// // Ejercicio 16: Encuentra el número máximo en una lista de alturas.
// List<int> alturas = new List<int> { 160, 175, 180, 165, 170 };
// var alturaMaxima = alturas.Max();
// Console.WriteLine("Altura máxima: " + alturaMaxima);

// // Ejercicio 17: Obtén los primeros 5 elementos de una lista de puntuaciones.
// List<int> puntuaciones = new List<int> { 85, 92, 78, 90, 88, 76, 95, 89 };
// var primeros5 = puntuaciones.Take(5).ToList();
// Console.WriteLine("Primeros 5 elementos: " + string.Join(", ", primeros5));

// // Ejercicio 18: Salta los primeros 3 elementos de una lista de nombres y obtén los siguientes.
// List<string> nombresNuevos = new List<string> { "Carlos", "Ana", "Pedro", "Juan", "Lucía" };
// var skip3 = nombresNuevos.Skip(3).ToList();
// Console.WriteLine("Después de saltar los primeros 3: " + string.Join(", ", skip3));

// // Ejercicio 19: Elimina los elementos duplicados en una lista de números.
// List<int> numerosConDuplicados = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
// var sinDuplicados = numerosConDuplicados.Distinct().ToList();
// Console.WriteLine("Sin duplicados: " + string.Join(", ", sinDuplicados));

// // Ejercicio 20: Convierte una lista de palabras en una lista (la lista ya está en formato de lista).
// List<string> palabrasNuevas = new List<string> { "LINQ", "es", "muy", "útil" };
// var listaPalabras = palabrasNuevas.ToList();
// Console.WriteLine("Lista de palabras: " + string.Join(", ", listaPalabras));

// // Ejercicio 21: Convierte una lista de números en un array.
// List<int> numerosNuevos = new List<int> { 5, 12, 18, 3, 7, 22, 9, 10 };
// var arrayNumeros = numerosNuevos.ToArray();
// Console.WriteLine("Array de números: " + string.Join(", ", arrayNumeros));

// // Ejercicio 22: Filtra los números negativos de una lista y ordénalos de menor a mayor.
// List<int> numerosConNegativosNuevos = new List<int> { 5, -12, 18, -3, 7, -22, 9, -10 };
// var negativosOrdenados = numerosConNegativosNuevos.Where(n => n < 0).OrderBy(n => n).ToList();
// Console.WriteLine("Números negativos ordenados: " + string.Join(", ", negativosOrdenados));

// // Ejercicio 23: Obtén una lista de longitudes de cada palabra en una lista de palabras.
// var longitudes = palabras.Select(p => p.Length).ToList();
// Console.WriteLine("Longitudes de las palabras: " + string.Join(", ", longitudes));

// // Ejercicio 24: Ordena una lista de salarios de menor a mayor y obtén los 3 más bajos.
// List<decimal> salarios = new List<decimal> { 3000m, 2500m, 4000m, 3200m, 2800m };
// var tresMasBajos = salarios.OrderBy(s => s).Take(3).ToList();
// Console.WriteLine("Tres salarios más bajos: " + string.Join(", ", tresMasBajos));

// // Ejercicio 25: Obtén los nombres más largos en una lista de nombres.
// var nombresMasLargos = nombres.OrderByDescending(n => n.Length).ToList();
// Console.WriteLine("Nombres más largos: " + string.Join(", ", nombresMasLargos));

// // Ejercicio 26: Encuentra el primer número mayor a 100 en una lista de precios.
// List<decimal> preciosNuevos = new List<decimal> { 85.5m, 120.75m, 95.0m, 150.0m, 200.5m };
// var primerMayorA100 = preciosNuevos.FirstOrDefault(p => p > 100);
// Console.WriteLine("Primer precio mayor a 100: " + primerMayorA100);

// // Ejercicio 27: Encuentra el último día del mes en una lista de fechas.
// List<DateTime> fechas = new List<DateTime>
// {
//     new DateTime(2024, 7, 1),
//     new DateTime(2024, 7, 15),
//     new DateTime(2024, 7, 31),
//     new DateTime(2024, 6, 30)
// };
// var ultimoDiaDelMes = fechas.LastOrDefault(f => f.Day == DateTime.DaysInMonth(f.Year, f.Month));
// Console.WriteLine("Último día del mes: " + ultimoDiaDelMes.ToShortDateString());

// // Ejercicio 28: Obtén el primer nombre que empieza con 'A' en una lista de nombres o un valor por defecto si no hay ninguno.
// var primerNombreConA = nombres.FirstOrDefault(n => n.StartsWith("A"));
// Console.WriteLine("Primer nombre que empieza con 'A': " + (primerNombreConA ?? "Ninguno"));

// // 29. Encuentra el último número impar en una lista de enteros o un valor por defecto si no hay ninguno.
// var ultimoImpar = numeros.LastOrDefault(n => n % 2 != 0);
// Console.WriteLine("Último número impar: " + ultimoImpar);

// // Ejercicio 30: Verifica si alguna palabra en una lista de palabras tiene más de 10 caracteres.
// List<string> palabrasOtras = new List<string> { "LINQ", "programming", "extraordinary", "useful" };
// var algunaLarga = palabrasOtras.Any(p => p.Length > 10);
// Console.WriteLine("¿Alguna palabra tiene más de 10 caracteres? " + algunaLarga);

// // Ejercicio 31: Verifica si todas las edades en una lista son mayores de 18.
// List<int> edadesNuevas = new List<int> { 20, 25, 30, 17, 19 };
// var todasMayoresDe18 = edadesNuevas.All(e => e > 18);
// Console.WriteLine("¿Todas las edades son mayores de 18? " + todasMayoresDe18);

// // Ejercicio 32: Comprueba si una lista de ciudades contiene la ciudad "Madrid".
// List<string> ciudades = new List<string> { "Barcelona", "Valencia", "Madrid", "Sevilla" };
// var contieneMadrid = ciudades.Contains("Madrid");
// Console.WriteLine("¿La lista contiene la ciudad 'Madrid'? " + contieneMadrid);

// // Ejercicio 33: Cuenta cuántos números mayores a 50 hay en una lista de puntuaciones.
// List<int> puntuacionesNuevas = new List<int> { 85, 45, 78, 55, 62, 49, 51 };
// var cantidadMayoresA50 = puntuacionesNuevas.Count(p => p > 50);
// Console.WriteLine("Cantidad de puntuaciones mayores a 50: " + cantidadMayoresA50);

// // Ejercicio 34: Calcula la suma de los números positivos en una lista de enteros.
// List<int> numerosOtros = new List<int> { -5, 12, 18, -3, 7, -22, 9, 10 };
// var sumaPositivos = numerosOtros.Where(n => n > 0).Sum();
// Console.WriteLine("Suma de los números positivos: " + sumaPositivos);

// // Ejercicio 35: Calcula el promedio de las calificaciones en una lista de calificaciones.
// List<int> calificaciones = new List<int> { 85, 90, 78, 92, 88 };
// var promedioCalificaciones = calificaciones.Average();
// Console.WriteLine("Promedio de las calificaciones: " + promedioCalificaciones);

// // Ejercicio 36: Encuentra la temperatura mínima en una lista de temperaturas.
// List<int> temperaturasNuevas = new List<int> { 15, 20, 12, 25, 18 };
// var temperaturaMinimaNueva = temperaturas.Min();
// Console.WriteLine("Temperatura mínima: " + temperaturaMinimaNueva);

// // Ejercicio 37: Encuentra la altura máxima en una lista de alturas.
// List<int> alturasNuevas = new List<int> { 160, 175, 180, 165, 170 };
// var alturaMaximaNueva = alturasNuevas.Max();
// Console.WriteLine("Altura máxima: " + alturaMaximaNueva);

// // Ejercicio 38: Obtén los primeros 10 elementos de una lista de productos.
// List<string> productos = new List<string> { "Producto1", "Producto2", "Producto3", "Producto4", "Producto5", "Producto6", "Producto7", "Producto8", "Producto9", "Producto10", "Producto11" };
// var primeros10 = productos.Take(10).ToList();
// Console.WriteLine("Primeros 10 productos: " + string.Join(", ", primeros10));

// // Ejercicio 39: Salta los primeros 5 elementos de una lista de palabras y obtén los siguientes.
// List<string> palabrasVariadas = new List<string> { "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho" };
// var skip5 = palabrasVariadas.Skip(5).ToList();
// Console.WriteLine("Después de saltar los primeros 5: " + string.Join(", ", skip5));

// // Ejercicio 40: Elimina los elementos duplicados en una lista de nombres y ordénalos alfabéticamente.
// List<string> nombresDuplicados = new List<string> { "Carlos", "Ana", "Pedro", "Juan", "Lucía", "Ana", "Carlos" };
// var nombresSinDuplicadosOrdenados = nombresDuplicados.Distinct().OrderBy(n => n).ToList();
// Console.WriteLine("Nombres sin duplicados y ordenados: " + string.Join(", ", nombresSinDuplicadosOrdenados));

//1
List<int> numeros = new List<int> { 5, 12, 18, 3, 7, -22, 9, 10, 60,74 };
var mayoresA10 = numeros.Where(n => n>10).ToList();
Console.WriteLine("Números mayores a 10: " + string.Join(", ", mayoresA10));

//2
var cuadrados = numeros.Select(n => n*n).ToList();
Console.WriteLine("Cuadrados de los números: " + string.Join(", ", cuadrados));

//3
List<string> nombres = new List<string> {"ana","camilo","juan","santiago","carolina","valeria"};
var ordenados = nombres.OrderBy(n =>n).ToList();
Console.WriteLine("Nombres ordenados alfabéticamente: " + string.Join(", ", ordenados));

//4
List<double> precios = new List<double>() {4.5,6.4,8.4,9.4,2.6};
var preciosOrdenados = precios.OrderBy(n => n).ToList();
Console.WriteLine("Precios ordenados de mayor: " + string.Join(", ", preciosOrdenados));

//5
var primerPar= numeros.FirstOrDefault(n=> n%2==0);
Console.WriteLine("Primer número par: " + primerPar );

//6
var ultimoNombre= nombres.LastOrDefault();
Console.WriteLine("Ultimo nombre: " + ultimoNombre );

//7
var primerNegativo =numeros.FirstOrDefault(n=>n<0);
Console.WriteLine("Primer negativo: " + primerNegativo );

//8
var ultimoMayor50= numeros.LastOrDefault(n=>n>50);
Console.WriteLine("Ultimo número mayor a 50: " + ultimoMayor50 );

//9
List<bool> booleanos = new List<bool> { false, false, false };
var algunVerdadero = booleanos.Any(b => b);
Console.WriteLine("¿Algún elemento es verdadero? " + algunVerdadero);
