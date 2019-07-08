using System;
using System.Collections.Generic;
using System.Threading;


namespace rpsc
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
             string playerSelection;
bool isValidInput;
            Console.Clear();
            
bool running = true;
    
// Speed font used from https://onlineasciitools.com/convert-text-to-ascii-art
// windows size 89x23


    string greeting = @"
___       __    ______                                 ________             ______
__ |     / /_______  /__________________ ________      ___  __ )_____ _________  /__
__ | /| / /_  _ \_  /_  ___/  __ \_  __ `__ \  _ \     __  __  |  __ `/  ___/_  //_/
__ |/ |/ / /  __/  / / /__ / /_/ /  / / / / /  __/     _  /_/ // /_/ // /__ _  ,<   
____/|__/  \___//_/  \___/ \____//_/ /_/ /_/\___/      /_____/ \__,_/ \___/ /_/|_|  

_____            _____________ _____       _________
__  /______      ___  __/__  /____(_)____________  /
_  __/  __ \     __  /  __  __ \_  /__  ___/  __  /
/ /_ / /_/ /     _  /   _  / / /  / _  /   / /_/ /
\__/ \____/      /_/    /_/ /_//_/  /_/    \__,_/

_________             _________    ______   
__  ____/____________ ______  /_______  /
_  / __ __  ___/  __ `/  __  /_  _ \_  /
/ /_/ / _  /   / /_/ // /_/ / /  __//_/
\____/  /_/    \__,_/ \__,_/  \___/(_)

";
for (int i = 0; i < greeting.Length; i++)
{
    Thread.Sleep(5);
    Console.Write(greeting[i]);
}         
Console.WriteLine();
Thread.Sleep(2000);
Console.Clear();
while (running)
{
 string rockline = @"
________            ______  
___  __ \______________  /__
__  /_/ /  __ \  ___/_  //_/
_  _, _// /_/ / /__ _  ,<   
/_/ |_| \____/\___/ /_/|_|  
";
for (int i = 0; i < rockline.Length; i++)
{
    Thread.Sleep(5);
    Console.Write(rockline[i]);
}         
Console.WriteLine();
            string paperline = @"
________                            
___  __ \_____ _____________________
__  /_/ /  __ `/__  __ \  _ \_  ___/
_  ____// /_/ /__  /_/ /  __/  /    
/_/     \__,_/ _  .___/\___//_/     
               /_/                  
";
for (int i = 0; i < paperline.Length; i++)
{
    Thread.Sleep(5);
    Console.Write(paperline[i]);
} 
Console.WriteLine();        
            string scissorline = @"
________     _____                                   
__  ___/________(_)__________________________________
_____ \_  ___/_  /__  ___/_  ___/  __ \_  ___/_  ___/
____/ // /__ _  / _(__  )_(__  )/ /_/ /  /   _(__  ) 
/____/ \___/ /_/  /____/ /____/ \____//_/    /____/  
";
for (int i = 0; i < scissorline.Length; i++)
{
    Thread.Sleep(5);
    Console.Write(scissorline[i]);
}         
Console.WriteLine();


    Console.Write("Your Selection?: ");
     playerSelection = Console.ReadLine().ToLower();
     
isValid();

    Random rnd = new Random();
    int outCome = rnd.Next(1, 3);
    string outComeFinal ="";
    switch(outCome) {
        case 1:
        outComeFinal = "rock";
        break;
        case 2:
        outComeFinal = "paper";
        break;
        case 3:
        outComeFinal = "scissors";
        break;
        default:
        Console.Write("FUCK");
        break;

    }
    
