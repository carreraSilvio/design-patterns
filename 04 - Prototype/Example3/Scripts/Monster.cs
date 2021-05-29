namespace PrototypeDesignPattern.Example3
{
    public class Dragon : Prototype
    {
        public float flyightSpeed;

        public Dragon(string name):base(name)
        {
        }

        public override Prototype Clone()
        {
            return new Dragon(name);
        }
    }
}