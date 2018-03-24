using System;

namespace Inheritance
{
    // Classes can inherit from other classes.
    // A class that inherits from another class is called derived class.
    // The derived class inherits all non private data and behaviour.
    class Human : Unit
    {
        public Human(string name, int health, int attackPower, int position ,int range) 
            : base(name, health, attackPower, position ,range)
        {
        }

        // To implement an abstract method, use override
        public override void SpecialAbility()
        {
            throw new NotImplementedException();
        }
    }
}
