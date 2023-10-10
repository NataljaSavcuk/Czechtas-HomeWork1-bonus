using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Reflection;
using System.Threading.Tasks;
namespace HomeWork_bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vypiš zadaný počet schodů(řádků) podle uvedeného příkladu.
            //Napiš program tak, aby uživatel mohl zadat počet schodů, které se mají vypsat.

            Console.WriteLine("Schody!");
            Console.WriteLine("Zadej pocet schodu");
            int pocetSchodu;
            //overeni ze pocet schodu je cele kladne cislo
            while (!int.TryParse(Console.ReadLine(), out pocetSchodu) || pocetSchodu <= 0)
            {
                Console.WriteLine("Neplatne zadani. Zadejte kladne cele cislo: ");
            }

           //vypsani schodu
            for (int i = 1; i < pocetSchodu+1; i++)
            {
                int mezera = 0; //pocet mezer
                int schod = 0; //pocet #
                while (mezera != pocetSchodu-i)
                {
                    Console.Write(" ");
                    mezera++;
                }
                while (schod != i)
                {
                    Console.Write("#");
                    schod++;
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            //Minimální a maximální součet n - 1 prvků
            Console.WriteLine("Minimální a maximální součet n-1 prvků");
            Console.WriteLine();
            Console.WriteLine("Zadej pocet prvku");
            int pocetPrvku;
            //overeni ze pocet prvku je cele kladne cislo
            while (!int.TryParse(Console.ReadLine(), out pocetPrvku) || pocetPrvku <= 0)
            {
                Console.WriteLine("Neplatne zadani. Zadejte kladne cele cislo: ");
            }
            int[] zkusebniRada = new int[pocetPrvku];
            var rand = new Random();
           
            for (int i = 0; i < pocetPrvku; i++)
            {
                zkusebniRada[i] = rand.Next(0-100,100);
                Console.Write(zkusebniRada[i] + ", "); //generace nahodneho cisla od -100 do 100 pro jednoduche overeni
            }
            Console.WriteLine();
            //serazeni prvku pole od nejvetsiho po nejmensi. 
            //Asi to nebude to reseni, ktere se tady cekalo,
            //ale pro toto zadani to funguje. Budeme hledat soucet nejvetsch cisel a soucet nejmensch cisel.
            int temp = 0;
            for (int i = 0; i < zkusebniRada.Length; i++)
            {
                for (int j = i + 1; j < zkusebniRada.Length; j++)
                {
                    if (zkusebniRada[i] > zkusebniRada[j])
                    {
                        temp = zkusebniRada[i];
                        zkusebniRada[i] = zkusebniRada[j];
                        zkusebniRada[j] = temp;
                    }
                }
            }
            int nejvetsiCislo = 0;
            int nejmensiCislo = 0;
            for (int i = 1; i < zkusebniRada.Length; i++)
            {
                nejvetsiCislo += zkusebniRada[i];
                nejmensiCislo += zkusebniRada[i - 1];
            }
            Console.WriteLine("Nejvetsi soucet rady: " + nejvetsiCislo);
            Console.WriteLine("Nejmensi soucet rady: " + nejmensiCislo);

            Console.ReadLine();
        }
    }
}