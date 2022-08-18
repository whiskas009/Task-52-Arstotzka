using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_52_Arstotzka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Prisoner> prisoners = new List<Prisoner>() {new Prisoner("Иван", "Коррпуция"),
                                                             new Prisoner("Артём", "Вандализм"),
                                                             new Prisoner("Денис", "Антиправительственное"),
                                                             new Prisoner("Макс", "Шпионаж"),
                                                             new Prisoner("Иван", "Антиправительственное"), };

            Console.WriteLine("Старый список: ");

            foreach (Prisoner prisoner in prisoners)
            {
                Console.WriteLine($"Имя: {prisoner.Name}. Преступление: {prisoner.Crime}");
            }

            var selectedPrisoners = from prisoner in prisoners
                                    where prisoner.Crime != "Антиправительственное"
                                    select prisoner;

            prisoners = selectedPrisoners.ToList();

            Console.WriteLine("Новый список: ");

            foreach (Prisoner prisoner in prisoners)
            {
                Console.WriteLine($"Имя: {prisoner.Name}. Преступление: {prisoner.Crime}");
            }
        }
    }

    class Prisoner
    {
        public string Name { get; private set; }
        public string Crime { get; private set; }

        public Prisoner(string name, string crime)
        {
            Name = name;
            Crime = crime;
        }
    }
}
