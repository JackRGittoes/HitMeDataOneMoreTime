using System;
using HitMeDataOneMoreTime;

namespace HitMeDataOneMoreTime
{
    public class Program
    {
        static void Main(string[] args)
        {
            var data = DataLoader.loadCSV("billboard.csv");
            var repo = new SongRepository(data);

            // How many hit singles did mariah carey have before the year 2000
            var result = repo.HowManyHits("Carey, Mariah");
            Console.WriteLine(result);

            //Which artist had the most singles
            var result2 = repo.MostSingles();
            Console.WriteLine(result2);

            //Which song has the longest playtime
            var result3 = repo.LongestSong();
            Console.WriteLine(result3);
        }
    }
}
