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
public static int pickproblem;
//Story based variables
public static bool exploration = false;
public static bool expansion = false;
//-------
int numberofproblems = 6;
statistics status = new statistics();
Game Game = new Game();

public void pickAProblem() {
    Random rnd = new Random();
pickproblem = rnd.Next(1, numberofproblems + 1 );
  
 Console.WriteLine(pickproblem); // Log
    switch (pickproblem) {
        case 1:
        Console.WriteLine("George: Can I have some money please?");
          if (Game.playerInput == "y") {
            Response(0, 1, -3);
            postiveResponse = "Tanks bro! I could always count on ya! *Walks out delighted*";
          }    
          if (Game.playerInput == "n") {
            Response(0,-1,0);
            negativeResponse = "Aw come on man! It was just a small amount. Whatever Im out of here! *Stomps out of the door*";
          }
          
          
        break;
        case 2:
        Console.WriteLine("Sir AsksALot: There are refugees who wish to join our city, should we allow them?");
          if (Game.playerInput == "y") {
            Response(5, 0, 0);
            postiveResponse = "Great, these people will love the good news! *Walks out delighted*";
          }    
          if (Game.playerInput == "n") {
            Response(0,0,0);
            negativeResponse = "I always trust your judgement sir. *Leaves*";
          }
          
          
        break;
        case 3:
          Console.WriteLine("Soldier: There are Indians that are scaring our people, should we attack them?");
          if (Game.playerInput == "y") {
            Response(-3, 0, 0);
            postiveResponse = "*Leaves and comes back* We've chased them away, however they've killed a few of us in the endeavour";
          }    
          if (Game.playerInput == "n") {
            Response(0,1,10);
            negativeResponse = "*Leaves and comes back* Good call sir, turns out these indians were friendly and gave us some goodies!";
          }
          
          
        break;
        case 4:
          Console.WriteLine("Soldier: There are Indians that are scaring our people, should we attack them?");
          if (Game.playerInput == "y") {
            Response(0, 1, 10);
            postiveResponse = "*Leaves and comes back* Our attack was successful! We've collected spoils of war!";
          }    
          if (Game.playerInput == "n") {
            Response(-5,0,-10);
            negativeResponse = "*Leaves and comes back* The Indians killed off some of our farmers and robbed us!";
          }
        break;
        case 5:
            if (exploration == false) {
            Console.WriteLine("Explorer: My lord, I wish to go exploring in your name, may I go?" );
          if (Game.playerInput == "y") {
            Response(-1, 0, 0);
            postiveResponse = "I wont let you down sir!";
          }    
          if (Game.playerInput == "n") {
            Response(0,0,0);
            negativeResponse = "Aww whats the harm sir? *Leaves*";
          }
          
          } else {
            Console.WriteLine("Explorer: I've come back and found riches! Would you like some sir?");
          if (Game.playerInput == "y") {
            Response(0, 0, 100);
            postiveResponse = "I can't wait to tell the people my story! *Leaves*";
          }    
          if (Game.playerInput == "n") {
            Response(0,0,0);
            negativeResponse = "Okay then... *Walks out confused*";  
          }
          exploration = false;
          }
        break;
        case 6:
          if (expansion == false) {
          Console.WriteLine("Builder Bob: Hey buddy, I think we should expand the city, it'll cost a bit, what do ya say?");
          if (Game.playerInput == "y") {
            Response(0, 0, -30);
            postiveResponse = "Alright! Let's get to work!";
          }    
          if (Game.playerInput == "n") {
            Response(0,0,0);
            negativeResponse = "What ever you say, *exits*";
          }
          
          
          } else {
          Console.WriteLine("Builder Bob: Alright bub, the borders been expanded, and some peeps wanna move in.");
          if (Game.playerInput == "y") {
            Response(20, 0, 0);
            postiveResponse = "Enjoy your day sir.";
          }    
          if (Game.playerInput == "n") {
            Response(0,0,0);
            negativeResponse = "What ever you say, *exits*";
          }
          
          expansion = false;
          }
        break;
        case 7:
            Console.WriteLine("Magician: Hello there Prez, I can do magical things, care to give it I try?");
          if (Game.playerInput == "y") {
            Response(0, 5, 100);
            postiveResponse = "Looks like fortune smiles upon you sir!";
          }    
          if (Game.playerInput == "n") {
            Response(0,0,0);
            negativeResponse = "Aww... was it something I said?";
          }
          
          
        break;
        case 8:
        Console.WriteLine("Magician: Hello there Prez, I can do magical things, care to give it I try?");
          if (Game.playerInput == "y") {
            Response(0, 0, 0);
            postiveResponse = "OH MY GOSH! I messed up! SORRY SIR... I'll practice more *runs away*";
          }    
          if (Game.playerInput == "n") {
            Response(0,-5,-100);
            negativeResponse = "Aww... was it something I said?";
          }
          
        break;
              
       
    }
    //Function with parameters
    public void Response (int pop, int hap, int cur) {
        status.population += pop;
        status.happiness += hap;
        status.currency += cur;
        Console.WriteLine("Population: " + pop);
        Console.WriteLine("Happiness: " + hap);
        Console.WriteLine("Currency: " + cur);
        pickAProblem();
}

}



}