using UnityEngine;

namespace CommandDesignPattern
{
    public class Wait : GameplayCommand
    {
        public float duration;
        private float timeStarted;

        protected override void OnPrepare()
        {
            timeStarted = Time.time;
        }

        public override void Execute()
        {
            if(Time.time - timeStarted > duration)
            {
                _isDone = true;
            }
        }
    }
}