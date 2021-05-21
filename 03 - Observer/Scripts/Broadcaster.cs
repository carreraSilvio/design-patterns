using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Broadcaster
{
    private static Dictionary<string, List<Action>> _broadcasts = new Dictionary<string, List<Action>>();

    public static void AddListener(string broadcastName, Action broadcastListener)
    {
        if(!_broadcasts.ContainsKey(broadcastName))
        {
            _broadcasts.Add(broadcastName, new List<Action>());
        }

        _broadcasts[broadcastName].Add(broadcastListener);
    }

    public static void RemoveListener(string broadcastName, Action broadcastListener)
    {
        if (!_broadcasts.ContainsKey(broadcastName))
        {
            return;
        }

        if (!_broadcasts[broadcastName].Contains(broadcastListener))
        {
            return;
        }
        _broadcasts[broadcastName].Remove(broadcastListener);
    }

    public static void Broadcast(string broadcastName)
    {
        if (!_broadcasts.ContainsKey(broadcastName))
        {
            return;
        }

        var handlers = _broadcasts[broadcastName];
        foreach(var listenerHandler in handlers)
        {
            listenerHandler();
        }
    }
}
