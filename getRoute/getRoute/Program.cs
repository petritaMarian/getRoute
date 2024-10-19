using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getRoute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* input.txt:
            5
            Oradea
            Cluj
            Bucuresti
            Timisoara
            Iasi
            0 2
            0 4
            1 2
            1 3
            2 3
            2 4
            3 4
            */

            Country romania = new Country(@"..\..\Input.txt");
            List<List<int>> allPaths = new List<List<int>>();
            List<int> currentPath = new List<int>();
            bool[] visited = new bool[romania.cities.Count];

            foreach (City city in romania.cities)
                FindPath(romania, city.index, visited, currentPath, allPaths);

            foreach (List<int> list in allPaths)
            {
                for (int i = 0; i < list.Count - 1; i += 1)
                    Console.Write(romania.cities[list[i]].Name + " -> ");
                Console.Write(romania.cities[list[list.Count - 1]].Name + "\n");
            }
            Console.ReadLine(); 
        }

        static void FindPath(Country country, int currentCity, bool[] visited,List<int> currentPath, List<List<int>> allPaths)
        {
            visited[currentCity] = true;
            currentPath.Add(currentCity);

            if (currentPath.Count == country.cities.Count)
                allPaths.Add(new List<int>(currentPath));
            else
                foreach (City neighborCity in country.cities)
                    for (int i = 0; i < country.roads.Count; i++)
                        if (((country.roads[i].startIndex == currentCity 
                            && country.roads[i].endIndex == neighborCity.index) 
                            || (country.roads[i].endIndex == currentCity 
                            && country.roads[i].startIndex == neighborCity.index))
                            && !visited[neighborCity.index])
                            FindPath(country, neighborCity.index, visited, currentPath, allPaths);
            visited[currentCity] = false;
            currentPath.RemoveAt(currentPath.Count - 1);
        }
    }
}
