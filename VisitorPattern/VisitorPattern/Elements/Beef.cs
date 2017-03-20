using System;

namespace VisitorPattern
{
    public class Beef : Meat    
    {
        public override string Acccept(IVisitor visitor)
        {
           return visitor.Visit(this);
        }
    }
}
