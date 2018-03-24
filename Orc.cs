using System;

namespace Inheritance
{
    class Orc : Unit
    {
        public Orc(string name, int health, int attackPower, int position , int range) 
            : base(name, health, attackPower, position, range)
        {

        }

        // Use sealed to prevent derived classes to override abstract methods from base classes.
        public sealed override void SpecialAbility()
        {
            throw new NotImplementedException();
        }
    }
}
