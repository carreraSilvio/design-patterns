using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeDesignPattern.Example3
{
    public class Spawner<T> where T : Prototype
    {
        private readonly Prototype _prototype;
        private int _totalSpawned;

        public Spawner(Prototype prototype)
        {
            _prototype = prototype;
        }

        public Prototype Spawn()
        {
            var clone = _prototype.Clone();
            clone.name += $"_{_totalSpawned}";
            _totalSpawned++;
            return clone;
        }
    }
}