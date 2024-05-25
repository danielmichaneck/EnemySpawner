using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyHandler
{
    internal class EnemySpawner
    {
        /// <summary>
        /// Contains a timer and spawns a
        /// random enemy when it is time.
        /// </summary>
        private Stopwatch timer = new Stopwatch();

        public EnemySpawner()
        {
            // Decimal for clarity.
            timer.Start();
        }

        private Enemy SpawnRandomEnemy()
        {
            EnemyType type = EnemyHelper.GetRandomEnemyType();
            switch (type)
            {
                case EnemyType.Hogger:
                    return new EnemyHogger();

                default:
                    return new Enemy(type);
            }
        }

        public Enemy? SpawnUpdate()
        {
            // Checks if timer has reached 2 seconds (2000 milliseconds).
            if (timer.ElapsedMilliseconds > 2000.0)
            {
                timer.Restart();
                return SpawnRandomEnemy();
                    
            }
            // No need for an "else" here, since the method has already ended if true.
            return null;
            // The ? in Enemy? means that the variable can be null
        }
    }
}
