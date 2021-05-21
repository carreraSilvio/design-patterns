using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
