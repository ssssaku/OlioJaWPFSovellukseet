namespace Harjoitus7
{
    static class Error
    {
        public static void KirjoitaError(string virhe)
        {
            Console.WriteLine("-----------");
            Console.WriteLine("Error message: " + virhe);
            Console.WriteLine("-----------");
        }
    }
}