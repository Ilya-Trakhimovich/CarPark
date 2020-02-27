using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark
{
    internal class CreateBMW : CarCreator
    {
        public override ICar FactoryMethod()
        {
            return new BMW();
        }
    }
}
