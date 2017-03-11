using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CloudantDotNet.Models
{
    public class ListVote
    {
        private List<Vote> listeVote;
        Dictionary<String, List<Vote>> votesMap;

        public ListVote()
        {
            listeVote = new List<Vote>();
            votesMap = new Dictionary<string, List<Vote>>();
            Random random = new Random();

            for (int i = 0; i < 4; i++)
            {
                String caseName = "case" + i;
                List<Vote> list = new List<Vote>();
                for (int j = 0; j < 5; j++)
                {
                    Vote vote = new Vote();
                    vote.id = 50 * j + i;
                    vote.caseName = caseName;
                    vote.note = random.Next(0, 10);
                    vote.vocal = "Heavy Metal Pirate ftw!";
                    list.Add(vote);
                    
                }
                votesMap.Add(caseName, list);
            }

        }

        public List<Vote> DisplayListe(string caseName)
        {
            return votesMap[caseName];

        }
    }
}