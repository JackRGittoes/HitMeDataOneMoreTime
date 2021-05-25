using System;
using System.Collections.Generic;
using System.Linq;

namespace HitMeDataOneMoreTime
{
    public class SongRepository : ISongRepository
    {
        private IList<Song> _data;
        public SongRepository(IList<Song> data)
        {
            _data = data;
        }
        public int HowManyHits(string artist)
        {
            // Counts the amount of times the artist occures in the data, then counts the amount of times the dateentered is before the year 2000
            var dt = new DateTime(2000, 1, 1);
            return _data.Count(d => d.artist.ToLower() == artist.ToLower() && d.dateentered < dt);
        }

        public string LongestSong()
        {
            // Orders by the longest song time and then selects the first track.
            return _data.OrderByDescending(d => d.time).FirstOrDefault()?.track;
        }

        public string MostSingles()
        {
            //Groups the artists, Orders them by the most amount of entries and then selects the First one by the key. 
            return _data.GroupBy(d => d.artist).OrderByDescending(o => o.Count()).FirstOrDefault()?.Key;
        }
    }
}
