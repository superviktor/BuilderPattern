using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BottleBuilder
{
    class Director
    {
        private BottleBuilder builder;

        public Director(BottleBuilder b)
        {
            builder = b;
        }

        public void Construct()
        {
            builder.BuildPlasticConstruction();
            builder.BuildCover();
            builder.BuildLabel();
        }
    }
}
