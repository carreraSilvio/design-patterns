using UnityEngine;

namespace PrototypeDesignPattern.Example3
{
    public class PrototypeExample3 : MonoBehaviour
    {
        private Spawner<Ghost> _ghostSpawner;
        private Spawner<Dragon> _dragonSpawner;

        private void Start()
        {
            _ghostSpawner = new Spawner<Ghost>(new Ghost("Ghost"));
            _dragonSpawner = new Spawner<Dragon>(new Dragon("Dragon"));
        }

        private void Update()
        {
            if(Random.Range(0, 100) > 10)
            {
                var ghost = _ghostSpawner.Spawn();
                Debug.Log($"{ghost.name} created");
            }
            if (Random.Range(0, 100) > 10)
            {
                var dragon = _dragonSpawner.Spawn();
                Debug.Log($"{dragon.name} created");
            }
        }
    }
}