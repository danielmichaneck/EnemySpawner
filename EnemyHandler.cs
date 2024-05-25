using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyHandler
{
    internal class EnemyHandler
    {
        /// <summary>
        /// The class that handles all the enemies
        /// and the spawner.
        /// </summary>
        private List<Enemy> _enemies = new List<Enemy>();
        private EnemySpawner _spawner = new EnemySpawner();

        private void AddEnemy(Enemy enemy)
        {
            // Adds an enemy to the private
            // enemy list.
            _enemies.Add(enemy);
        }

        internal void UpdateEnemies()
        {
            // Updates all the enemies in the
            // enemy list. They all write
            // a message in the console when
            // updated.
            foreach(Enemy enemy in _enemies)
            {
                enemy.Update();
            }
        }

        public bool Update()
        {
            // Checks its spawner if it is time
            // to spawn a new enemy. If no,
            // the SpawnUpdate() returns null.
            // If yes, returns a new Enemy.
            // It then adds the enemy to the enemy
            // list and updates all enemies.
            Enemy? newEnemy = _spawner.SpawnUpdate();
            if (newEnemy != null)
            {
                AddEnemy(newEnemy);
                UpdateEnemies();
                return true;
            }
            return false;
        }
    }
}
