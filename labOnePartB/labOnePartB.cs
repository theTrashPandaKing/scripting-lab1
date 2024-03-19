using System;
using System.Runtime.CompilerServices;

namespace unitOnePartB
{
  internal class UnitOneLab
  {
    static void Main(string[] args)
    {
      string[] codeChoice = { "c1", "c2", "ex" };
      string usersChoice;
      bool isExit = false;
      do
      {
        usersChoice="null";
        
        do{
          Console.WriteLine("enter the challenge you want(c1,c2) or exit (ex)");
          Console.WriteLine(" ");
          usersChoice=Console.ReadLine();
          if(usersChoice!=codeChoice[0]&&usersChoice!=codeChoice[1]&&usersChoice!=codeChoice[2]){
            Console.WriteLine("try again");
            Console.WriteLine(" ");
          }
          else{

          }
        }
        while(usersChoice!=codeChoice[0]&&usersChoice!=codeChoice[1]&&usersChoice!=codeChoice[2]);
        if(usersChoice==codeChoice[0]){
        Console.WriteLine("Challenge 1");
        Console.WriteLine(" ");
        int currentWeathTemp;
        int hotWeathCap = 30;
        string[] feedbackMsg = {"Wow that's hot! Be sure to stay hydrated and avoid staying in the sun for too long.",
                             "Such nice weather! Be sure to enjoy it while it lasts.",
                             "W-W-W-Wow i-i-itt's fff-ff-ffreezing! Be sure to stay warm and not get sick."};
        int coldWeathCap = 0;
        bool isRealNum = false;
        int tempTries = 0;
        int attempMsgOne = 9;
        int attempMsgTwo = 9;
        do
        {
          if (tempTries == 0)
          {
            Console.WriteLine("What is the current temperature in celcius?");
          }
          else if (tempTries <= 8)
          {
            Console.WriteLine("I'll ask again, what is the current temperature?");
          }
          else
          {
            Console.WriteLine("How bad are you at typing that it takes more than 9 tries to enter a number?");
          }
          if (!int.TryParse(Console.ReadLine(), out currentWeathTemp))
          {
            if (tempTries == 0)
            {
              Console.WriteLine("That is not a real number!");
            }
            else if (tempTries <= 9)
            {
              Console.WriteLine("Again that is not a real number.");
            }
            else
            {
              Console.WriteLine("...Realy?");
            };
            tempTries += 1;
            isRealNum = false;
          }
          else
          {
            if (tempTries == 0)
            {
              Console.WriteLine($"{currentWeathTemp} Celcius? understood.");
            }
            else if (tempTries <= 9)
            {
              Console.WriteLine($"Now {currentWeathTemp} is a real number");
            }
            else
            {
              Console.WriteLine($"...{currentWeathTemp}.... finally");
            }
            isRealNum = true;
          }
        }
        while (isRealNum == false);
        if (currentWeathTemp > hotWeathCap)
        {
          Console.WriteLine($"{currentWeathTemp} celcious? {feedbackMsg[0]}");
        }
        else if (currentWeathTemp <= coldWeathCap)
        {
          Console.WriteLine($"{currentWeathTemp} celcious? {feedbackMsg[2]}");
        }
        else
        {
          Console.WriteLine($"{currentWeathTemp} celcious? {feedbackMsg[1]}");
        }
        }
        else if(usersChoice==codeChoice[1]){
        Console.WriteLine(" ");
        Console.WriteLine("Challenge 2");
        Console.WriteLine(" ");
        int usersGradePercent;
        bool isRealNumTwo = false;
        do
        {
          Console.WriteLine("enter your percent score 0-100");
          Console.WriteLine(" ");
          if (!int.TryParse(Console.ReadLine(), out usersGradePercent))
          {

            Console.WriteLine("That is not a number. try again.");
            Console.WriteLine(" ");
            isRealNumTwo = false;
          }
          else if (usersGradePercent < 0 || usersGradePercent > 100)
          {

            Console.WriteLine($"{usersGradePercent} is a number. but not a number 0-100. try again.");
            Console.WriteLine(" ");
            isRealNumTwo = false;
          }
          else
          {

            Console.WriteLine($"{usersGradePercent} is a number. And is a number 0-100. good job.");
            Console.WriteLine(" ");
            isRealNumTwo = true;
          }

        }
        while (isRealNumTwo == false);
        if (usersGradePercent <= 100 && usersGradePercent >= 90)
        {
          Console.WriteLine($"So your grade total is {usersGradePercent}%, you get an A.");
          if (usersGradePercent == 100)
          {
            Console.WriteLine("You don't have to do anything else to get better.");
          }
          else
          {
            Console.WriteLine("You don't have much to do to improve your grade percent");
          }

        }
        else if (usersGradePercent <= 89 && usersGradePercent >= 80)
        {
          Console.WriteLine($"So your grade total is {usersGradePercent}, you get a B.");
          Console.WriteLine("You have to do a little work to get an A grade. you can do this.");

        }
        else if (usersGradePercent <= 79 && usersGradePercent >= 70)
        {
          Console.WriteLine($"So your grade total is {usersGradePercent}, you get a C.");
          Console.WriteLine("You have a decent amount of work to do to get a good grade.");

        }
        else if (usersGradePercent <= 69 && usersGradePercent >= 60)
        {
          Console.WriteLine($"So your grade total is {usersGradePercent}, you get a D.");
          Console.WriteLine("You have a lot of work to do get a good grade.");

        }
        else if (usersGradePercent <= 59 && usersGradePercent >= 0)
        {
          Console.WriteLine($"So your grade total is {usersGradePercent}, you get a F.");
          Console.WriteLine("You have a lot of work to do to get even a decent grade.");

        }
        Console.WriteLine(" ");}
      
        else if(usersChoice==codeChoice[2]){
          isExit=true;
        }
      }
      while(isExit==false);
  }
  }
}