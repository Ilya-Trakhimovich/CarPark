using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark
{
    public class CreateMazda : CarCreator1
    {
        public override ICar FactoryMethod()
        {
            return new Mazda();
        }
    }
}
