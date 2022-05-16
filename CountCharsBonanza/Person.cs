namespace CountCharsBonanza
{
    internal class Person
    {
        public string Name;
        public int BirthYear;
        public bool IsTeacher;

        public Person(string name, int birthYear)
        {
            Name = name;
            BirthYear = birthYear;
            IsTeacher = false;
        }

        public Person()
        {

        }


        public void Show()
        {
            Console.WriteLine($"Navn: {Name} Fødselsår: {BirthYear}");
        }
    }
}
