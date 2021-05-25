using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;


namespace HitMeDataOneMoreTime
{
    public class DataLoader
    {
        public static IList<Song> loadCSV(string fileName)
        {
            using (TextReader reader = new StreamReader(fileName))
            {
                var csvReader = new CsvReader(reader, CultureInfo.CurrentCulture);
                return csvReader.GetRecords<Song>().ToList();
            }
        }
    }
}
