namespace GroupProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello everything!");
            Console.WriteLine("Witam w projekcie group 2 :)");
            Console.WriteLine("Multiplication table: ");
            MultipTable multip = new MultipTable();
            multip.mulipTable();
        }
    }
}
