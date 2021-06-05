using UnityEngine;

namespace ObserverDesignPattern
{
    public class Coin : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.transform.CompareTag("Player"))
            {
                Broadcaster.Broadcast(BroadcastIds.COIN_PICKED);
                gameObject.SetActive(false);
            }
        }
    }
}