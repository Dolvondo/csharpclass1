using System;
public class Game { //This is the cookie cutter
    public Game() { //"Game" Represents a constructor. This runs when the game class is created.
//Is a function that runs when the instance of an object is created
        Health.power = 100;
        Health.message = "You are getting stronger.";
        Ammo.message = "You have more ammo.";
     
    }
    public void Start () {
        Health.RunPowerUp();
        /*
        After prompting the game for a name we:
        Enter a cave and find health.
        Meet a dragon. (need an enemy class)
        Pick weapon.
        Battle the dragon.
        If we win: get Health and ammo
        If dragon wins: lose health



        */
    }
    //Game PowerUps
    public PowerUpBase Health = new PowerUpBase();
    public PowerUpBase Ammo = new PowerUpBase();
    //Access Modifiers
    //Game weapons
    private WeaponBase Gun = new WeaponBase(); //The var "Gun" is an object created, then telling WeaponBase file to run. -- The var retrieves its attributes from the WeaponBase class
    private WeaponBase Rifle = new WeaponBase();
    private WeaponBase Knife = new WeaponBase();
    public string name;
    private int score; // Without private, it would default to private.
    //-------------


}