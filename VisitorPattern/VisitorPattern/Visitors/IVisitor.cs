namespace VisitorPattern
{
    public interface IVisitor
    {
        string Visit(Beef meat);
        string Visit(Chicken meat);
    }
}
