using System;
public class LevelBase {
    public string StartMessage;
    public bool entranceOpen = true; //bool means its asking if it is true or false
    public string[] environment = {"Cold", "Wet", "Dark", };

    public string[] objects = {"Rocks", "Ravine", "River", "Lava"};

    public void Enter (){
        Console.WriteLine(StartMessage);
    }
    public void Encounter (int i) {
        switch (i)
            {
            case 0:
            Console.WriteLine("You've walked into " + objects[i]);   
            break;
            case 1:
            Console.WriteLine("You've walked into " + objects[i]);   
            break;
            case 2:
            Game.GameTimer();
            Console.WriteLine("You've walked into " + objects[i]);
            Random randomNum = new Random();
            Game.UnderWater.Encounter(randomNum.Next(0, Game.UnderWater.objects.Length));
            break;
            case 3:
            Console.WriteLine("You've walked into " + objects[i]);
            Program.canPlay = false;  
            break;
            Console.WriteLine("You've walked into " + objects[i]);   
            default:
            Console.WriteLine("Your path is clear");
            break;
            }  
                          
    }
}