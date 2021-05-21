using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsUI : MonoBehaviour
{
    public Text coinsTxt;
    private int _coins;


    private void OnEnable()
    {
        Broadcaster.AddListener(BroadcastIds.COIN_PICKED, HandleCoinPick);
    }

    private void OnDisable()
    {
        Broadcaster.RemoveListener(BroadcastIds.COIN_PICKED, HandleCoinPick);
    }

    public void HandleCoinPick()
    {
        _coins = _coins + 1;
        coinsTxt.text = $"COINS: {_coins}";
        Debug.Log($"coins is {_coins}");
    }
}
