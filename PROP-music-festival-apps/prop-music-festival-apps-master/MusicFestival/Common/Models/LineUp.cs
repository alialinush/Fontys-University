using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class LineUp
    {
        private List<string> artists;
        private int eventId;

        public LineUp(int eventid)
        {
            artists = new List<string>();
            eventId = eventid;
        }
        public void AddArtist(string nameArtist)
        {
            artists.Add(nameArtist);
        }
        public List<string> GetArtists()
        {
            return  artists;
        }

    }
}
