namespace PrototypeDesignPattern.Example3
{
    public class Prototype
    {
        public string name;

        public Prototype(string name)
        {
            this.name = name;
        }

        public virtual Prototype Clone()
        {
            return new Prototype(name);
        }
    }
}