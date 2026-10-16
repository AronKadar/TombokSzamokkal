namespace TombokSzamokkal
{
    internal class Program
    {
        static int[] tomb = new int[15];
        static Random r = new Random();
        static void TombFeltoltes()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(-20, 21);
            }
            foreach (int item in tomb)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void OsszegzesTetele()
        {
            int osszeg = 0;
            foreach (int item in tomb)
            {
                osszeg += item;
            }
            Console.WriteLine($"A számok osszege {osszeg}");
        }
        static void MegszamlalasTetele()
        {
            int db = 0;
            foreach (int item in tomb)
            {
                if (item < 0)
                {
                    db++;
                }
            }
            Console.WriteLine($"A pozitív számok darabszáma {db}");
        }
        static void Eldontestetele()
        {
            int i = 0;
            while (i < tomb.Length && tomb[i] != 0)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine("Van 0 a tömbben");
            }
            else
            {
                Console.WriteLine("Nincs 0 a tömbben");
            }
        }
        static void Keresestetel()
        {
            int keresett = 0;
            int i = 0;
            while (i < tomb.Length && tomb[i] != keresett)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine($"A retesett szám a(z) {i}. indexen található");
            }
            else
            {
                Console.WriteLine("A keresett szám nincs a tombben.");
            }
        }
        static void Kivalasztastetele()
        {
            tomb[8] = 10;
            int i = 0;
            while (tomb[i] != 10)
            {
                i++;
            }
            Console.WriteLine($"A teresett szám az {i + 1}. helyen talalhato");
        }
        static void Main(string[] args)
        {
            TombFeltoltes();
            OsszegzesTetele();
            MegszamlalasTetele();
            Eldontestetele();
            Keresestetel();
        }
    }
}
