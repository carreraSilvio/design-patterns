using StateDesignPattern.PlayerFSM;
using UnityEngine;

namespace StateDesignPattern
{
    public class StateExample : MonoBehaviour
    {
        public GameObject player;
        private FSM _playerFSM;

        private void Start()
        {
            _playerFSM = new FSM(player, PlayerStates.IdleState);
        }

        private void Update()
        {
            _playerFSM.Update();
        }
    }
}