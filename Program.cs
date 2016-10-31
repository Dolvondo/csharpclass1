
using System;
public class Program
{   
    
    public static bool canPlay = true;
    public static Game myGame = new Game(); //Made this into an instance which is an object
    public static void Main(string[] args)
    {
        
        myGame.Start();
    }
}
