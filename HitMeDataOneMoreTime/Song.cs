using System;
using System.Collections.Generic;
using System.Text;

namespace HitMeDataOneMoreTime
{
    public class Song
    {
        public int year { get; set; }
        public string artist { get; set; }
        public string track { get; set; }
        public TimeSpan time { get; set; }
        public string genre { get; set; }
        public DateTime dateentered { get; set; }
        public DateTime datepeaked { get; set; }
    }
}
