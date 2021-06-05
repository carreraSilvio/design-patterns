using UnityEngine;

namespace CommandDesignPattern
{
    public abstract class GameplayCommand : MonoBehaviour
    {
        protected bool _isDone;
        public bool IsDone => _isDone;

        public void Prepare()
        {
            _isDone = false;
            OnPrepare();
        }

        protected virtual void OnPrepare()
        {
        }

        public abstract void Execute();
    }
}