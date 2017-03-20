
namespace VisitorPattern
{
    public class OvenVisitor : IVisitor
    {
        public string Visit(Chicken meat)
        {
            return "The CHICKEN meat is being prepared in the OVEN";
        }

        public string Visit(Beef meat)
        {
            return "The BEEF meat is being prepared in the OVEN";
        }
    }
}
