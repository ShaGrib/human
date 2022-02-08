using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human joofy = new Human("Joofy");
            Human ragamuffin = new Human("Ragamuffin",5,5,5,50);
            joofy.Attack(ragamuffin);
        }
    }
}
