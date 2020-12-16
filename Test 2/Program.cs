using System;

namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float balance = 10;
            float withdrawal = 30;
            bool go;
            if (balance >= withdrawal)
            {
                balance -= withdrawal;
                go = true;
                Console.WriteLine(balance);
            } else
            {
                go = false;
            }
            Console.WriteLine(go);
        }
    }
}
