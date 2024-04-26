namespace GroupProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello everything!");
            Console.WriteLine("Witam w projekcie group 2 :)");

            StarPicture();
        }

        static void StarPicture()
        {
            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < i; j ++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
