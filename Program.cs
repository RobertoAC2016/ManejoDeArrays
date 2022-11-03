//  Demostracion de arreglos, unidimensionales, bidimensionales y tridimensionales
Console.WriteLine("Arrays unidimensionales");

//  Veamos como se hace la declaracion de una variable, en este caso un array unidimensional

//  Tipo de arreglo, este sera de tipo String

//Primero definimos el tipo, luego con los corchetes vacios, se define con una longitud indefinida

// Ahora definimos el nombre: StringArrayUni 

//  Asi solo se hace la declaracion, en seguida se realiza la inicializacion

//  Ahora no solamente esta definida la variable, sino q tambien ya esta inicializada con valores

//  En este caso son valores de tipo string, maximo 5 valores

String[] StringArrayUni = new string[] { "Ana", "Juan", "Dan", "Olivia", "Sam" };

//  Aqui definimos un arreglo de tipo entero, solo acepta numero enteros

int[] intArrayUni = new int[] { 0, 1, 2, 3, 4 };

//  Aqui definimos un arreglo de tipo objeto, el cual puede aceptar, cualquier tipo de valor

object[] objectArrayUni = new object[] { 0, "Miriam", 1.0f, 'a', 0d };

//  Vamos a imprimir estos valores

foreach (var ele in StringArrayUni)
    Console.WriteLine($"Elemento : {ele}");
Console.WriteLine();

foreach (var ele in intArrayUni)
    Console.WriteLine($"Elemento : {ele}");
Console.WriteLine();

foreach (var ele in objectArrayUni)
    Console.WriteLine($"Elemento : {ele}");

























Console.WriteLine("Arrays Bidimensionales");

//  Aqui definimos un arreglo bidimensional de strings, en un arreglo de tamaño indefinido

String[][] StringArray = new string[][]
{
    new string[] { "Alex", "Dany" },
    new string[] { "Carla", "Karen", "Adan", "Mario" },
    new string[] { "Max", "Alan", "Dario" },
    new string[] { "Ana", "Juan", "Dan", "Olivia", "Sam" },
    new string[] { "Marla" },
};

//  Aqui definimos un arreglo bidimensional de enteros, en un arreglo de tamaño indefinido

int[][] intArray = new int[][]
{
    new int[] { 0, 1 },
    new int[] { 0, 1, 2, 3 },
    new int[] { 0, 1, 2 },
    new int[] { 0, 1, 2, 3, 4 },
    new int[] { 0 },
};

//  Aqui definimos un arreglo bidimensional de objetos, en un arreglo de tamaño indefinido

object[][] objectArray = new object[][]
{
    new object[] { 0, 1 },
    new object[] { "Ana", "Juan", "Dan", "Olivia" },
    new object[] { 1.0f, 1.1f, 1.2f },
    new object[] { 'a', 'b', 'c', 'd', 'e' },
    new object[] { 0d },
};

//  Vamos a imprimir sus valores

foreach (var pos in StringArray)
{
    Console.WriteLine();
    foreach (var ele in pos)
        Console.WriteLine($"Elemento : {ele}");
}
Console.WriteLine();

foreach (var pos in intArray)
{
    Console.WriteLine();
    foreach (var ele in pos)
        Console.WriteLine($"Elemento : {ele}");
}
Console.WriteLine();

foreach (var pos in objectArray)
{
    Console.WriteLine();
    foreach (var ele in pos)
        Console.WriteLine($"Elemento : {ele}");
}
























Console.WriteLine("Arrays Tridimensional indefinido");



String[][][] StringArrayTri = new String[][][]
{
    new String[][]
    {
        new String[] { "Alex", "Dany" },
        new String[] { "Marla" },
    },
    new String[][]
    {
        new String[] { "Max", "Alan", "Dario" },
        new String[] { "Ana", "Juan", "Dan", "Olivia", "Sam" },
        new String[] { "Marla" },
    },
    new String[][]
    {
        new String[] { "Ana", "Juan", "Dan", "Olivia", "Sam" },
        new String[] { "Marla" },
    },
};

foreach (var x in StringArrayTri)
{
    foreach (var y in x)
    {
        foreach (var z in y)
            Console.WriteLine($"Elemento Z : {z}");
        Console.WriteLine("Pos Y");
    }
    Console.WriteLine("Pos X");
}
Console.WriteLine();



//  Ahora veremos la diferencia con un arreglo de tipo definido en tu longitud



Console.WriteLine("\n\n\nArrays Tridimensional definido");
//  Es un arreglo definido de 3 * 3 * 3
String[,,] StrArrayTri = new String[,,]
{
    {
        { "Max", "Alan", "Dario" },
        { "Alex", "Dany", "Marla" },
        { "Ana", "Juan", "Dan" },
    },
    {
        { "Olivia", "Sam", "Marla" },
        { "Carla", "Karen", "Adan" },
        { "Carlos", "Marlen", "Maria" },
    },
    {
        { "Zyan", "Aiko", "Megumi" },
        { "Darla", "Ataku", "Zuyi" },
        { "Susan", "Akira", "Dante" },
    },
};

for (var x = 0; x < 3; x++)
{
    for (var y = 0; y < 3; y++)
    {
        for (var z = 0; z < 3; z++)
            Console.WriteLine($"Elemento X,Y,Z : {StrArrayTri[x, y, z]}");
        Console.WriteLine("Pos Y");
    }
    Console.WriteLine("Pos X");
}
Console.WriteLine();


//  Otra forma de hacer el array tridimensional, definido de 3 *3 *3 de tipo string

Console.WriteLine("Array tridimensional de Strings de tama♫o definido");



//  Otra forma de hacer el array tridimensional, definido de 3 *3 *3 de tipo string

Console.WriteLine("Array tridimensional de Strings de tama♫o definido");

string[][][] strArray3d = new string[3][][]// definimos un dimensiona maxima de 3 posiciones
{
    new string[3][]// definimos un dimensiona maxima de 3 posiciones
    {
        new string[3]{ "Max", "Alan", "Dario" },// definimos un dimensiona maxima de 3 posiciones
        new string[3]{ "Alex", "Dany", "Marla" },
        new string[3]{ "Ana", "Juan", "Dan" },
    },//    Si queremos agrega una posicion mas nos dara error porque se definio de 3 no menos ni mas
    new string[3][]{
        new string[3]{ "Olivia", "Sam", "Marla" },  //Si borramos un elemento nos dara error
        new string[3]{ "Carla", "Karen", "Adan" },//    de igual modo si agregamos un elemento mas dara error
        new string[3]{ "Carlos", "Marlen", "Maria" },
    },
    new string[3][]{
        new string[3]{ "Zyan", "Aiko", "Megumi" },
        new string[3]{ "Darla", "Ataku", "Zuyi" },
        new string[3]{ "Susan", "Akira", "Dante" },
    },
};

// Ahora imprimamos los valores

for (var x = 0; x < 3; x++)
{
    for (var y = 0; y < 3; y++)
    {
        for (var z = 0; z < 3; z++)
            Console.WriteLine($"Elemento X,Y,Z : {strArray3d[x][y][z]}");
        Console.WriteLine("Pos Y");
    }
    Console.WriteLine("Pos X");
}
Console.WriteLine();


























