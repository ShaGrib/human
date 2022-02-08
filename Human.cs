using System;

namespace human
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        public int Health
        {
            get { return health; }
        }

        public Human(string nmspace)
        {
            Name = nmspace;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public Human(string nmspace, int stre, int inte, int dext, int hp)
        {
            Name = nmspace;
            Strength = stre;
            Intelligence = inte;
            Dexterity = dext;
            health = hp;
        }

        public int Attack(Human target)
        {
            int damage = Strength * 5;
            target.health -= damage;
            Console.WriteLine($"{target.Name} was attacked by {Name} for {damage} points of health.");
            return target.health;
        }
    }
}