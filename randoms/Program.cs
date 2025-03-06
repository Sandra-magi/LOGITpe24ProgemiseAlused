namespace randoms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int number = new Random().Next(1, 7); 

            switch (number)

            case 1:
                Console.WriteLine("veeretasid nr " + number);
                break;

                default:
                Console.WriteLine("error");
                break;

            case 2:
                Console.WriteLine("veeretasid nr " + number);
                break;

            default:
                Console.WriteLine("error");
                break;

            case 3:
                Console.WriteLine("veeretasid nr " + number);
                break;

            default:
                Console.WriteLine("error");
                break;

            case 4:
                Console.WriteLine("veeretasid nr " + number);
                break;

            default:
                Console.WriteLine("error");
                break;

            case 5:
                Console.WriteLine("veeretasid nr " + number);
                break;

            default:
                Console.WriteLine("error");
                break;

            case 6:
                Console.WriteLine("veeretasid nr " + number);
                break;

            default:
                Console.WriteLine("error");
                break;
            }
}