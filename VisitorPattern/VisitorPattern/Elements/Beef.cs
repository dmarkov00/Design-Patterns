using System;

namespace VisitorPattern
{
    public class Beef : Meat    
    {
        public override void Acccept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
