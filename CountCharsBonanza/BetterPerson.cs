using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountCharsBonanza
{
    internal class BetterPerson
    {
        public string Name { get; private set; }
        private int BirthYear;
        private bool IsTeacher;

        public BetterPerson(string name, int birthYear)
        {
            Name = name;
            BirthYear = birthYear;
            IsTeacher = false;
        }

        public void Show()
        {
            Console.WriteLine($"Navn: {Name} Fødselsår: {BirthYear}");
        }
    }
}
