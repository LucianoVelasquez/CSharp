// See https://aka.ms/new-console-template for more information
//Matriz de arrays
/* string[] faudulentOrderIDs = new string[3];

//Asignando valores al array
faudulentOrderIDs[0] = "HOLA";
faudulentOrderIDs[1] = "HOLA2";
faudulentOrderIDs[2] = "HOLA3";

Console.WriteLine($"First: {faudulentOrderIDs[0]}");
Console.WriteLine($"Second: {faudulentOrderIDs[1]}");
Console.WriteLine($"Third: {faudulentOrderIDs[2]}"); */

//Declarando e inicializando al mismo tiempo

/* string[] fraudulentOrderIDs = { "hola1", "hola2", "hola3"};
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

//Usando propiedad length
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process."); */
//Usando foreach
/* string[] names = {"Rowena", "Robin", "Bao" };
foreach(string name in names){
    Console.WriteLine(name);
}
int[] inventary = { 200,4,1,2,3,7 };
int sum = 0;
foreach(int num in inventary){
    sum += num;
}
Console.WriteLine(sum);
 */
string[] codes = {"B123","C234","A345","C15","B177","G3003","C235","B179"};

foreach(string code in codes){
    if(code.StartsWith('B')){
        Console.WriteLine($"The name starts with 'B'! :{code}");
    }
}
