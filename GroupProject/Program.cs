namespace GroupProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello everything!");
            Console.WriteLine("Witam w projekcie group 2 :)");

            Console.WriteLine("Multiplication table: "); //from Nazar Zharskyi
            MultipTable multip = new MultipTable();
            multip.mulipTable();
            Console.WriteLine("From Svitlana: Hi guys. Pleased to work with you."); //from Svitlana Leibak


            //from Gostev Nikita
            ZodiacIdentifi.ZodiacIdentifier();

            StarPicture();
            Cookies cookies = new Cookies();
            cookies.ScoreCookies(400);
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
