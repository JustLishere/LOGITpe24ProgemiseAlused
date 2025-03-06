namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HelWorld!");

            int number = new Random().Next(1, 7);

            switch (number)
            {
                case 1:
                    Console.WriteLine("Veeretasid nr " + number);
                    break;

                case 2:
                    Console.WriteLine("Veeretasid nr " + number);
                    break;

                case 3:
                    Console.WriteLine("Veeretasid nr " + number);
                    break;

                case 4:
                    Console.WriteLine("Veeretasid nr " + number);
                    break;

                case 5:
                    Console.WriteLine("Veeretasid nr " + number);
                    break;

                case 6:
                    Console.WriteLine("Veeretasid nr " + number);
                    break;

                default:
                    Console.WriteLine("Error");
                    break;



            }
        }
    }
}