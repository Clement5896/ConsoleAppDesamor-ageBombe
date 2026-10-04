namespace ConsoleAppDesamorçage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int code;
            Random secretCode = new Random();
            int secretCodeValue = secretCode.Next(1, 21);


            do
            {
                Console.WriteLine("Entrez un code entre 1 et 20 :");
                code = int.Parse(Console.ReadLine());
                bool indiceTropBas = true;
                while (code < secretCodeValue && indiceTropBas)
                {
                    Console.WriteLine("[ALERTE] Code trop bas ! Surcharge détectée");
                    indiceTropBas = false;
                }
                bool indiceTropHaut = true;
                while (code > secretCodeValue && indiceTropHaut)
                {
                    Console.WriteLine("[ALERTE] Code trop haut ! Surcharge détectée");
                    indiceTropHaut = false;
                }

            } while (code != secretCodeValue);


            Console.WriteLine("Code correct !");
            {

            }

        }
    }
}
