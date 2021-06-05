using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeDesignPattern.Example2
{

    public class MonsterSpawner
    {
        private readonly Monster _prototypeMonster;
        private int _totalSpawned;

        public MonsterSpawner(Monster prototypeMonster)
        {
            _prototypeMonster = prototypeMonster;
        }

        public Monster Spawn()
        {
            var clone = _prototypeMonster.Clone();
            clone.name += $"_{_totalSpawned}";
            _totalSpawned++;
            return clone;
        }
    }
}