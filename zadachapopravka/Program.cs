using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadachapopravka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vkarvame
            List<Komputur> ustroistva = new List<Komputur>();
            string file = "UstroistvaInfo.txt";
            Console.Write($"Kolko ustroistva shte vuvedesh?:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Vuvedi ime na ustroistvoto|vid na povredata|suma za remont" +
                "|datata na predavane|imeto na maistora|imeto na klienta");
                var danni = Console.ReadLine().Split().ToArray();
                Komputur komp = new Komputur(danni[0], danni[1], double.Parse(danni[2]), int.Parse(danni[3]), danni[4], danni[5]);
                ustroistva.Add(komp);
            }
            Console.WriteLine("---------------------------------------------------------------");
           //po ime
            Console.Write("Iskash li da namerish dannite za ustroistvo po ime? (da/ne): ");
            string otgv1 = Console.ReadLine().ToLower();
            if (otgv1 == "da")
            {
                Console.Write("Nameri dannite za ustroistvo po ime:");
                string potursi = Console.ReadLine();
                var nameri = ustroistva.Where(x => x.ImeUstroistvo == potursi);
                if (nameri.Any())
                {
                    foreach (var i in nameri)
                    {
                        ((IRemontnaSistema)i).PrintInfo();
                        Console.WriteLine($"Srednata suma za remont e: {i.AvrSum()}");
                    }
                }
                else
                {
                    Console.WriteLine("Nqma takova ustroistvo");
                }
            }
            else
            {
                Console.WriteLine("okei shtom ne iskash");
            }

            Console.WriteLine("---------------------------------------------------------------");
            //staroto
            Console.Write("Iskash li da vidish nai otdavna predadenoto ustroistvo? (da/ne): ");
            string otgv2 = Console.ReadLine().ToLower();
            if (otgv2 == "da")
            {
                Console.WriteLine("Nai-otdavna predadeno ustroistvo:");
                var old = ustroistva.OrderBy(x => x.DataPredavane).First();
                ((IRemontnaSistema)old).PrintInfo();
            }
            else
            {
                Console.WriteLine("okei shtom ne iskash");
            }

            Console.WriteLine("---------------------------------------------------------------");
            //sort suma
            //Console.Write("Iskash li da sortirash po suma za remont? (da/ne): ");
            //string otgv3 = Console.ReadLine().ToLower();

            //if (otgv3 == "da")
            //{
            //   // ustroistva.Sort();
            //    Console.WriteLine("Sortirani ustroistva po suma za remont:");

            //    foreach (var i in ustroistva)
            //    {
            //        ((IRemontnaSistema)i).PrintInfo();
            //        Console.WriteLine("---------------------------------------------------------------");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("okei shtom ne iskash");
            //}
            //file 
            Console.Write("Iskash li da zapishesh inf za ustroistvata v file? (da/ne): ");
            string otgv4 = Console.ReadLine().ToLower();
            if (otgv4 == "da")
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(file, true))
                    {
                        foreach (var i in ustroistva)
                        {
                            writer.WriteLine($"Ime na ustroistvoto: {i.ImeUstroistvo}\n" +
                                             $"Vid povreda: {i.VidPovreda}\n" +
                                             $"Suma za remonta: {i.SumaRemont}\n" +
                                             $"Datata na predavane: {i.DataPredavane}\n" +
                                             $"Imeto na maistora: {i.ImeMaistor}\n" +
                                             $"Imeto na klienta: {i.ImeKlient}");
                            writer.WriteLine("------------------------------");
                        }
                    }
                    Console.WriteLine("Gotovo");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("okei shtom ne iskash");
            }


        }
    }
}
