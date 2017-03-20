namespace VisitorPattern
{
    public abstract class Meat
    {
        public string Type { get; set; }
        public abstract void Acccept(IVisitor visitor);
    }
}
