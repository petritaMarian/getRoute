using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getRoute
{
    public class Road
    {
        public City start, end;
        public int startIndex, endIndex;

        public Road(string data, List<City> cities)
        {
            string[] temp = data.Split(' ');
            start = cities[int.Parse(temp[0])];
            startIndex = int.Parse(temp[0]);
            end = cities[int.Parse(temp[1])];
            endIndex = int.Parse(temp[1]);
        }
    }
}
