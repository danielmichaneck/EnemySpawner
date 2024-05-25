using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyHandler
{
    internal class Enemy
    {
        private EnemyType _type;

        public Enemy(EnemyType type)
        {
            this._type = type;
        }
    }
}
