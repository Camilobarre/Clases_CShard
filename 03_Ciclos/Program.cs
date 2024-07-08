// Ciclo For
// (Crear al contador/Decir cuantas vueltas da/Declarar el incrementador)

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine($"Hola Mundo, esta es la iteraciòn nùmero {i + 1}");
// }

// Ciclo For Each

// string[] nombres={"Juan", "Pedro", "Ana"};
// foreach (string nombre in nombres)
// {
//     Console.WriteLine($"Hola, mi nombre es {nombre}");
// }

// Ciclo While

// bool bandera=true;
// while (bandera)
// {
//     Console.WriteLine("Sigue adealante");
//     Console.Write("Quieres repetir la iteracion=>");
//     string? respuesta=Console.ReadLine();
//     if (respuesta?.ToLower()== "no")
//     {
//         bandera = false;
//     }
// }

// Ejercicios.
//1. Escribe un programa que imprima los números del 1 al 100 usando un ciclo for.
// for (int i = 1; i < 101; i++)
// {
//     Console.WriteLine($"{i}");
// }

//2. Escribe un programa que solicite al usuario un número entero positivo e imprima todos los números pares desde 1 hasta ese número usando un ciclo for.
// Console.WriteLine("Escribe el nùmero por favor:");
// int numero = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < numero; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.WriteLine($"{i}");
//     }
//     else
//     {
//         continue;
//     }
// }

//3. Escribe un programa que pida al usuario un número entero positivo e imprima la tabla de multiplicar de ese número del 1 al 10 usando un ciclo for.
// Console.WriteLine("Escribe el nùmero por favor:");
// int multipicador = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{multipicador}*{i} ={multipicador * i}");
// }

//4. Escribe un programa que genere un número aleatorio entre 1 y 100. Pídele al usuario que adivine el número. Muestra un mensaje indicando si el número ingresado es demasiado alto, demasiado bajo o correcto. Continúa pidiendo al usuario que adivine hasta que adivine correctamente usando un ciclo do-while.
// Random random = new Random();
// int adivinar = random.Next(1, 101);
// bool flag =true;
// do
// {
//     Console.WriteLine("Escribe el nùmero por favor:");
//     int numeroUsuario = Convert.ToInt32(Console.ReadLine());

//     if (numeroUsuario > adivinar)
//     {
//         Console.WriteLine("El nùmero es demasiado alto, sigue intentando");
//     }
//     else if (numeroUsuario < adivinar)
//     {
//         Console.WriteLine("El nùmero es demasiado bajo, sigue intentando");
//     }
//     else
//     {
//         Console.WriteLine("Has adivinado correctamente");
//         flag = false;
//     }
// } while (flag == true);

//5. Escribe un programa que solicite al usuario un número entero positivo e imprima todos los números impares desde ese número hasta 1 usando un ciclo while.
// Console.WriteLine("Escribe el nùmero por favor:");
// int numeroImpar = Convert.ToInt32(Console.ReadLine());
// int i = numeroImpar;
// while (i>=1)
// {
//     if (i %2 !=0)
//     {
//         Console.WriteLine($"{i}");
//     }
//     i--;
// }

//6. Escribe un programa que solicite al usuario una contraseña. Si la contraseña ingresada no es "secreta", sigue pidiendo al usuario que ingrese la contraseña hasta que sea correcta usando un ciclo while.
// string contraseñaCorrecta = "secreta";
// bool flag = false;

// do
// {
//     Console.WriteLine("Ingresa la contraseña:");
//     string? intento = Console.ReadLine();

//     if (intento == contraseñaCorrecta)
//     {
//         Console.WriteLine("¡Eres un crack, adivinaste la contraseña!");
//         flag = true;
//     }
//     else
//     {
//         Console.WriteLine("Contraseña incorrecta. Sigue intentando.");
//     }

// } while (!flag);

//7. Escribe un programa que solicite al usuario un número entero positivo e imprima la secuencia de Fibonacci hasta ese número usando un ciclo for.
// Console.WriteLine("Escribe el nùmero para la secuencia de Fibonacci:");
// int Fibonacci = Convert.ToInt32(Console.ReadLine());
// int a = 0;
// int b = 1;

// for (int i = 1; i <= Fibonacci; i++)
// {
//     Console.Write($"{a} ");

//     int next = a + b;
//     a = b;
//     b = next;
// }
// Console.WriteLine();

//8. Escribe un programa que solicite al usuario un número entero positivo e imprima si el número es primo o no usando un ciclo for.
// Console.WriteLine("Escribe el número para saber si es primo");
// int numeroPrimo = Convert.ToInt32(Console.ReadLine());
// bool esPrimo = true;

// for (int i = 2; i < numeroPrimo; i++)
// {
//     if (numeroPrimo % i == 0)
//     {
//         esPrimo = false;
//         break;
//     }
// }
// if (esPrimo)
// {
//     Console.WriteLine($"El número {numeroPrimo} es primo.");
// }
// else
// {
//     Console.WriteLine($"El número {numeroPrimo} no es primo.");
// }

//9. Escribe un programa que solicite al usuario una palabra y luego imprima cada letra de la palabra en una línea separada usando un ciclo foreach.
// Console.WriteLine("Escribe una palabra");
// string? palabra = Console.ReadLine() ?? string.Empty;

// foreach (char letra in palabra)
// {
//     Console.WriteLine(letra);
// }

//10. Escribe un programa que solicite al usuario un número entero positivo e imprima la suma de todos los números desde 1 hasta ese número usando un ciclo for.
// Console.WriteLine("Escribe un nùmero para calcular su suma");
// int numeroSuma = Convert.ToInt32(Console.ReadLine());
// int suma = 0;

// for (int i = 1; i <= numeroSuma; i++)
// {
//     suma += i;
// }
// Console.WriteLine($"La suma desde 1 hasta {numeroSuma} es: {suma}");