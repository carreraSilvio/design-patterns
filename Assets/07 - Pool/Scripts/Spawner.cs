using UnityEngine;

namespace PoolDesignPattern
{
    public class Spawner : MonoBehaviour
    {
        public Pool pool;
        public float frequency = 0.3f;
        public float radius = 1f;
        private float _lastTimeSpawned;

        private void OnEnable()
        {
            _lastTimeSpawned = Time.time;
        }

        private void Update()
        {
            if(Time.time - _lastTimeSpawned > frequency)
            {
                Spawn();
            }
        }

        private void Spawn()
        {
            var poolItem = pool.GetAvailable();
            var pos = transform.position;
            pos.x += Random.Range(-radius, radius);
            pos.y +=  Random.Range(-radius, radius);
            poolItem.transform.position = pos;
            poolItem.gameObject.SetActive(true);
            _lastTimeSpawned = Time.time;
        }

        private void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(transform.position, radius);
        }
    }
}