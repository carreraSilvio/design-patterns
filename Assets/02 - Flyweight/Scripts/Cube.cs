using UnityEngine;

namespace FlyweightDesignPattern
{
    public class Cube : MonoBehaviour
    {
        public CubeData data;

        private void OnMouseDown()
        {
            Debug.Log($"Clicked {data.displayName}! Info: {data.info}");
        }
    }
}