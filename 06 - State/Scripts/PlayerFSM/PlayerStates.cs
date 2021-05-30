namespace StateDesignPattern.PlayerFSM
{
    public static class PlayerStates
    {
        public static IdleState IdleState = new IdleState();
        public static MoveState MoveState = new MoveState();
    }
}