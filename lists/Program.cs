using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            List<string> secondPlanetList = new List<string>(){"Uranus", "Neptune"};

            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            planetList.AddRange(secondPlanetList);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            planetList.Remove("Pluto");

            foreach (string item in planetList)
            {
                Console.WriteLine(item);
            }

            List<string> theRockies = planetList.GetRange(0, 4);
            foreach (string item in theRockies)
            {
                Console.WriteLine(item);
            }

            //  empty list of probes
            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();

            // creates probe
            Dictionary<string, string> viking = new Dictionary<string, string>();
            viking["Mars"] = "Viking";

            //  creates probe
            Dictionary<string, string> opportunity = new Dictionary<string, string>() {
              {"Mars", "Opportunity"}
            };

            //  creates probe
            Dictionary<string, string> mariner10 = new Dictionary<string, string>() {
              {"Mercury", "Mariner 10"}
            };

            Dictionary<string,string> Venus = new Dictionary<string, string>{{"Venus", "Pioneer Venus Multiprobe"}};
            Dictionary<string, string> Jupiter = new Dictionary<string, string>{{"Jupiter", "Pioneer 10"}};
            Dictionary<string, string> Saturn = new Dictionary<string, string>{{"Saturn", "Voyager 1"}};
            Dictionary<string, string> Uranus = new Dictionary<string, string>{{"Uranus", "Voyager 2"}};
            Dictionary<string, string> Neptune = new Dictionary<string, string>{{"Neptune", "Voyager 2"}};

            //  Add probes to the list
            probes.Add(viking);
            probes.Add(opportunity);
            probes.Add(mariner10);
            probes.Add(Venus);
            probes.Add(Jupiter);
            probes.Add(Saturn);
            probes.Add(Uranus);
            probes.Add(Neptune);

            /* the planet name is a foreign key in the probes list back to the planet list */

            foreach (string planet in planetList)
            {
                List<string> visitedProbes = new List<string>();

                foreach (Dictionary<string, string> probe in probes)
                {
                  //  Does the current planet name in the dictionary match the name of the planet in the planet list?
                    if (probe.ContainsKey(planet)) {
                      visitedProbes.Add(probe[planet]);
                    }
                }
                //  Output the name of the planet and comma separated list of matching probes.
                if (visitedProbes.Count > 0) {
                  Console.WriteLine($"{planet}: {String.Join(",", visitedProbes)}");
                }
            }
        }
    }
}
