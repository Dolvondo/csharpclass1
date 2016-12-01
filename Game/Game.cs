using System;

public class Game {
    //Variables:
    string playerInput;
    //Identifiers:
    statistics status = new statistics();
    public static void GameTimer()
    {
        System.Threading.Thread.Sleep(2000);
    }
    People People = new People();
    public void menu () {
        Console.WriteLine("::::::Menu::::::");
        Console.WriteLine("Welcome to 'Mr. President'!");
        Console.WriteLine("Please type in the following: play, rules");
        playerInput = Console.ReadLine();
        if (playerInput == "play") {
            Console.WriteLine("::::: Playing Game :::::");
            play();
        }
        if (playerInput == "rules") {
            Console.WriteLine(":::::Rules:::::");
            Console.WriteLine("You are a President in charge of a small village, your primary goal is to raise the population, keep your citizens happy, and raise money. You will win if your population reaches 1000, otherwise you lose.");
            GameTimer();
            menu();
        }
    }

    public void play() {
        
        status.population = 100;
        status.happiness = 100;
        status.currency = 100;
        status.stage = 0;
        stageLevel();
    }
       public void stageLevel () {
           switch (status.stage) {
               case 0:
                    //Data of name, name of land and country
                    Console.WriteLine("Please enter your name:");
                    status.name = Console.ReadLine();
                    Console.WriteLine("Please enter the name of your sacred land:");
                    status.landname = Console.ReadLine();
                    Console.WriteLine("Please enter the name of your country:");
                    status.countryname = Console.ReadLine();
                    
                    //Story Begins
                    Console.WriteLine("*************************************************************");
                    Console.WriteLine("In the Land of " + status.landname + " you rule as president over your country " + status.countryname + ". A blonde beautiful women walks into your chamber room");
                    Console.WriteLine("Ms. Grace:: Ehm, hello " + status.name + " my name is Ms. Grace, I am your assistant remember? Anyways, I am assigned as your permanant assistant as you rule " + status.countryname);
                    Console.WriteLine("Ms. Grace:: Ruling the world is quite easy, all you need to do is type 'y' for yes, and 'n' for no to people who ask you questions, understand?");
                    playerInput = Console.ReadLine();
                    if (playerInput == "n") {
                        Console.WriteLine("Ms. Grace:: Ha ha, very funny, now it's time to go to work theres a long line behind these doors.");
                    }
                    if (playerInput == "y") {
                        Console.WriteLine("Ms. Grace:: I always knew you were a great leader. Now there are several citizens awaiting your judgement.");
                    }
                    Console.WriteLine("Ms. Grace:: Oh silly me! I almost forgot! You always start with " + status.population + " population in your country, and " + status.happiness + " happiness, and " + status.currency + " currency.");
                    Console.WriteLine("If you ever need to know the status it will always appear after each question. Okay, now I will open the door for our guests");
                    Console.WriteLine("* Ms. Grace opens the door*");
                    status.stage = 1;
                    stageLevel();
               break;   
               case 1:
                    Console.WriteLine("***********************************************************************************************************");
                    Console.WriteLine("A citizen approaches and stands before you"); //Log
                    Console.WriteLine("Population: " + status.population + " ||| Happiness: " + status.happiness + " ||| Currency: " + status.currency);
                    People.pickAProblem();
                    playerInput = Console.ReadLine();
                    if (playerInput == "y") {
                        status.population += People.YP;
                        status.happiness += People.YH;
                        status.currency += People.YC;
                        Console.WriteLine(People.postiveResponse);
                        Console.WriteLine("Population: " + People.YP);
                        Console.WriteLine("Happiness: " + People.YH);
                        Console.WriteLine("Currency: " + People.YC);
                    //------ Activates story mode in certain cases----
                        switch (People.pickproblem) {
                            case 5:
                            while (People.exploration == false) {People.exploration = true;}
                            break;
                            case 6:
                            while (People.expansion == false) {People.expansion = true;}
                            break;
                        }
                    
                    }
                    if (playerInput == "n") {
                        status.population += People.NP;
                        status.happiness += People.NH;
                        status.currency += People.NC;
                        Console.WriteLine(People.negativeResponse);
                        Console.WriteLine("Population: " + People.NP);
                        Console.WriteLine("Happiness: " + People.NH);
                        Console.WriteLine("Currency: " + People.NC);
                        switch (People.pickproblem) {
                           case 5:
                           break;
                        }
                    
                    
                    }
                    GameTimer();
                    stageLevel();
                    //NEXT : Im going to add a time clock that haves the days cycle by. 
               break;
               case 2:

               break;
               case 3:

               break;
               case 4:

               break;
               case 5:

               break;
               case 6:

               break;
               case 7:

               break;


           }
       } 


}
