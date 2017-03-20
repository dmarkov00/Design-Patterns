using System;

namespace VisitorPattern
{
    public class Chicken : Meat
    {
        public override string Acccept(IVisitor visitor)
        {
           return visitor.Visit(this);
        }
    }
}
