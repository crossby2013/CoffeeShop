using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocha
{
    public class Coffee
    {
        public CoffeeSize size;

        public Coffee(CoffeeSize size)
        {
            this.size = size;
        }

        public CoffeeSize Size
        {
            get { return size; }
        }

    }
}
