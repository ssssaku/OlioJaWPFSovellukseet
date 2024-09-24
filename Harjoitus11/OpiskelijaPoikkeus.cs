namespace Harjoitus11
{
    class OpiskelijaPoikkeus : Exception
    {
        public OpiskelijaPoikkeus(string message) : base(message)
        {
            Console.WriteLine();
            Console.WriteLine("-----ERROR-----");
            Console.WriteLine("Error: " + message);
            Console.WriteLine("-----ERROR-----");
            Console.WriteLine();
        }
    }
}