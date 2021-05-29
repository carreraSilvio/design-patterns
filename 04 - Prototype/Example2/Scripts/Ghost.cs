namespace PrototypeDesignPattern.Example2
{
    public class Ghost : Monster
    {
        public int health;
        public int speed;

        public Ghost(string name):base(name)
        {
        }

        public override Monster Clone()
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