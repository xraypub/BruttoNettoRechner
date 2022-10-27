using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruttoNettoRechner.Model
{
    internal class Kinderfreibetrag
    {
        public List<string> KinderFreibetrag;

        private const decimal KinderFB = 5460.00m;
        private const decimal KinderAusbFB = 2928.00m;


        public Kinderfreibetrag()
        {
            KinderFreibetrag = new() { "0", "0,5", "1,0", "1,5", "2,0", "2,5", "3,0", "3,5", "4,0", "4,5", "5,0" };
        }

    }
}
