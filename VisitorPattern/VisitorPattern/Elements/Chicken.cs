using System;

namespace VisitorPattern
{
    public class Chicken : Meat
    {
        public override void Acccept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
