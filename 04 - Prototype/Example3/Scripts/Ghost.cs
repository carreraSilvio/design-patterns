namespace PrototypeDesignPattern.Example3
{
    public class Ghost : Prototype
    {
        public int health;
        public int speed;

        public Ghost(string name):base(name)
        {
        }

        public override Prototype Clone()
        {
            var cloned = new Ghost(name)
            {
                health = this.health,
                speed = this.speed
            };
            return cloned;
        }
    }
}