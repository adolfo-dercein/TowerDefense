using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets._Code.Scripts.Util
{
    public class EntityPool<T> where T : MonoBehaviour, PoolableEntity
    {
        private T prefab;
        private Transform container;
        List<T> masterList = new List<T>();

        IEnumerable<T> AvailableUnits => masterList.Where(e => !e.InUse);

        public EntityPool(T prefab, Transform container)
        {
            this.prefab = prefab;
            this.container = container;
        }

        public T PullEntity()
        {
            if (AvailableUnits.Any())
                return AvailableUnits.First();
            
            var entity = GameObject.Instantiate(prefab, container);
            masterList.Add(entity);
            return entity;
        }
    }
}