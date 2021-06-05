using UnityEngine;

namespace StateDesignPattern.PlayerFSM
{
    public class MoveState : State
    {

        public override void Enter(Actor owner)
        {
            owner.animator.SetBool("isWalking", true);
        }

        public override State Update(Actor owner)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                return PlayerStates.IdleState;
            }

            return base.Update(owner);
        }
    }
}