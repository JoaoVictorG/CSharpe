using System;

namespace Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("----- . Parse");
                Console.WriteLine($"{Int16.Parse("150")}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
