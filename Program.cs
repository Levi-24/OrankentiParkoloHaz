using OrankentiParkoloHaz;

List<Emelet> parkoloHaz = new List<Emelet>();
int sorszam = 1;

using (var sr = new StreamReader("../../../src/parkolohaz.txt"))
{
    while (!sr.EndOfStream)
    {
        parkoloHaz.Add(new Emelet(sr.ReadLine(), sorszam));
        sorszam++;
    }
}

foreach (var emelet in parkoloHaz) Console.WriteLine(emelet);