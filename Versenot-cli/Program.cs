using System;
using Modules;

namespace VersenotCLI;
internal class Program
{
    public static readonly string Version = "v0.0.1";
    static void Main(string[] args)
    {
        if(args.Length == 0) 
        {
            Console.WriteLine(Version);
            return;
        }
        
        LookForCommand(args);
    }

    public static void LookForCommand(string[] args)
    {
        switch(args[0].ToLower())
        {
            case "help":
                Commands.Help(args.Skip(1));
                break;
            case "clone":
                Commands.Clone(args.Skip(1));
                break;
            case "push":
                Commands.Push(args.Skip(1));
                break;
            case "pull":
                Commands.Pull(args.Skip(1));
                break;
            case "branch":
                Commands.Branch(args.Skip(1));
                break;
        }
    }
}