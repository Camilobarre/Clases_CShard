using System.Reflection.PortableExecutable;

Console.Clear();

//Variables

/*Cadenas de caracteres (String-Char)
Numericos (Int, Double, Byte, Float, Long, Decimal)
Booleanos (True, False)
*/

Char letra = 'a';
Console.WriteLine(letra.GetType().Name); //Llamamos el tipo de dato de letra

//Array de frutas
var frutas = new string[] {
    "banano",
    "pera",
    "sandia"
};
frutas[1] = "fresas";

Console.WriteLine(frutas.GetType().Name); //Llamamos el tipo de datos del array
Console.WriteLine(frutas[1]); //Llamamos a la posicion 1

//Lista de frutas
var frutasList = new List<string>(){
    "manzana",
    "naranja",
    "uva"
};

//Lista con numeros del 1 al 10 en desorden
var numerosLista = new List<byte> { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
// Array con numeros del 1 al 10 en desorden
var numerosArray = new byte[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

//Lista vacia en donde se van a guardar solo los numeros pares
var numerosPares = new List<byte>();

//Recorrer la lista
foreach (var item in numerosLista)
{
    Console.WriteLine(item);
}

//Recorrer la array
foreach (var item in numerosArray)
{
    Console.WriteLine(item);
}

//Solo numeros pares
foreach (var numero in numerosLista)
{
    if (numero%2==0)
    {
        //Si el numero es par, lo agrega a la lista
        numerosPares.Add(numero);
    }
}

//Muestra los numeros pares
Console.WriteLine("Numeros Pares:");
foreach (var numero in numerosPares)
{
    Console.WriteLine(numero);
}

//Numeros duplicados con LINQ
var numerosDuplicadosArray = numerosPares.Select(item => item*2);

//Numeros pares con LINQ
var numeroParesArray= numerosArray.Where(item=> item %2 ==0).ToList();

//Duplicar los numeros
var numerosDuplicados= numerosArray.Select(item => item*2).ToArray();

//Ordenar descendente
Console.WriteLine("Ordenados Descendentes:");
var numerosDescendentes = numerosArray.OrderByDescending(num => num).ToList();

foreach (var item in numerosDescendentes)
{
    Console.WriteLine(item);
}

//Ordenar ascendente
Console.WriteLine("Ordenados Ascendentes:");
var numerosAscendentes = numerosArray.OrderBy(num => num).ToList();

foreach (var item in numerosAscendentes)
{
    Console.WriteLine(item);
}