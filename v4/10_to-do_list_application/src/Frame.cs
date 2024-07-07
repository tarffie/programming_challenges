class Frame
{
    public void say_hi() 
    {
        Console.Write("hello from Frame class!\n");
    }
    // ASCII => console 
    public void Draw()
    {
        Console.Clear();
        //  | Title | Status | Created on | Completed on | // 
        Console.Write(" //  ");
        Console.Write("  |  Title  |");
        Console.Write("  Status  |");
        Console.Write("  Created on  |");
        Console.Write("  Completed on  |");
        Console.Write("\n");
    }
}

