using System;

namespace abstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Base obj = new Alpha("Alpha");
            Console.WriteLine(obj.text);
            obj.text = "Base";

            for(int k = 0; k < obj.lenght; k++)
            {
                Console.Write("|" + obj[k]);
            }
            Console.WriteLine("|");


            obj = new Bravo("Bravo");

            for (int k = 0; k < obj.lenght; k++)
            {
                Console.Write("|" + obj[k]);
            }

            Console.WriteLine("|");
            obj.text = "Base";
            Console.WriteLine(obj.text);
        }
    }
}
