using System;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 9;

            MyClass obj = new MyClass(12345);

            for(int i = 0; i <= m; i++)
            {
                Console.Write("|" +obj[m-i]);
            }
            Console.WriteLine("|");
        }
    }
}
