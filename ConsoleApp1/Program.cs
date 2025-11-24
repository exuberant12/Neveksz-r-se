using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Deák Csaba");
            list.Add("Kiss István");
            list.Add("nagy István Elemér");
            list.Add("Farkasi Aladár");
            list.Add("Pető@Ilona.hu");
            list.Add("Pisti");
            list.Add("12Elemér");
            list.Add("SzekeresKata");

            while (true)
            {
                Console.Clear();
                Console.WriteLine("0 - Kilépés");
                Console.WriteLine("1 - Összes név listázása");
                Console.WriteLine("2 - Csak betűt tartalmazó nevek listázása");
                Console.WriteLine("3 - Nagybetűvel kezdődő nevek listázása");
                Console.WriteLine("4 - Rövid nevek listázása");
                Console.WriteLine("5 - Nagybetűvel kezdődő nevek ahol a többi kicsi" + "és nem tartalmaz speciális jelet");
                string valasztas = Console.ReadLine();
                switch (valasztas)
                {
                    case "0":
                        return;
                    case "1":
                        Console.Clear();
                        int sorszam = 0;
                        foreach (string nevek in list)
                        {
                            Console.WriteLine($"{sorszam++}. { nevek}");
                        }
                        break;
                    case "2":
                        Console.Clear();
                        sorszam = 0;
                        foreach (string nevek in list)
                        {
                            bool jo = true;
                            foreach (char betu in nevek)
                            { 
                                if (!char.IsLetter(betu) && betu!=' ')
                                    jo = false;
                            } 
                            if(jo)
                                Console.WriteLine($"{sorszam++}. {nevek}");
                        }
                        break;
                    case "3":
                        Console.Clear();
                        int sorszam3 = 0;
                        foreach (var nevek in list.Where(n => !string.IsNullOrWhiteSpace(n) && char.IsUpper(n.TrimStart()[0])))
                        {
                            Console.WriteLine($"{sorszam3++}. {nevek}");
                        }
                        break;
                    case "4":
                        Console.WriteLine("4");
                        break;
                    case "5":
                        Console.WriteLine("5");
                        break;
                    default:    
                        Console.WriteLine("Rossz parancs!");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
