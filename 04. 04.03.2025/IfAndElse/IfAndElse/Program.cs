namespace IfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if ja else rakendus tuleb teha
            //kontrollib sinu vanust
            //1. kui oled alla 18, siis konsool annab vastuseks,
            //et oled alaealine

            //2. Kui oled 19 kuni 65 aastat vana, siis
            // konsool vastab, et oled täisealine

            //3. Kui oled üle 65 a vana, siis pensionäär


            Console.WriteLine("Sisesta enda vanus!");

            int age = int.Parse(Console.ReadLine());

            if (age >= 0 && age <= 18)
            {
                Console.WriteLine("Oled alaealine");
            }
            else if (age >= 18 && age < 65)
            {
                Console.WriteLine("Oled täisealine");
            }
            else
            {
                Console.WriteLine("Oled pensionäär");
            }
        }
    }
}
