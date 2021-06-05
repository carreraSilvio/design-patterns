using System;
using UnityEngine;

namespace PoolDesignPattern
{
    public class PoolItem : MonoBehaviour
    {
        public Action<PoolItem> OnRelease;

        private void Awake()
        {
            Debug.Log(name + " awake");
        }

        private void Start()
        {
            Debug.Log(name + " start");
        }

        private void OnEnable()
        {
            Debug.Log(name + " OnEnable");
        }
        private void OnDisable()
        {
            Debug.Log(name + " OnDisable");
        }

        //This only gets called if this game object has the render
        //if the renderer is in a child object this does not get called
        //NOTE-->If the object is still visible in the SceneView this won't fire as well
        private void OnBecameInvisible()
        {
            OnRelease?.Invoke(this);
        }
    }
}