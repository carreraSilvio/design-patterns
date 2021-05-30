using UnityEngine;

namespace PoolDesignPattern
{
    public class Player : MonoBehaviour
    {
        public Pool bulletPool;
        public Transform shootSpot;

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Shoot();
            }
        }

        public void Shoot()
        {
            var bullet = bulletPool.GetAvailable().GetComponent<Bullet>();
            bullet.transform.position = shootSpot.position;
            bullet.gameObject.SetActive(true);
        }
    }
}