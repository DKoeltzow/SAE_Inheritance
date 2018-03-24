using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Human peter = new Human("Peter", 100, 10, 0, 1);
            Orc ugratz = new Orc("Ugratz", 200, 20, 1, 1);

            peter.Attack(ugratz);

            Console.Read();
        }
    }
}
