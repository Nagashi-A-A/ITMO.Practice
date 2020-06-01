using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.Y2020.G124.Yaroshchuk.M5.E3.Chart
{
    public class Dat
    {
        Random r;

        public Dat()
        {
            r = new Random();
        }

        public Dat (int t)
        {
            r = new Random();
        }

        public int random(int t)
        {
            int res = r.Next();
            return res;
        }
    }
}
