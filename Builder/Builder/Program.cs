using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.BottleBuilder;
using Builder.Builder;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //house building
            Builder.Builder b = new ConcreteBuilder();
            Foreman f = new Foreman(b);
            f.Construct();
            House h = b.GetResult();
            //bottle building
            BottleBuilder.BottleBuilder bb = new PepsiBottleBuilder();
            Director d = new Director(bb);
            d.Construct();
            Bottle bottle = bb.GetBottle();
        }
    }
}
