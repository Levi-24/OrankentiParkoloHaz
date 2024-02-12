using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrankentiParkoloHaz
{
    internal class Emelet
    {
        public int sorszam { get; set; }
        public string emeletNev { get; set; }
        public List<double[]> szektorAdatok { get; set; }

        public Emelet(string r, int sorszam)
        {
            this.sorszam = sorszam;
            var adatok = r.Split(';');
            this.emeletNev = adatok[0].PadRight(10);
            this.szektorAdatok = new List<double[]>();
            for (int i = 0; i < 8; i++)
            {
                double[] temp = new double[19];
                for (int y = 0; y < 19; y++)
                {
                    Random rnd = new Random();
                    temp[y] = rnd.Next(0, 16);
                }
                szektorAdatok.Add(temp);
            }
        }

        public override string ToString()
        {
            string result = $"{sorszam}. {emeletNev}\n";
            int szektorSorszam = 1;
            double ejszaka = szektorAdatok.Select(x => x[18]).Sum();
            foreach (var szektor in szektorAdatok)
            {
                result += $"{szektorSorszam}. Szektor: ";
                foreach (var adat in szektor)
                {
                    result += $"{adat}; ";
                }
                result += "\n";
                szektorSorszam++;
            }
            result += $"Az éjszakára bent maradó autók száma(emeletenként): {ejszaka}";
            return result;
        }
    }
}
