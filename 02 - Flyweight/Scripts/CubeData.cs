using UnityEngine;

namespace FlyweightDesignPattern
{
    [CreateAssetMenu(fileName = nameof(CubeData), menuName = "Data/Flyweight/" + nameof(CubeData))]
    public class CubeData : ScriptableObject
    {
        public string displayName;
        [TextArea(10, 10)]
        public string info;
    }
}