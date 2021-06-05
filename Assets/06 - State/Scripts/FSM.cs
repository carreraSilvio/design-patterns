using UnityEngine;

namespace StateDesignPattern
{
    public class FSM
    {
        public State currentState;
        private Actor _owner;
        private State _initialState;

        public FSM(GameObject gameObject, State initialState)
        {
            _owner = new Actor(gameObject);
            _initialState = initialState;
            EnterState(_initialState);
        }

        public void Update()
        {
            var nextState = currentState.Update(_owner);
            if(nextState != currentState)
            {
                currentState.Exit(_owner);
                EnterState(nextState);
            }
        }

        private void EnterState(State state)
        {
            state.Enter(_owner);
            currentState = state;
        }
    }
}