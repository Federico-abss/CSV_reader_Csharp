using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calcolo_Area;

namespace Prova_Pratica
{    public struct Forma
    {
        public string nome;
        public Int32 lato_base;
        public Int32 altezza;
    }
    class Program
    {
        static void Main(string[] args)
        {
            const string filename = @"C:\Users\corso6\Desktop\Prova Pratica\Prova Pratica.txt";
            bool esiste = File.Exists(filename);
            if (esiste)
            {
                List<Forma> forme = new List<Forma>();
                string[] array = File.ReadAllLines(filename);

                for (int i = 1; i < array.Length; ++i)
                {
                    var s = array[i];
                    var record = s.Split(";");
                    var nome = record[0];
                    var lato_base = record[1];
                    var altezza = record[2];

                    var forma = new Forma
                    {
                        nome = nome,
                        lato_base = Convert.ToInt32(lato_base),
                        altezza = Convert.ToInt32(altezza)
                    };
                    forme.Add(forma);                    
                }

                Calcolo calcolo = new Calcolo();

                foreach (var forma in forme)
                {                   
                    Int32 Area = calcolo.Area(forma.nome, forma.lato_base, forma.altezza);
                    Console.WriteLine($"L'area del {forma.nome} è {Area}");
                }
            }
            else
            {
                Console.WriteLine("Dati non trovati");
            }
        }
    }
}
