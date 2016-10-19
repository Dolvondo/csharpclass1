using System;
public class PowerUp {
    public int power = 10;
    public float duration = 2;

    public void RunPowerUp () {
        Console.WriteLine ("Powerup ran");
    }

    public void RechargePowerUp (int _power) {
        power += _power;
        Console.WriteLine("Recharged PowerUp to" + power);
    }
}