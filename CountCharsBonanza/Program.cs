class Program
{
    public static void Main(string[] args)
    {
        //Demo1();

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