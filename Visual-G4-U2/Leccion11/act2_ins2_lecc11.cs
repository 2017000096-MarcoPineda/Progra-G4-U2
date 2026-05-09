internal class Program
{
    private static void Main(string[] args)
    {
        int numero = 1;

        do
        {
            Console.WriteLine(numero);
            numero = numero + 2;
        }
        while (numero <= 100);

        Console.ReadKey();
    }
}