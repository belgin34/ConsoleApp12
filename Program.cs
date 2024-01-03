namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tahmin;
            int can= 100;
            Console.WriteLine("Zorluk seciniz: \n 1- Kolay \n 2- Orta \n 3- Zor");
            int zorluk = int.Parse(Console.ReadLine());
            int value = 0; int azalt = 0;

            switch (zorluk)
            {
                case 1:
                    value = 10;
                    azalt = 10;
                    break;
                case 2:
                    value = 55;
                    azalt = 50;
                    break;
                case 3:
                    value = 100;
                    azalt = 100;
                    break;
                default:
                    break;
            }

            Random rnd = new Random();
            int number = rnd.Next(value);
            do
            {
                Console.WriteLine("Guess a number.");
                tahmin = int.Parse(Console.ReadLine());

                if (tahmin == number)
                {
                    Console.WriteLine("Congrats brat!");
                }
                if (tahmin < number)
                {
                    can -= azalt;
                }
                else if (tahmin > number)
                {
                   can -= azalt;
                }
                if (can == 0) { break; }
            }
            while (tahmin != number);
        }
    }
}