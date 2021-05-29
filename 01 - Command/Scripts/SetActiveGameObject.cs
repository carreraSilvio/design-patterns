using UnityEngine;

namespace CommandDesignPattern
{
    public class SetActiveGameObject : GameplayCommand
    {
        public GameObject target = default;
        public bool active;

        public override void Execute()
        {
            target.gameObject.SetActive(active);
            _isDone = true;
        }
    }
}