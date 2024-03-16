// See https://aka.ms/new-console-template for more information

internal class Class
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello APBD");
        Console.WriteLine("Modyfikacja 1");
        Console.WriteLine("Modyfikacja 2");
        Console.WriteLine("Modyfikacja 3");

        int[] tab = {1, 2, 3, 4};
        Console.WriteLine(Average(tab));
    }

    public static double Average(int[] tab)
    {
        int sum = 0;

        foreach (var number in tab)
            sum += number;

        return (double)sum / tab.Length;
    }

    public static int Max(int[] tab)
    {
        var result = tab[0];

        foreach (var i in tab)
            if (result < tab[i])
                result = tab[i];

        return result;
    }
}