namespace Modules;
public static class Commands
{
    public static void Branch(IEnumerable<string> args)
    {
        Console.WriteLine("Branch here");
    }

    public static void Pull(IEnumerable<string> args)
    {
        Console.WriteLine("Pull here");
    }

    public static void Push(IEnumerable<string> args)
    {
        Console.WriteLine("Push here");
    }

    public static void Clone(IEnumerable<string> args)
    {
        Console.WriteLine("Clone here");
    }

    public static void Help(IEnumerable<string> args)
    {
        var helpText = File.ReadAllText(@"./Modules/help.txt");
        Console.WriteLine(helpText);
    }
}