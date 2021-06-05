using UnityEngine;

namespace PrototypeDesignPattern.Example2
{
    public class PrototypeExample2 : MonoBehaviour
    {
        private MonsterSpawner _ghostSpawner;

        private void Start()
        {
            _ghostSpawner = new MonsterSpawner(new Ghost("ghost"));
        }

        private void Update()
        {
            if(Random.Range(0, 100) > 10)
            {
                var ghost = _ghostSpawner.Spawn();
                Debug.Log($"{ghost.name} created");
            }
        }
    }
}