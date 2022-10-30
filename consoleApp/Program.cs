

internal class Program
{
    private static void Main(string[] args)
    {
        string arg_One = Environment.GetCommandLineArgs()[1];
        string arg_Two = Environment.GetCommandLineArgs()[2];
        Console.WriteLine("\n\nHello From .NET 6!");
        Console.WriteLine("\nCommand Line argument 1  ==  {0}", arg_One);
        Console.WriteLine("\nCommand Line argument 2  ==  {0}\n\n", arg_Two);
    }
}

