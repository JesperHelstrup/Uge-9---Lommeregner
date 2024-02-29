namespace Uge_9___Lommeregner
{
    internal class ProgramJonathan
    {
        static void MainJonathan(string[] args)
        {
            Calculator Lommeregner = new Calculator();
            //Console.WriteLine(Lommeregner.Add(2, 2));
            //Console.WriteLine(Lommeregner.Subtract(10, 5));
            //Console.WriteLine(Lommeregner.Divide(10, 3));
            //Console.WriteLine(Lommeregner.Multiply(10, 2));

            Console.WriteLine("Vælg i menu hvilken udregning du vil vælge");
            Console.WriteLine("Tast 1 for Plus \nTast 2 for Minus \nTast 3 for Divider \nTast 4 for Multiply eller \ntast q for at Quit");

            string userInput = Console.ReadLine();               

            do
            {
                if (userInput == "1")
                {
                    Console.WriteLine("Du har valgt Plus, Indtast 2 værdier");
                    Console.WriteLine(
                        Lommeregner.Add(
                            int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())
                            ));
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("Du har valgt Minus, Indtast 2 værdier");
                    Console.WriteLine(
                        Lommeregner.Subtract(
                            int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())
                            ));
                }
                else if (userInput == "3")
                {
                    Console.WriteLine("Du har valgt Divider, Indtast 2 værdier");
                    Console.WriteLine(
                        Lommeregner.Divide(
                            int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())
                            ));
                }
                else if (userInput == "4")
                {
                    Console.WriteLine("Du har valgt Multiply, Indtast 2 værdier");
                    Console.WriteLine(
                        Lommeregner.Multiply(
                            int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())
                            ));
                }              
            }
            while (
            
            userInput != "q");
            // o	Det skal være muligt at benytte alle metoderne på skift.
            //
            //      Loopen skal køre medmindre man skriver q
            //
            //


        }
    }
}
