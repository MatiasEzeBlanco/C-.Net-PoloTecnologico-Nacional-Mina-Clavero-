//Clase 8      Matrices---------------------------------------
//Repaso de Vectores de clase 7
//Console.WriteLine("Ingrese la cantidad de alumnos");
////Ingresamos el tamanio del vector
//int cantidadAlumnos = int.Parse(Console.ReadLine());

//// Tipo[] nombre = new tipo[tamanio]
//int[] notas = new int[cantidadAlumnos];

//Console.WriteLine("Ingrese las notas de cada alumno");

//// Recorremos el vector para cargar
//for (int posicion = 0; posicion < notas.Length; posicion++)
//{
//    Console.WriteLine($"Nota del alumano N° {posicion + 1}: ");
//    notas[posicion] = int.Parse(Console.ReadLine());
//}

//Console.WriteLine();
//Console.WriteLine("========================");
//Console.WriteLine();

//for (int posicion = 0; posicion < notas.Length; posicion++)
//{
//    Console.WriteLine($"La nota del alumno N° {posicion + 1}: {notas[posicion]}" );
//}


/* 
   Matriz bidimensional ------------------------------------
     For anidados
 */
Console.WriteLine("=======================================");
Console.WriteLine("Ingrese las notas de los examenes");

Console.WriteLine();
Console.WriteLine("=======================================");

Console.Write("Ingrese la cantidad de alumnos: ");
// Determina las columnas
int cantidadAlumnos = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.Write("Ingrese la cantidad de notas por alumno: ");
// Determina las filas
int cantidadNotas = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("=======================================");

// Tipo[,] nombre = new tipo[tamanioFilas, tamanioColumnas]
int[,] notas = new int[cantidadNotas, cantidadAlumnos];

//Cantidad de filas
int lengthFilas = notas.GetUpperBound(0) + 1;

//Cantidad de columnas
int lengthColumnas = notas.GetUpperBound(1) + 1;

//Recorremos columnas
for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine();

    Console.WriteLine($"Notas del alumno N° {columna + 1}: ");

    // Recorremos filas
    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.Write($"Cargue la nota N° {fila + 1}: ");
        notas[fila, columna] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine();
Console.WriteLine("=======================================");

// Recorremos las columnas

for (int columna = 0; columna < lengthColumnas; columna++)
{

    Console.WriteLine();
    Console.WriteLine($"Notas del alumno N°: {columna + 1}: ");

    // Recorremos filas
   for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.Write($"La nota N° {fila + 1}: ");
        Console.WriteLine(notas[fila, columna]);

        /*
            Si queremos obtener un valor de una posicion concreta de la matriz
         */

        //if (fila == 2 && columna == 0)
        //{
        //    Console.Write($"La nota N° {fila + 1}: ");
        //    Console.WriteLine(notas[fila, columna]);
        //}
    }
}

//Obtenemos un valor de una posicion concreta
//int nota3 = notas[2, 0];
//Console.ReadKey();

//Final de la Clase-----------------------------------

//Ejercicio clase 8-----------------------------------
/*Ejercicio

Crear un programa que cumpla con los siguientes pasos

1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
3) Declarar un vector de tipo double llamado promedios
4) Recorrer la matriz para su carga con elementos de tipo int
5) Recorrer la matriz para mostrar cada valor de la matriz
6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
7) Mostrar los promedios recorriendo el vector promedios*/

//Mi respuesta----------------------------------------

Console.WriteLine("Bienvenido al Fixture del Torneo Apertura!");
Console.WriteLine("======================================");
Console.WriteLine("Ingrese la cantidad de equipos participantes:");
int cantidadEquipos = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de fechas del torneo:");
int cantidadFechas = int.Parse(Console.ReadLine());

int[,] puntos=new int [cantidadEquipos, cantidadFechas];

int lengthEquipos= puntos.GetUpperBound(0)+1;
int lengthFechas = puntos.GetUpperBound(1)+1;

for (int columna = 0; columna < lengthEquipos; columna++)
{
    Console.WriteLine();

    Console.WriteLine($"Cargue el numero de equipo {columna + 1}: ");

    for (int fila = 0; fila < lengthFechas; fila++)
    {
        Console.Write($"Cargue el numero de fecha {fila + 1}: ");
        puntos[fila, columna] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine();
Console.WriteLine("=======================================");

for (int columna = 0; columna < lengthEquipos; columna++)
{   
    Console.WriteLine();
    Console.WriteLine($"Puntos del equipo N°: {columna + 1}: ");


    for (int fila = 0; fila < lengthFechas; fila++)
    {
        Console.Write($"Puntaje de la fecha N° {fila + 1}: ");
        Console.WriteLine(puntos[fila, columna]);
    }
}


//double[] promedios = new double[];