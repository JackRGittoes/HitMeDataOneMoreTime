using System;
using System.Collections.Generic;
using System.Text;

namespace HitMeDataOneMoreTime
{
    public interface ISongRepository
    {
        public int HowManyHits(string artist);
        public string MostSingles();
        public string LongestSong();

    }
}
