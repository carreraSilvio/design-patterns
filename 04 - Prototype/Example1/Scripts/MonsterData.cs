using UnityEngine;

namespace PrototypeDesignPattern.Example1
{
    [CreateAssetMenu(menuName = nameof(PrototypeDesignPattern) + "/" + nameof(MonsterData))]
    public class MonsterData : MonsterPrototypeData
    {
        public MonsterPrototypeData prototypeData;
    }
}