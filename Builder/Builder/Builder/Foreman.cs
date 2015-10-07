using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class Foreman
    {
        private Builder builder;

        public Foreman(Builder b)
        {
            this.builder = b;
        }

        public void Construct()
        {
            builder.BuildBasement();
            builder.BuiltStorey();
            builder.BuildRoof();
        }
    }
}
