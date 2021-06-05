using UnityEngine;

namespace StateDesignPattern.PlayerFSM
{
    public class IdleState : State
    {
        public override void Enter(Actor owner)
        {
            owner.animator.SetBool("isWalking", false);
        }

        public override State Update(Actor owner)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                return PlayerStates.MoveState;
            }

            return base.Update(owner);
        }
    }
}