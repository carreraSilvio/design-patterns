using System.Collections.Generic;
using UnityEngine;

namespace PoolDesignPattern
{
    public class Pool : MonoBehaviour
    {
        public PoolItem prefab;
        public int initialSize = 5;
        public bool expands;
        private readonly List<PoolItem> _allItens = new List<PoolItem>();
        private readonly Queue<PoolItem> _availableItens = new Queue<PoolItem>();

        private void Start()
        {
            Grow(initialSize);
        }

        private void Grow(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                var go = Instantiate(prefab.gameObject, transform);
                go.name = $"{prefab.name}_{_allItens.Count:00}";
                go.SetActive(false);

                var poolItem = go.GetComponent<PoolItem>();
                poolItem.OnRelease += HandlePoolItemRelease;
                _availableItens.Enqueue(poolItem);
                _allItens.Add(poolItem);
            }
        }

        private void HandlePoolItemRelease(PoolItem poolItem)
        {
            poolItem.gameObject.SetActive(false);
            _availableItens.Enqueue(poolItem);
        }

        public PoolItem GetAvailable()
        {
            if(_availableItens.Count == 0 && expands)
            {
                Grow(initialSize);
            }

            var availableGo = _availableItens.Dequeue();
            return availableGo;
        }
    }
}