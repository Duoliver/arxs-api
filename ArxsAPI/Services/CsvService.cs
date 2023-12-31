namespace ArxsAPI.Services
{
    public class CsvService
    {
        public List<string[]> GetStringsFromFile(Stream file, char separator)
        {
            List<string[]> Strings = [];
            using (var reader = new StreamReader(file))
            {
                var header = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine()!;
                    var values = line.Split(separator);

                    Strings.Add(values);
                }
            }
            return Strings;
        }
    }
}