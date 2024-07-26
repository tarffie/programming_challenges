using System.Runtime.InteropServices;
using System.Text;
namespace Quest_List
{
    internal class Program {
	static void Main(String[] args)  // {program} {command}
	{
	    string filepath = @"profile.json";
	    Profiler Profile = new Profiler(filepath);
	    Profile.GetProfile();
	    Environment.Exit(420);
	    bool shouldClose = false;
	    // we're evoking our main_menu
	    Console.Clear();
	    while(!shouldClose)
	    {
		Console.Write("welcome to Quest List, user. Which can we serve you?\n");
		Console.WriteLine("To see possible commands type C and press return");
		// those are the main_menu options 
		var command = Console.ReadKey(true).Key;
		switch(command)
		{
		    case ConsoleKey.N:
			Console.Clear();
			Console.Write("please name your new quest...\n");
			option = Console.ReadLine();
			Profile.NewTask(option);
			break;
		    case ConsoleKey.R :
			Profile.RemoveTask();
			break;
		    case ConsoleKey.U :
			Profile.UpgradeTask();
			break;
		    case ConsoleKey.L :
			Profile.ListTasks();
			break;
		    case ConsoleKey.C:
			Console.Write("'quit' to exit application\t");
			Console.Write("'new' to create a new Task\n");
			Console.Write("'remove' to remove existing Task\t");
			Console.Write("'update' to update existing Task\n");
			Console.Write("'list' to list existing Task\n");
			break;
		    case ConsoleKey.Q:
			shouldClose = true;
			break;
		}	
		
	    }
	}
    }
}
