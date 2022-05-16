using CountCharsBonanza;

class Program
{
    public static void Main(string[] args)
    {
        var betterPerson = new BetterPerson("A", 1900);
        betterPerson.Show();
        Console.WriteLine(betterPerson.Name);
        //betterPerson.Name = "gfjh";
        /*
         let person = {
            name: 'Terje',
            birthYear: 1975,
         }
        */
        var person1 = new Person(
            "Terje", 1975);
        var person3 = new Person()
        {
            Name = "Per",
            BirthYear = 1979,
            IsTeacher = true
        };
        person1.Show();
        person3.Show();
        return;

        /*
         let person = {};
         person.name = 'Terje';
         person.birthYear = 1975;
         */
        var person2 = new Person();
        person2.Name = "Terje";
        //person2.BirthYear = 1975;
        person2.IsTeacher = true;

        /*
        let people = [
         {
            name: 'Terje',
            birthYear: 1975,
         },
         {
            name: 'Per',
            birthYear: 1980,
         },
        ];
         */
        Person[] people1 = new Person[2];
        people1[0] = new Person()
        {
            Name = "Terje",
            BirthYear = 1975,
        };
        people1[1] = new Person()
        {
            Name = "Per",
            BirthYear = 1980,
        };

        var people2 = new Person[]
        {
            new Person()
            {
                Name = "Terje",
                BirthYear = 1975,
            },
            new Person()
            {
                Name = "Per",
                BirthYear = 1980,
            },
        };

        /*
         const model = {
            inputs: {
                newPersonPage: {
                    field1: 5,
                    field2: "dfkshgfshjg",
                }
            },

            people: [
             {
                name: 'Terje',
                birthYear: 1975,
             },
             {
                name: 'Per',
                birthYear: 1980,
             },
            ]
         };
         */

        var model2 = new Model(
            new Inputs(new NewPersonPage("dfkshgfshjg", 5)),
            new Person[]
            {
                new Person("Terje", 1975),
                new Person("Per", 1980),
            });

        var model = new Model
        {
            Inputs = new Inputs
            {
                NewPersonPage = new NewPersonPage
                {
                    Field1 = "dfkshgfshjg",
                    Field2 = 5,
                }
            },
            People = new Person[]
            {
                new Person()
                {
                    Name = "Terje",
                    BirthYear = 1975,
                },
                new Person()
                {
                    Name = "Per",
                    BirthYear = 1980,
                },
            }
        };


        // Demo1();
    }

    public static void Demo1()
    {
        var counts = new int[250];

        string text = "something";
        while (!string.IsNullOrWhiteSpace(text))
        {
            text = Console.ReadLine();
            CountChars(text, counts);
            ShowStats(counts);
        }
    }

    private static void CountChars(string? text, int[] counts)
    {
        foreach (var character in text ?? string.Empty)
        {
            counts[(int)character]++;
        }
    }

    private static void ShowStats(int[] counts)
    {
        for (var i = 0; i < counts.Length; i++)
        {
            if (counts[i] > 0)
            {
                var character = (char)i;
                Console.WriteLine(character + " - " + counts[i]);
            }
        }
    }
}