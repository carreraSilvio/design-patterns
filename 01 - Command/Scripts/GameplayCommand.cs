using UnityEngine;

namespace CommandDesignPattern
{
    public abstract class GameplayCommand : MonoBehaviour
    {
        protected bool _isDone;
        public bool IsDone => _isDone;

        public virtual void Prepare()
        {
            _isDone = false;
        }

        public abstract void Execute();
    }
}