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

public void pickAProblem() {
    Random rnd = new Random();
pickproblem = rnd.Next(1, numberofproblems + 1 );

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
        case 4:
          Console.WriteLine("Soldier: There are Indians that are scaring our people, should we attack them?");
          //If Yes   If No
          YP = 0; NP = -5; //population
          YH = 1; NH = 0; // happiness
          YC = 10; NC = -10; //Currency

          postiveResponse = "*Leaves and comes back* Our attack was successful! We've collected spoils of war!";
          negativeResponse = "*Leaves and comes back* The Indians killed off some of our farmers and robbed us!";
        break;
        case 5:
            if (exploration == false) {
            Console.WriteLine("Explorer: My lord, I wish to go exploring in your name, may I go?" );
          //If Yes   If No
          YP = -1; NP = 0; //population
          YH = 0; NH = 0; // happiness
          YC = 0; NC = 0; //Currency
          

          postiveResponse = "I wont let you down sir!";
          negativeResponse = "Aww whats the harm sir? *Leaves*";
          } else {
            Console.WriteLine("Explorer: I've come back and found riches! Would you like some sir?");
          //If Yes   If No
          YP = 0; NP = 0; //population
          YH = 0; NH = 0; // happiness
          YC = 100; NC = 0; //Currency
          

          postiveResponse = "I can't wait to tell the people my story! *Leaves*";
          negativeResponse = "Okay then... *Walks out confused*";  
          exploration = false;
          }
        break;
        case 6:
          if (expansion == false) {
          Console.WriteLine("Builder Bob: Hey buddy, I think we should expand the city, it'll cost a bit, what do ya say?");
          //If Yes   If No
          YP = 0; NP = 0; //population
          YH = 0; NH = 0; // happiness
          YC = -30; NC = 0; //Currency
          

          postiveResponse = "Alright! Let's get to work!";
          negativeResponse = "What ever you say, *exits*";
          } else {
              Console.WriteLine("Builder Bob: Alright bub, the borders been expanded, and some peeps wanna move in.");
          //If Yes   If No
          YP = 20; NP = 0; //population
          YH = 0; NH = 0; // happiness
          YC = 0; NC = 0; //Currency
          

          postiveResponse = "Enjoy your day sir.";
          negativeResponse = "What ever you say, *exits*";
          expansion = false;
          }
        break;
        case 7:
            Console.WriteLine("Magician: Hello there Prez, I can do magical things, care to give it I try?");
          //If Yes   If No
          YP = 0; NP = 0; //population
          YH = 5; NH = 0; // happiness
          YC = 100; NC = 0; //Currency

          postiveResponse = "Looks like fortune smiles upon you sir!";
          negativeResponse = "Aww... was it something I said?";
        break;
        case 8:
        Console.WriteLine("Magician: Hello there Prez, I can do magical things, care to give it I try?");
          //If Yes   If No
          YP = 0; NP = 0; //population
          YH = 0; NH = -5; // happiness
          YC = 0; NC = -100; //Currency

          postiveResponse = "OH MY GOSH! I messed up! SORRY SIR... I'll practice more *runs away*";
          negativeResponse = "Aww... was it something I said?";
        break;
              
       
    }


}



}