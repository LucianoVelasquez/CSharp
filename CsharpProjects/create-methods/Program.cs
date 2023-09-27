using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        //Un metodo se puede llamar antes o despues de su definicion.
        //Los nombre de los metodos deben usar PascalCase.
        void ShowData(string a,  string b,string c)
        {
            Console.WriteLine($"Este es un string => {a}, {b} ,{c}");

        }

        ShowData("Hola", "Soy un", "String\n");

        //Prueba de paso por valor  
        int a = 3;
        int b = 4;
        int c = 0;

        Multiply(a, b, c);

        Console.WriteLine($"global statement: {a} x {b} = {c}\n");

        void Multiply(int a, int b, int c)
        {
            c = a * b;
            Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
        }

        //Prueba de paso por referencia
        int[] array = { 1, 2, 3, 4, 5 };

        PrintArray(array);
        Clear(array);
        PrintArray(array);

        void PrintArray(int[] array)
        {
            foreach (int a in array)
            {
                Console.WriteLine($"{a} ");
            }
        }

        void Clear(int[] array)
        {
            Console.WriteLine("Re asignando los elementos del array..");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }

        //Pruena con cadenas
        string status = "Healthy";

        Console.WriteLine($"\nStart: {status}");
        //SetHealth(status, false);
        SetHealth(false);
        Console.WriteLine($"End: {status}");

        /*void SetHealth(string status, bool isHealthy) //Este metodo no modifica globalmente la variable Status.
        {
            status = (isHealthy ? "Healthy" : "Unhealthy");
            Console.WriteLine($"Middle: {status}");
        }*/
        void SetHealth(bool isHealthy)
        {
            status = (isHealthy ? "Healthy" : "Unhealthy");
            Console.WriteLine($"Middle: {status}");
        }

        //Probando funcion con metodos opcionales
        void Prueba(string name,string appellido = "orungo",int edad = 5) {
            Console.WriteLine($"{name} - {appellido} - {edad} \n");
        }

        Prueba("marcelo", edad: 10);

        //Creando una funcion que devuelva un entero, (Lo mismo para el resto de tipos de datos)
        //bool,double,string,int[]
        int numeroModificado = PrecieModifiqued(8);
        int PrecieModifiqued(int numero)
        {
            return numero * 8;
        }
        Console.WriteLine(numeroModificado+"\n");

        //Probando un simple case.
        int dayOfWeek = 3;
        string dayName;

        switch (dayOfWeek)
        {
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            default:
                dayName = "Unknown";
                break;
        }

        Console.WriteLine(dayName);

        int x = 10;
        double result = (double)x;
        Console.WriteLine(result.GetType());

        string[] nombrs = { "ana", "miguel", "celia", "antonio" };
        string nombres = String.Join(" ", nombrs);
        string num = "32";
        int num1 = Convert.ToInt32(result);
        Console.WriteLine(num1.GetType());
        Console.WriteLine(nombres.ToUpper());
       
        int Prueba2()
        {
            int x = 10;
            int y = 5;
            return x % y;
        }

        Console.WriteLine(Prueba2());
       
        
    }
}