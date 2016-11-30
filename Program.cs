using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Game MyGame = new Game();
            
            
            Console.WriteLine("...Running Game...");
            MyGame.menu();
            
        }
    }
}
