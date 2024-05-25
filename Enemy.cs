using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyHandler
{
    internal class Enemy
    {
        /// <summary>
        /// An enemy parent class.
        /// Every enemy has health and an enemy type.
        /// </summary>
        private float _health;
        private EnemyType _type;

        public Enemy()
        {
            // Default constructor!
            EnemyHelper.SetHealth(_type, ref _health);
        }

        public Enemy(EnemyType type) : base()
        {
            // Constructor with a parameter!
            // Sets the enemy type.
            // Because of " : base()" it also runs
            // the default constructor.
            this._type = type;
        }

        internal virtual void Update()
        {
            // Writes a message in the console.
            // The "Virtual" part of the method name means
            // that it can be overriden in child classes.
            // It is overridden in the EnemyHogger class!
            Console.WriteLine($"I am {_type}! Tremble before me!");
        }
    }
}
