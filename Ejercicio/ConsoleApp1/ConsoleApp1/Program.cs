//Escribir un programa que haga lo siguiente:
//1) Borrar la pantalla.
//2) Pedir el nombre de una persona.
//3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"
//4) Preguntar si se quiere continuar.
//5) Si la respuesta es "S" repetir desde el punto 1.
//6) Si la respuesta es "N" finalizar el programa mostrando un mensaje que diga "Programa finalizado correctamente".
//7) Si la respuesta no es ni "S" ni "N" que tambien finalice el programa, pero mostrando un mensaje que diga "Opcion no valida"
//Mi Respuesta-----------------------------------------------
Console.Clear();

Console.WriteLine("Escriba su nombre:");
var nombre = Console.ReadLine();
Console.WriteLine($"Hola {nombre}!");

Console.WriteLine("Quiere continuar?(S/N)");
var respuesta = Console.ReadLine();

while (respuesta.ToUpper() == "S")
{
    Console.Clear();

    Console.WriteLine("Escriba su nombre:");
     nombre = Console.ReadLine();
    Console.WriteLine($"Hola {nombre}!");

    Console.WriteLine("Quiere continuar?(S/N)");
     respuesta = Console.ReadLine();
    }
    if (respuesta.ToUpper() == "N")
    {
        Console.WriteLine("Programa finalizado");
    }
    else if(respuesta != "N")
            {
        Console.WriteLine("Opcion no valida");
}








//Respuesta mas optima resuelta en clase--------------------
//La variable "respuesta" en el resultado optimo nos indica un error debido a que fue definida en mi propio intento de resolucion.

var respuesta = "S";

while (respuesta.ToUpper() == "S")
{
    Console.Clear();

    Console.WriteLine("Escriba su nombre:");
    nombre = Console.ReadLine();
    Console.WriteLine($"Hola {nombre}!");

    Console.WriteLine("Quiere continuar?(S/N)");
}
if (respuesta.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado");
}
else
{
    Console.WriteLine("Opcion no valida");
}