using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getRoute
{
    public class Country
    {
        public List<City> cities = new List<City>();
        public List<Road> roads = new List<Road>();

        public Country(string filename)
        {
            string buffer;
            TextReader load = new StreamReader(filename);
            int num = int.Parse(load.ReadLine());

            for (int i = 0; i < num; i += 1)
                cities.Add(new City(load.ReadLine(), i));

            while ((buffer = load.ReadLine()) != null)
                roads.Add(new Road(buffer, cities));
        }
    }
}
