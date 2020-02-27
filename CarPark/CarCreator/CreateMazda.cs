using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark
{
    internal class CreateMazda : CarCreator
    {
        public override ICar FactoryMethod()
        {
            return new Mazda();
        }
    }
}
