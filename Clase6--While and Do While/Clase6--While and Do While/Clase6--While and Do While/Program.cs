//Clase 6(ejercicio clase 5 con While)


var respuesta = "S";

while (respuesta.ToUpper() == "S")
{
    Console.Clear();

    Console.WriteLine("Escriba su nombre:");
    var nombre = Console.ReadLine();
    Console.WriteLine($"Hola {nombre}!");

    Console.WriteLine("Quiere continuar?(S/N)");
    respuesta = Console.ReadLine();
}
if (respuesta.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado");
}
else
{
    Console.WriteLine("Opcion no valida");
}

//Ejercicio clase 5 con Do While:

var respuesta = "S";
do
{
    Console.Clear();

    Console.WriteLine("Escriba su nombre:");
    var nombre = Console.ReadLine();
    Console.WriteLine($"Hola {nombre}!");

    Console.WriteLine("Quiere continuar?(S/N)");
    respuesta = Console.ReadLine();
}
while (respuesta.ToUpper() == "S");

if (respuesta.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado");
}
else
{
    Console.WriteLine("Opcion no valida");
}