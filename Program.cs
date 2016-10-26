
using System;
public class Program
{   
    
    public static Game myGame = new Game(); //Made this into an instance which is an object
    public static void Main(string[] args)
    {
        Console.WriteLine("Please type in your name");
        myGame.name = Console.ReadLine();
        Console.WriteLine("Your Player name is " + myGame.name);
        myGame.Start();
    }
}