// playerSelection != "rock" || playerSelection != "paper" || playerSelection != "scissors"
while (!isValidInput)
{
  Console.Write("HEY! PLAY BY THE RULES");
   playerSelection = Console.ReadLine().ToLower();
   isValid();
   if(!isValidInput) {
       string responseLine ="WHAT DID I JUST FUCKING SAY!?";
       for (int i = 0; i < responseLine.Length; i++)
       {
           Console.Write(responseLine[i]);
       }
    //    Console.WriteLine();
   } else {
       break;
   }
      playerSelection = Console.ReadLine().ToLower();
      isValid();
 if(!isValidInput) {
       string responseLine ="How about you do as I say or you lose?";
       for (int i = 0; i < responseLine.Length; i++)
       {
           Console.Write(responseLine[i]);
       }
            //   Console.WriteLine();

   }else {
       break;
   }
         playerSelection = Console.ReadLine().ToLower();
         isValid();
    if(!isValidInput) {
       string responseLine = "HA! You thought i was LYING??? Haha well take this you Fucking LOSER!";
       for (int i = 0; i < responseLine.Length; i++)
       {
           Console.Write(responseLine[i]);
       }
              Console.WriteLine();

       string Yeet = "";
       switch (outCome)
       {
           case 1 :
           Yeet = "Scissors";
           break;
           case 2 :
           Yeet = "Rock";
           break;
           case 3 :
           Yeet = "Paper";
           break;
       }
       Console.WriteLine($"You lost! {outComeFinal} beats {Yeet}");
       Thread.Sleep(4000);
       Console.Write("SUCKS TO BE YOU!");
       Thread.Sleep(1000);
       running = false;
       break;
   }else {
       break;
   }
}
if(!running) {
    break;
}
evaluate(playerSelection, outComeFinal);
// int playerSelectionNum;
// switch (playerSelection) {
//     case "rock":
//     playerSelectionNum = 1;
//     break;
//     case "paper" :
//     playerSelectionNum = 2;
//     break;
//     case "scissors" :
//     playerSelectionNum = 3;
//     break;
//     default :
//     Console.WriteLine("invalid");
//     break;
// }
string tryStr = "Try Again? (Y/N):";
Console.WriteLine();
for (int i = 0; i < tryStr.Length; i++)
{
    Thread.Sleep(300);
    Console.Write(tryStr[i]);
}
ConsoleKeyInfo response = Console.ReadKey();
// string tryBool = Console.ReadLine().ToLower();
if(response.KeyChar == 'y') {
    Console.Clear();
} else if(response.KeyChar == 'n') {
    running = false;
    break;
} else if(response.KeyChar != 'n' || response.KeyChar != 'y') {
string fuckStr = "IF YOU WANT TO TRY AGAIN PRESS Y! OTHERWISE PRESS N SO WE BOTH CAN GO ABOUT OUR BUISNESS!!!";
    for (int i = 0; i < fuckStr.Length; i++)
    {
        Thread.Sleep(50);
        Console.Write(fuckStr[i]);
    }
    response = Console.ReadKey();
if(response.KeyChar == 'y') {
    Console.Clear();
} else if(response.KeyChar == 'n') {
    running = false;
    break;
} else if(response.KeyChar != 'n' || response.KeyChar != 'y') {
fuckStr = "FUCKING SHIT!!!!";
for (int i = 0; i < fuckStr.Length; i++)
    {
        Thread.Sleep(50);
        Console.Write(fuckStr[i]);
    }
    Thread.Sleep(500);
    Console.Clear();
}
}
}
void isValid() {
    switch (playerSelection)
    {
        case "rock":
        isValidInput = true;
        break; 
        case "paper":
        isValidInput = true; 
        break;
        case "scissors":
        isValidInput = true; 
        break;
        default:
        isValidInput = false;
        break;
    }
}
           // Dictionary<string> Selection = new Dictionary<string>();   
            // Selection.Add("Rock");
            // Selection.Add("Paper");
            // Selection.Add("Scissors");
         void evaluate(string playerInput, string opponentInput) {
             string defeatBanner = $@"
________     ________           _____     _________
___  __ \_______  __/__________ __  /_    ______/_/
__  / / /  _ \_  /_ _  _ \  __ `/  __/    ____/_/  
_  /_/ //  __/  __/ /  __/ /_/ // /_   _____/_/    
/_____/ \___//_/    \___/\__,_/ \__/   _( )_/      
                                       _|/         
            {opponentInput} beats {playerInput}
            ";
            string victoryBanner = $@"
___    ______      _____                          _________
__ |  / /__(_)_______  /__________________  __    ______/_/
__ | / /__  /_  ___/  __/  __ \_  ___/_  / / /    ____/_/  
__ |/ / _  / / /__ / /_ / /_/ /  /   _  /_/ /  _____/_/    
_____/  /_/  \___/ \__/ \____//_/    _\__, /   _( )_/      
                                     /____/    _|/         
            {playerInput} beats {opponentInput}
            ";
            string tieBanner = $@"
____________           _________
___  __/__(_)____      ______/_/
__  /  __  /_  _ \     ____/_/  
_  /   _  / /  __/  _____/_/    
/_/    /_/  \___/   _( )_/      
                    _|/         
You both chose {playerInput}
";


            if(playerInput == opponentInput){
                Console.Clear();
            for (int i = 0; i < tieBanner.Length; i++)
            {
                Thread.Sleep(1);
                Console.Write(tieBanner[i]);
            }
            Console.WriteLine();
            } 
            else if (playerInput == "rock" && opponentInput == "paper") {
                Console.Clear();
            for (int i = 0; i < defeatBanner.Length; i++)
            {
                Thread.Sleep(1);
                Console.Write(defeatBanner[i]);
            }
            Console.WriteLine();
            } 
            else if (playerInput == "paper" && opponentInput == "scissors") {
                Console.Clear();
            for (int i = 0; i < defeatBanner.Length; i++)
            {
                Thread.Sleep(1);
                Console.Write(defeatBanner[i]);
            }
            Console.WriteLine();
            } 
            else if (playerInput == "scissors" && opponentInput == "rock") {
                Console.Clear();
            for (int i = 0; i < defeatBanner.Length; i++)
            {
                Thread.Sleep(1);
                Console.Write(defeatBanner[i]);
            }
            Console.WriteLine();
            } 
            else if (playerInput == "rock" && opponentInput == "scissors") {
            Console.Clear();
            for (int i = 0; i < victoryBanner.Length; i++)
            {
                                Thread.Sleep(1);
                Console.Write(victoryBanner[i]);
            }
            Console.WriteLine();
            } 
            else if (playerInput == "paper" && opponentInput == "rock") {
            Console.Clear();
            for (int i = 0; i < victoryBanner.Length; i++)
            {
                                Thread.Sleep(1);
                Console.Write(victoryBanner[i]);
            }
            Console.WriteLine();
            } 
            else if (playerInput == "scissors" && opponentInput == "paper") {
            Console.Clear();
            for (int i = 0; i < victoryBanner.Length; i++)
            {
                                Thread.Sleep(1);
                Console.Write(victoryBanner[i]);
            }
            Console.WriteLine();
            }
        }
            Console.Clear();
        }
        
    }
}
