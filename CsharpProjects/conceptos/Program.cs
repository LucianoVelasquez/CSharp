using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Antes
        /*int[] numbers = { 4, 8, 15, 16, 23, 42 };

        foreach (int number in numbers)
        {
            int total;

            total += number;

            if (number == 42)
            {
                bool found = true;

            }

        }

        if (found)
        {
            Console.WriteLine("Set contains 42");

        }

        Console.WriteLine($"Total: {total}");*/

        //Despues
        int[] numbers = { 4, 8, 15, 16, 23, 42 };
        int total = 0;
        bool found = false;

        foreach (int number in numbers)
        {

            total += number;

            if (number == 42) found = true;

        }

        if (found) Console.WriteLine("Set contains 42");

        Console.WriteLine($"Total: {total}");

        //Conociendo Switch
        int employeeLevel = 201;
        string employeeName = "John Smith";

        string title = "";

        switch (employeeLevel)
        {
            case 100:
                title = "Junior Associate";
                break;
            case 200:
                title = "Senior Associate";
                break;
            case 300:
                title = "Manager";
                break;
            case 400:
                title = "Senior Manager";
                break;
            default:
                title = "Associate";
                break;
        }

        Console.WriteLine($"\n{employeeName}, {title}");

        //Formateo
        // SKU = Stock Keeping Unit. 
        // SKU value format: <product #>-<2-letter color code>-<size code>
        string sku = "01-MN-L";

        string[] product = sku.Split('-');

        string type = "";
        string color = "";
        string size = "";

        /*if (product[0] == "01")
         {
             type = "Sweat shirt";
         }
         else if (product[0] == "02")
         {
             type = "T-Shirt";
         }
         else if (product[0] == "03")
         {
             type = "Sweat pants";
         }
         else
         {
             type = "Other";
         }

         if (product[1] == "BL")
         {
             color = "Black";
         }
         else if (product[1] == "MN")
         {
             color = "Maroon";
         }
         else
         {
             color = "White";
         }

         if (product[2] == "S")
         {
             size = "Small";
         }
         else if (product[2] == "M")
         {
             size = "Medium";
         }
         else if (product[2] == "L")
         {
             size = "Large";
         }
         else
         {
             size = "One Size Fits All";
         }*/

        //Reduciendo las lineas de codigo anterior.
        for(int i = 0; i < product.Length; i++)
        {
            switch (product[i])
            {
                case "01": type = "Sweat shirt"; break;
                case "02": type = "T-Shirt"; break;
                case "03": type = "Sweat pants"; break;
                case "BL": color = "Black"; break;
                case "MN": color = "Maroon"; break;
                case "S": size = "Small"; break;
                case "M": size = "Medium"; break;
                case "L": size = "Large"; break;
                default: if(type == "") type = "Other";
                         if (color == "") color = "White";
                         if (size == "") size = "One Size Fits All"; break;
            }
        }
        
        Console.WriteLine($"\nProduct: {size} {color} {type}");
    }
}