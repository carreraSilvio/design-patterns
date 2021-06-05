using UnityEngine;

namespace PoolDesignPattern
{
    public class Bullet : MonoBehaviour
    {
        public float speed;

        private void Update()
        {
            var moveX = speed * Time.deltaTime;
            var pos = transform.position;
            pos.x += moveX;
            transform.position = pos;
        }
    }
}