namespace PrototypeDesignPattern.Example2
{
    public class Monster
    {
        public string name;

        public Monster(string name)
        {
            this.name = name;
        }

        public virtual Monster Clone()
        {
            return new Monster(name);
        }
    }
}