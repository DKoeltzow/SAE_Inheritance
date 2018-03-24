using System;

namespace Inheritance
{
    // Use the abstract keyword to use a class only for inheritance.
    // There can be no instances of an abstract class.
    // To prevent inheritance use the sealed keyword.
    abstract class Unit
    {
        protected string name;
        protected int health;
        protected int attackPower;
        protected int position;
        protected int range;

        // Implement an empty default constructor to avoid being forced to use the
        // constructor with arguments in derived classes.
        public Unit()
        { 
        }

        public Unit(string name, int health, int attackPower, int position, int range)
        {
            this.name = name;
            this.health = health;
            this.attackPower = attackPower;
            this.position = position;
            this.range = range;
        }

        public void Attack(Unit unit)
        {
            if (CheckRange(unit))
            {
                Console.WriteLine(this.name + " attacks " + unit.name);
                unit.GetDamage(this.attackPower);
            }
        }

        private void GetDamage(int damage)
        {
            this.health -= damage;
            Console.WriteLine(this.name + " got " + damage + " damage");

            if (health <= 0)
            {
                Console.WriteLine(this.name + " died.");
            }
        }

        private bool CheckRange(Unit unit)
        {
            int distance = this.GetDistance(this.position, unit.position);

            // Use the conditional operator for a short if expression.
            // It returns one of two values depending on the result of the condition
            // Syntax: condition ? value1 : value2;
            return this.range >= distance ? true : false;
        }

        private int GetDistance(int positionA, int positionB)
        {
            return Math.Abs(positionA - positionB);
        }

        // Define an abstract method to get a method without implementation.
        // Abstract methods can only be defined in abstract classes.
        // Derived classes must implement all abstract methods.
        public abstract void SpecialAbility();
    }
}
