using System;
using System.Collections.Generic;

namespace dreamteam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Teammate> serverSideTeam = new List<Teammate>();
            List<Teammate> clientSideTeam = new List<Teammate>();
            serverSideTeam.Add(new Evan());
            serverSideTeam.Add(new Adam());
            serverSideTeam.Add(new Elliot());
            clientSideTeam.Add(new April());
            clientSideTeam.Add(new Jenn());
            clientSideTeam.Add(new Seth());

          foreach (Teammate t in serverSideTeam)
          {
              t.Work();
          }

          foreach (Teammate t in clientSideTeam)
          {
              t.Work();
          }
        }
    }
}
