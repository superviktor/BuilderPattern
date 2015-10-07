using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BottleBuilder
{
    class PepsiBottleBuilder:BottleBuilder
    {
        private Bottle bottle = new Bottle();
        public override void BuildPlasticConstruction()
        {
           bottle.Add(new PlasticConstruction());
        }

        public override void BuildCover()
        {
           bottle.Add(new Cover());
        }

        public override void BuildLabel()
        {
            bottle.Add(new Label());
        }

        public override Bottle GetBottle()
        {
            return bottle;
        }
    }
}
