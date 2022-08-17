using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            char character = 'a';
            while(character < 'z')
            {
                Console.Write(character);
                character++;
            }
            string[] arabalar = { " ", "Mini Cooper", "BMW", "Ford", "Nissan" };
            foreach(var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
