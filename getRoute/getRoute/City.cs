using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getRoute
{
    public class City
    {
        public string Name;
        public int index;

        public City(string data, int index)
        {
            Name = data;
            this.index = index;
        }
    }
}
