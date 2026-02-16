using System.Diagnostics.Tracing;
using System.Text.Json;

namespace JSONcrack
{
    class Adat
    {
        public List<string> nevek { get; set; }
        public List<int> korok { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            String fajl = File.ReadAllText("C:\\Users\\bakilv\\source\\repos\\JSONcrack\\JSONcrack\\adatok.json", System.Text.Encoding.Latin1);
            Adat adat = JsonSerializer.Deserialize<Adat>(fajl);


            foreach (var nev in adat.nevek)
            {
                Console.WriteLine(nev);
            }
            Console.WriteLine($"{adat.nevek[0]} életkor:{adat.korok[0]}");
        }
    }
}
