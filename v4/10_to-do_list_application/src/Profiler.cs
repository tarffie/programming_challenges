// using Newtonsoft.Json;
// using Newtonsoft.Json.Serialization;
// using Newtonsoft.Json.Linq;
// using System.IO;
using System.Text.Json;
namespace Quest_List
{
    class Profiler // will handle all profile/software with user interaction 
    {
	private readonly string _filepath;

	private readonly JsonSerializerOptions _options = new()
	{
	    PropertyNameCaseInsensitive = true,
	    IncludeFields = true
	};

	public Profiler(string filepath) {
	    _filepath = filepath;
	}
	public List<Task> GetProfile() // this stuff will write in the file all the info we need to work 
	{
	    // If profile doesn't exist that's a problem, we should create one. 
	    if (!File.Exists(_filepath))
	    {
		FileStream fs = File.Create(_filepath);
		fs.Close();
	    }
	    var json = File.ReadAllText(_filepath);
	    Console.Write(json);
	    List<Task> tasks = JsonSerializer.Deserialize<List<Task>>(json, _options);
	    Environment.Exit(69);
	    return tasks;
	}
	public void NewTask(string title)
	{
	    List<Task> tasks = GetProfile(); // Object reference not set to an instance of an object. 
	    Console.Write(tasks);
	    // now we serialize the tasks again 
	}
	public void RemoveTask() 
	{
	}
	public void UpgradeTask() 
	{
	}
	public void ListTasks()
	{
	    // var tasks = getProfile();
	    // foreach(var task in tasks) {
	    // 	Console.WriteLine(task);
	    // }
	    Console.WriteLine("argumento foda!");
	}
    }
}

