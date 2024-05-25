using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyHandler
{
    internal class EnemyHogger : Enemy
    {
        /// <summary>
        /// A special enemy that overrides the regular Update() method.
        /// </summary>
        internal override void Update()
        {
            Console.WriteLine("I am Hogger! RAWR!");
        }
    }
}
