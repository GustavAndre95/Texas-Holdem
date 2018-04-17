using ConsoleApp1.Domain; // REMOVE THIS USING,  NEEDS TO USE DTO
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Data
{
    class PersistanceManager
    {
        // Should I allow multiple saves or just save after each gameturn?
        public void saveToFile(GameTable gt) //Should take dto as input
        {
            XDocument doc = new XDocument(new XElement("root", new XElement("players"), new XElement("gamedata")));
            foreach (Player p in gt.Players) // Add player data
            {
                doc.Root.Element("players").Add(new XElement("player", p.Name, new XAttribute("cash", p.Cash)));
            }
            doc.Root.Element("gamedata").Add(new XElement("blindvalue", gt.BlindValue)); // Add game data

            doc.Save("savedata.xml");
            Console.WriteLine(File.ReadAllText("savedata.xml"));
        }

        public void loadFromFile(GameTable gt)
        {
            List<Player> loadedPlayers = new List<Player>();
            XDocument doc = XDocument.Load("savedata.xml");
            var players = from r in doc.Root.Element("players").Descendants("player")
                          select new
                          {
                              Name = r.Value,
                              Cash = r.Attribute("cash").Value
                          };

            var blinds = from r in doc.Root.Descendants("gamedata")
                        select new
                        {
                            Value = r.Value
                        };

            foreach (var b in blinds)
            {
                gt.BlindValue = Int32.Parse(b.Value);
            }
           
            gt.Players.Clear();
            foreach ( var r in players)
            {
                gt.Players.Add(new Person(r.Name, Int32.Parse(r.Cash), gt));
            }
        }
    }
}
