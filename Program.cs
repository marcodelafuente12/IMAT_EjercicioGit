namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divide(0, 9));
        }

        static public int Add(int x, int y) { return x + y; }
        static public int Multiply(int x, int y) { return x * y; }
        static public int Divide(int x, int y) {return x / y; }
    }
}