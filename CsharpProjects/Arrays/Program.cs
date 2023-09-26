internal class Program
{
    private static void Main(string[] args)
    {
        string[] pallets = { "B14", "A11", "B12", "A13" };
        Array.Sort(pallets);
        //Ordenando de mayor a menor y de A - Z
        foreach(string pallet in pallets)
        {
            Console.WriteLine(pallet);
        }
        Console.WriteLine("\n invertir");
        //invertir
        Console.WriteLine("\n");
        Array.Reverse(pallets);
        foreach (string pallet in pallets)
        {
            Console.WriteLine(pallet);
        }
        Console.WriteLine("\n Vacia elementos del array");
        //Vacia elementos del array
        Array.Clear(pallets, 0, 3);
        foreach (string pallet in pallets)
        {
            if (pallet == null)
            {
                Console.WriteLine("No estoy apuntando a ninguna parte");
            }
            Console.WriteLine(pallet);
        }
        Console.WriteLine("\n Aumentando el tamanio del array.");
        //Aumentando el tamanio del array.
        Array.Resize(ref pallets, 6);
        foreach (string pallet in pallets)
        {
            if(pallet == null)
            {
                Console.WriteLine("No estoy apuntando a ninguna parte");
            }
            Console.WriteLine(pallet);
        }
    }
}