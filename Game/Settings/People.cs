using System;
public class People {
public static int YP; // Yes that effects population
public static int NP; // no that effects population
public static int YH; // yes that effects happiness
public static int NH; // No that effects happiness
public static int YC; // Yes that effects Currency
public static int NC; // No that effects Currency
public static string negativeResponse;
public static string postiveResponse;

int numberofproblems = 3;

public void pickAProblem() {
    Random rnd = new Random();
int pickproblem = rnd.Next(1, numberofproblems + 1 );
 Console.WriteLine(pickproblem); // Log
    switch (pickproblem) {
        case 1:
        Console.WriteLine("George: Can I have some money please?");
          //Yes    No
          YP = 0; NP = 0; //population
          YH = 1; NH = -1; // happiness
          YC = -3; NC = 0; //Currency

          postiveResponse = "Tanks bro! I could always count on ya! *Walks out delighted*";
          negativeResponse = "Aw come on man! It was just a small amount. Whatever Im out of here! *Stomps out of the door*";

        break;
        case 2:
        Console.WriteLine("Sir AsksALot: There are refugees who wish to join our city, should we allow them?");
          //Yes    No
          YP = 5; NP = 0; //population
          YH = 0; NH = 0; // happiness
          YC = 0; NC = 0; //Currency

          postiveResponse = "Great, these people will love the good news! *Walks out delighted*";
          negativeResponse = "I always trust your judgement sir. *Leaves*";
        break;
        case 3:
           Console.WriteLine("Soldier: There are Indians that are scaring our people, should we attack them?");
          //If Yes   If No
          YP = -3; NP = 0; //population
          YH = 0; NH = 1; // happiness
          YC = 0; NC = 10; //Currency

          postiveResponse = "*Leaves and comes back* We've chased them away, however they've killed a few of us in the endeavour";
          negativeResponse = "*Leaves and comes back* Good call sir, turns out these indians were friendly and gave us some goodies!";
        break;
        case 4: //Same line of Indians scaring people, but saying no will have them attack
        break;

    }


}



}