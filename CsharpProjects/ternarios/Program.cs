
internal class Program
{
    private static void Main(string[] args)
    {
        int saleAmount = 1001;
        //int descount = saleAmount > 1000? 100 : 50;
        //Console.WriteLine($"Descount: {descount}");
        Console.WriteLine($"Descount: {(saleAmount > 1000 ? 100 : 50)}");
        Random random = new();
        int result = random.Next(0, 2);
        Console.WriteLine($"{(result == 1 ? "Head" : "Tails")} + {result}");

        string permission = "Admin";
        int level = 56;

        if (!permission.Contains("Admin") && !permission.Contains("Manager"))
        {
            Console.WriteLine("You do not have sufficient privileges.");
        }else if (permission.Contains("Manager") && level < 20)
        {
            Console.WriteLine("You do not have sufficient privileges.");
        }else if (permission.Contains("Manager") && level > 20)
        {
            Console.WriteLine("Contact an Admin for access.");
        }else if (permission.Contains("Admin") && level <= 55)
        {
            Console.WriteLine("Welcome, Admin user.");
        }
        else
        {
            Console.WriteLine("Welcome, Super Admin user.");
        }

    }
}