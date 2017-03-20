
namespace VisitorPattern
{
    public class PanVisitor : IVisitor
    {
        public string Visit(Chicken meat)
        {
            return "The CHICKEN meat is being prepared in the PAN";
        }

        public string Visit(Beef meat)
        {
            return "The BEEF meat is being prepared in the PAN";
        }
    }
}
