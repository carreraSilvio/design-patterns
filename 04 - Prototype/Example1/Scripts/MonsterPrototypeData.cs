using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeDesignPattern
{
    [CreateAssetMenu(menuName = nameof(PrototypeDesignPattern) + "/" + nameof(MonsterPrototypeData))]
    public class MonsterPrototypeData : ScriptableObject
    {
        public new string name;
        public int health;
        public int damage;
    }

}
