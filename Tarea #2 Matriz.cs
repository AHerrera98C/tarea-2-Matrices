//int[,] matriz =
//{
//    { 5,7,4},
//    { 1,8,5},
//    { 2,7,9}
//};

//int n = matriz.GetLength(0); // Obtener el tamallo de la matriz 
//int diagonalPrincipal = 0; // Suma de la diagonal principal
//int diagonalSegundaria = 0; // Suma de la diagonal secundaria

//for (int i = 0; i < n; i++)
//{
//    diagonalPrincipal += matriz[i, i];
//    diagonalSegundaria += matriz[i, n - 1 - i];

//};

//Console.WriteLine("La suma de la diagonal principal es de: " + diagonalPrincipal);
//Console.WriteLine("La suma de la diagonal secundaria es de: " + diagonalSegundaria);

//using System.Diagnostics.CodeAnalysis;

//int[,] matriz =
//{
//    { 5,7,4 },
//    { 8,9,6 },
//    { 2,3,9 }
//};

//Console.WriteLine("Ingrese el numero de columna que desea sumar - Seleccione 0, 1 o 2. ");
//int numeroColumna = Convert.ToInt32(Console.ReadLine());

//int sumaDeColumna = sumarColumna(matriz, numeroColumna);

//Console.WriteLine("La suma de la columna " + numeroColumna + " es :" + sumaDeColumna);

//int sumarColumna(int[,] matriz, int columna)
//{
//    int suma = 0;
//    int filas = matriz.GetLength(0);

//    for (int i = 0; i < filas; i++)
//    {
//        suma += matriz[i, columna];
//    }
//    return suma;
//}


int[,] matriz = 
{
   {1, 2, 3},
   {4, 5, 6},
   {7, 8, 9}
};

int sumaEsquinas = SumarEsquinas(matriz);

Console.WriteLine("La suma de todas las esquinas es: " + sumaEsquinas);


    static int SumarEsquinas(int[,] matriz)
    {
    int filas = matriz.GetLength(0);
    int columnas = matriz.GetLength(1);

    if (filas < 2 || columnas < 2)
    {
        
        Console.WriteLine("La matriz es demasiado pequeña para tener esquinas.");
        return 0;
    }

   
    int esquinaSuperiorIzquierda = matriz[0, 0];
    int esquinaSuperiorDerecha = matriz[0, columnas - 1];
    int esquinaInferiorIzquierda = matriz[filas - 1, 0];
    int esquinaInferiorDerecha = matriz[filas - 1, columnas - 1];

   
    int sumaTotal = esquinaSuperiorIzquierda + esquinaSuperiorDerecha +
                    esquinaInferiorIzquierda + esquinaInferiorDerecha;

    return sumaTotal;
}
