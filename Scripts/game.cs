
public class Game { //This is the cookie cutter
    public Game() { //"Game" Represents a constructor. This runs when the game class is created.
//Is a function that runs when the instance of an object is created
        Gun.Fire();
    }

    //Access Modifiers
    private WeaponBase Gun = new WeaponBase(); //The object "Gun" is an object created, then telling WeaponBase file to run.
    public string name;
    private int score;
    //-------------


}