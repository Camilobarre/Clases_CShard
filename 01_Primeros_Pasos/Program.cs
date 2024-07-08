// Console.WriteLine("Hola a Todos");

// string nombre = "Camilo ";
// string apellido = "Barreneche Escobar";
// string numeroDeDocumento = "1026155751";

// string nombre = "Camilo", apellido = "Barreneche Escobar", numeroDeDocumento = "1026155751";

// int edad = 27;
// var clan = "Berneers Lee";

// Console.WriteLine(nombre);
// Console.WriteLine(apellido);
// Console.WriteLine(numeroDeDocumento);
// Console.WriteLine(edad);
// Console.WriteLine(clan);

// Console.WriteLine("Hola, soy "+nombre+ " "+apellido+" y tengo "+edad+" años. Mi nùmero de documento es "+numeroDeDocumento+" y pertenezco al clan "+clan);

// string saludo=$"Hola, mi nombre es {nombre} {apellido}, \n Mi nùmero de documento es {numeroDeDocumento}";
// Console.WriteLine(saludo);

// string saludo2= @$"Hola, mi nombre es {nombre} {apellido},
// Mi nùmero de documento es {numeroDeDocumento}
// y tengo {edad} años";

// Console.WriteLine(saludo2);

// 1 Escribe un programa que imprima “¡Hola, mundo!" en la consola.
using System.Security.Cryptography;

Console.WriteLine("Hola, mundo");

// 2 Declara un int y un string, asignarles valores e imprímelos.
int numero = 10;
string mensaje = "Hola, mundo";
Console.WriteLine(numero);
Console.WriteLine(mensaje);

// 3 Convierte un string a mayúsculas y a minúsculas.
string mensajePrueba = "EstO eS UN mEnSAJe de PrUEba";
Console.WriteLine(mensajePrueba.ToUpper());
Console.WriteLine(mensajePrueba.ToLower());

// 4 Declara dos int, realizar suma, resta, multiplicación y división, y muestra los resultados.
int numero1 = 20;
int numero2 = 6;
Console.WriteLine(numero1 + numero2);
Console.WriteLine(numero1 - numero2);
Console.WriteLine(numero1 * numero2);
Console.WriteLine((double)numero1 / (double)numero2);

// 5 Declara dos int, realiza comparaciones de igualdad, desigualdad, mayor que y menor que, y muestra los resultados.
int nuevoNumero1 = 30;
int nuevoNumero2 = 20;

Console.WriteLine(nuevoNumero1 == nuevoNumero2);
Console.WriteLine(nuevoNumero1 != nuevoNumero2);
Console.WriteLine(nuevoNumero1 > nuevoNumero2);
Console.WriteLine(nuevoNumero1 < nuevoNumero2);

// 6 Declara una variable string y escribe un programa que imprime la longitud de la cadena.
string nuevoMensaje = "Esto es un mensaje de prueba";
Console.WriteLine(nuevoMensaje.Length);

// 7 Declara una variable string y escribe un programa que imprime la primera letra de la cadena.
string otroMensaje = "Miramos la primera letra de la cadena";
char primeraLetra = otroMensaje[0];
Console.WriteLine(primeraLetra);

// 8 Busca una palabra específica en un string y reemplazarla por otra.
string buscar = "Vamos a buscar al perro aca";
Console.WriteLine(buscar);
string reemplazar = "perro";
string reemplazarCon = "gato";
string resultado = buscar.Replace(reemplazar, reemplazarCon);
Console.WriteLine(resultado);

// 9 Pide al usuario su nombre y edad, luego imprime un mensaje con esta información.
Console.Write("Escribe tu nombre: ");
string nombre = Console.ReadLine();
Console.Write("Escribe tu edad: ");
int edad = int.Parse(Console.ReadLine());
Console.WriteLine($"Hola, {nombre}. Tienes {edad} años.");

// 10 Declara un int y escribe un programa que indique si es mayor, menor o igual a 10.
int numeroPrueba = 40;
if (numeroPrueba > 10)
{
    Console.WriteLine($"{numeroPrueba} es mayor que 10.");
}
else if (numeroPrueba < 10)
{
    Console.WriteLine($"{numeroPrueba} es menor que 10.");
}
else
{
    Console.WriteLine($"{numeroPrueba} es igual a 10.");
}

// 11 Declara dos variables double, realiza suma, resta, multiplicación y división, y muestra los resultados.
double primerNumero = 3.87;
double segundoNumero = 2.55;
Console.WriteLine(primerNumero + segundoNumero);
Console.WriteLine(primerNumero - segundoNumero);
Console.WriteLine(primerNumero * segundoNumero);
Console.WriteLine(primerNumero / segundoNumero);

// 12 Declarar dos variables string, concatenarlas y mostrar el resultado.
string cadena1 = "Hola";
string cadena2 = "Calidoso";
Console.WriteLine(cadena1 + " " + cadena2);

// 13 Declara una variable int, conviértela a double y muestra ambos valores.
int numeroEntero = 5;
double numeroDouble = (double)numeroEntero;
Console.WriteLine(numeroEntero);
Console.WriteLine(numeroDouble);

// 14 Declara una variable int y una variable double, realiza la división entre ambas y muestra el resultado.
int entero1 = 5;
double decimal2 = 4.2;
Console.WriteLine(entero1 / decimal2);

// 14 Escribe un programa que pida al usuario un número y muestre si es positivo, negativo o cero.
Console.Write("Escribe un número: ");
int otroNumero = int.Parse(Console.ReadLine());
if (otroNumero > 0)
{
    Console.WriteLine($"{otroNumero} es positivo.");
}
else if (otroNumero < 0)
{
    Console.WriteLine($"{otroNumero} es negativo.");
}
else
{
    Console.WriteLine($"{otroNumero} es igual a 0.");
}

// 15 Usa un bucle for para imprimir los números del 1 al 10.
int i = 1;
while (i < 11) 
{
  Console.WriteLine(i);
  i++;
}

// 16 Elimina los espacios en blanco al inicio y al final de un string, y formatea el string para que empiece con mayúscula y el resto en minúsculas.

// 17 Escribe un programa que pida al usuario un número y muestre su tabla de multiplicar del 1 al 10.

// 18 Concatena dos strings y muestra la longitud de cada uno.

// 19 Extrae una subcadena de un string y muestra la subcadena y su longitud.