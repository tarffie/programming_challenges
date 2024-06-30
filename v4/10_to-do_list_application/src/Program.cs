namespace ToDo
{
    class Task
    { 
	public string task_title;
	private string task_description;
	private DateTime task_creation;
	private DateTime task_completion;
	
	public Task(string task_title, string task_description)
	{
	    this.task_title = task_title;
	    this.task_description = task_description;
	    this.task_creation = DateTime.Now;
	}
	public void completed()
	{
	    this.task_completion = DateTime.Now;   
	}
    }
    
    internal class Program 
    {
	static void Main(string[] args)
	{
	    Frame fm = new Frame();
	    fm.Draw();
	}
    }
}
