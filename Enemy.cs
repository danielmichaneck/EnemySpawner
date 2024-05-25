using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyHandler
{
    internal class Enemy
    {
        private float _health;
        private EnemyType _type;

        public Enemy()
        {
            EnemyHelper.SetHealth(_type, ref _health);
        }

        public Enemy(EnemyType type) : base()
        {
            this._type = type;
        }

        internal virtual void Update()
        {
            Console.WriteLine($"I am {_type}! Tremble before me!");
        }
    }
}
