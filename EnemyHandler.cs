using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyHandler
{
    internal class EnemyHandler
    {
        private List<Enemy> _enemies = new List<Enemy>();
        private EnemySpawner _spawner = new EnemySpawner();

        private void AddEnemy(Enemy enemy)
        {
            _enemies.Add(enemy);
        }

        internal void UpdateEnemies()
        {
            foreach(Enemy enemy in _enemies)
            {
                enemy.Update();
            }
        }

        public bool Update()
        {
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
