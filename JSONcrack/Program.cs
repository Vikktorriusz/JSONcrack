using System.Diagnostics.Tracing;
using System.Text.Json;

namespace JSONcrack
{
    class Adat
    {
        public List<string> nevek { get; set; }
        public List<int> korok { get; set; }
    }
    class Diak
    {
        public string nev { get; set; }
        public List<int> jegyek { get; set; }
    }
    class munkavallalo
    {
        public string nev { get; set; }
        public int fizetes { get; set; }
        public bool jogositvany { get; set; }
        public string munkarend { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            String fajl = File.ReadAllText("C:\\Users\\bakilv\\source\\repos\\JSONcrack\\JSONcrack\\adatok.json", System.Text.Encoding.Latin1);
            Adat adat = JsonSerializer.Deserialize<Adat>(fajl);


            foreach (var nev1 in adat.nevek)
            {
                Console.WriteLine(nev1);
            }
            Console.WriteLine($"{adat.nevek[0]} életkor:{adat.korok[0]}");
            String fajl2 = File.ReadAllText("C:\\Users\\bakilv\\source\\repos\\JSONcrack\\JSONcrack\\diakok.json", System.Text.Encoding.Latin1);
            Console.WriteLine(fajl2);
            List<Diak> diakok = JsonSerializer.Deserialize<List<Diak>>(fajl2);
            bool megvan = false;
            Console.Write("Keresett név:");
            String nev = Console.ReadLine();
            foreach (var diak in diakok)
            {
                if (diak.nev == nev)
                {
                    Console.WriteLine("Átlaga" + diak.jegyek.Average());
                    megvan = true;
                }
            }
            if(megvan==false)
            {
                Console.WriteLine("Nincs ilyen nevű diák");
            }
            String fajl3 = File.ReadAllText("C:\\Users\\bakilv\\source\\repos\\JSONcrack\\JSONcrack\\adatok.json", System.Text.Encoding.Latin1);
            munkavallalo munkavallalok = JsonSerializer.Deserialize<munkavallalo>(fajl3);

            munkavallalo szemely = new munkavallalo("Szabó Júlia", 380000, false,"10:00-18:00");
        }
    }
}
