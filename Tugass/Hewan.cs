using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tugass
{
    internal class Hewan
    {
        public void bernafas()
        {
            AIR air2 = new AIR();
            UDARA udara2 = new UDARA();
            DARAT darat2 = new DARAT();
            air2.berenang();
            udara2.terbang();
            darat2.jalan();
        }
    }
}
