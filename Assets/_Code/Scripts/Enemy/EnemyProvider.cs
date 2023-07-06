using System.Collections.Generic;
using System.Linq;
using Assets._Code.Scripts.Enemy.Entities;
using UnityEngine;

namespace Assets._Code.Scripts.Enemy
{
    public class EnemyProvider
    {
        IList<EnemyEntity> enemies = new List<EnemyEntity>();

        public void RegisterEnemy(EnemyEntity enemy) => 
            enemies.Add(enemy);

        public bool IsEnemyInRange(Vector3 origin, float threshold) =>
            enemies.Any(e => Vector3.Distance(e.transform.position, origin) <= threshold);

        public EnemyEntity GetClosestEnemyToPoint(Vector3 origin, float threshold) =>
            enemies.Select(e => new { enemy = e, distance = Vector3.Distance(e.transform.position, origin) })
                .Where(ed => ed.distance <= threshold)
                .OrderBy(ed => ed.distance)
                .First().enemy;
    }
}