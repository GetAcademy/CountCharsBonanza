namespace CountCharsBonanza
{
    internal class Model
    {
        public Inputs Inputs;
        public Person[] People;

        public Model(Inputs inputs, Person[] people)
        {
            Inputs = inputs;
            People = people;
        }

        public Model()
        {
            
        }
    }
}
