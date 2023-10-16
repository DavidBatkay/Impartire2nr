namespace impartire2nr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.Write("a= ");
            a=int.Parse(Console.ReadLine());
            Console.Write("b= ");
            b=int.Parse(Console.ReadLine());
            if (a % b != 0)
                Console.WriteLine("Nu se poate efectua impartirea exacta");
            else 
                Console.WriteLine(a / b);

        }
    }
}