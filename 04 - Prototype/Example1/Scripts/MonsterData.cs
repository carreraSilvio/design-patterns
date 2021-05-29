using UnityEngine;

namespace PrototypeDesignPattern
{
    [CreateAssetMenu(menuName = nameof(PrototypeDesignPattern) + "/" + nameof(MonsterData))]
    public class MonsterData : MonsterPrototypeData
    {
        public MonsterPrototypeData prototypeData;
    }

}
