//Clase 7 Arrays------------------------------------------

//string[] cars = { "Ford", "Fiat", "BMW", "Toyota" };
//Console.WriteLine(cars[0]);
//-----------------------------------------------------------

//string[] frutas = new string[4];

//frutas[0] = "Pera";
//frutas[1] = "Manzana";
//frutas[2] = "Banana";
//frutas[3] = "Naranja";
//Console.WriteLine(frutas[0]);

//Ejemplo siguiente: Introduccion de valores por el usuario a un array
//-------------------------------------------------------------
//int[] numeros= new int[5];
//Console.WriteLine("Escriba 5 numeros");

//for ( int i = 0;i < 5; i++)
//{
//    Console.WriteLine($"Por favor ingresa el numero: {i+1}");
//    numeros[i] =int.Parse(Console.ReadLine());
//}

//int suma = 0;  
//for ( int i = 0;i < 5;i++)
//{
//    suma = suma + numeros[i];
//}
//Console.WriteLine($"La suma de todos los numeros es: {suma}");

//Console.WriteLine("Los valores son: ");

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine(numeros[i]);
//}

//--------------------------------------------------------
/* Ejercicio
 * Escribe un programa que:

1) Pida 10 números al usuario.
2) Obtener la suma de todos los números ingresados.
3) Obtener cual es el mayor de todos los números.
4) Obtener cual es el menor de todos los números.
5) Obtener el promedio de todos los números.
6) Mostrar todos los números ingresados por pantalla.
7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.*/
//Mi respuesta----------------------------------

int[] numero = new int[10];
Console.WriteLine("Escriba 10 numeros:");

for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine($"Escriba el numero:{i+1}");
    numero[i] = int.Parse(Console.ReadLine());
}

//suma----
int suma = 0;
for (int i = 0; i < numero.Length; i++)
{
    suma=suma+numero[i];
}

//Valor mas alto---
int valorMasAlto=0;
for (int i = 0; i < numero.Length; i++)
{
    if(valorMasAlto<numero[i])
    { valorMasAlto = numero[i];}

}

//Valor mas bajo---
int valorMasBajo=valorMasAlto;
for (int i = 0; i < numero.Length; i++)
{
    if (numero[i]<valorMasBajo)
    { valorMasBajo = numero[i];
     }
}
//Cantidad de notas--
int notas=0;
for (int i = 0; i <= numero.Length; i++)
{
    notas=i;
}

//Promedio---
int promedio = suma / notas;

//WriteLines
for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine($"Los numeros ingresados son: {numero[i]}");
}


Console.WriteLine($"La suma de todos los valores es : {suma}");
Console.WriteLine($"El valor mas alto es: {valorMasAlto}");
Console.WriteLine($"El valor mas bajo es: {valorMasBajo}");
Console.WriteLine($"El promedio de los valores es: {promedio}");