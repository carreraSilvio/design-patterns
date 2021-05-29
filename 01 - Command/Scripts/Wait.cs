using UnityEngine;

namespace CommandDesignPattern
{
    public class Wait : GameplayCommand
    {
        public float duration;
        private float timeStarted;

        public override void Execute()
        {
            if(timeStarted == 0)
            {
                timeStarted = Time.time;
            }

            if(Time.time - timeStarted > duration)
            {
                _isDone = true;
            }
        }
    }
}