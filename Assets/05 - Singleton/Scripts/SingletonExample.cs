using System.Collections.Generic;
using UnityEngine;

namespace SingletonDesignPattern
{
    public class SingletonExample : MonoBehaviour
    {
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Player.Instance.Health -= 10;
            }
        }
    }
}