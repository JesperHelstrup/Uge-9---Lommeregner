namespace Uge_9___Lommeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator lommeregner = new Calculator();
            int userinput = 0;

                Console.Clear();
                Console.Write("Indtast den første værdi:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Indtast den anden værdi:");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Vælg hvilken metode du vil anvende:");
                Console.WriteLine("1. add");
                Console.WriteLine("2. subtract");
                Console.WriteLine("3. multiply");
                Console.WriteLine("4. divide");
                Console.WriteLine("Eller skriv 5 for at afslutte");
                userinput = int.Parse(Console.ReadLine());
            
            while (userinput == 1)
            {
                Console.WriteLine(lommeregner.Add(a, b));
                break;
            }
            while (userinput == 2)
            {
                Console.WriteLine(lommeregner.Subtract(a, b));
                break;
            }
            while (userinput == 3)
            {
                Console.WriteLine(lommeregner.Multiply(a, b));
                break;
            }
            while (userinput == 4)
            {
                Console.WriteLine(lommeregner.Divide(a, b));
                break;
            }
            while (userinput == 5)
            {
                Environment.Exit(0);
                break;
            }
            while (userinput != 1 || userinput != 2 || userinput != 3 || userinput != 4 || userinput != 5)
            {
                Console.WriteLine("?");
                break;
            }
            



        }
    }
}
