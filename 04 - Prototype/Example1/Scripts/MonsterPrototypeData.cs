using UnityEngine;

namespace PrototypeDesignPattern.Example1
{
    [CreateAssetMenu(menuName = nameof(PrototypeDesignPattern) + "/" + nameof(MonsterPrototypeData))]
    public class MonsterPrototypeData : ScriptableObject
    {
        public new string name;
        public int health;
        public int damage;
    }
}