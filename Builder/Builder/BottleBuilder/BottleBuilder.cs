using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BottleBuilder
{
    abstract class BottleBuilder
    {
        public abstract void BuildPlasticConstruction();
        public abstract void BuildCover();
        public abstract void BuildLabel();
        public abstract Bottle GetBottle();

    }
}
