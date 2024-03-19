using System;

namespace labOnePartA
{
    internal class Pythagorean
    {
        static void Main(string[] args)
        {   
            bool isAnsYes; // bool for whether the user wants to enter their name
            string anonAns; // the answer they put whether yes or no or anything else;
            string yourName; // the name we will use for you
            string[] noString = {"n","no"}; // the array to test whether you answered no
            string[] yesString ={"y", "yes"}; // the array to test whehter you answered yes
            int triA; // variable for side a of triangle
            int triB; // variable for side b of triangle
            float triC; // variable for side c of trangle
            int aSq; // variable for a^2 
            int bSq; // variable for b^2 
            int cSq; // variable for c^2 
           
            Console.WriteLine("do you want to enter your name? y/n"); // ask the question
            anonAns = Console.ReadLine(); // your input for whether you want to be anonymous
            anonAns = anonAns.ToLower(); // makes the test lowercase so i don't have to add more answers in the array
            if(anonAns==yesString[0]||anonAns==yesString[1]){ // tests whether your response is yes
              isAnsYes = true; // if response is yes set response bool to true
              Console.WriteLine("thank you for doxxing yourself. :3"); // sends a message to confirm is working and a fun response to your answer
            }
            else if(anonAns==noString[0]||anonAns==noString[1]){ // test whether your response is no
              isAnsYes = false; // if response was no sets response bool to false
              Console.WriteLine("Smart choice, you can never be too safe."); //  gives a visual confirmation that code is working and the user feedback
            }
            else{// failsafe if your response was not one of the for acceptable responses
              isAnsYes = false;//sets response bool to false
              Console.WriteLine("that wasn't an acceptable answer defaulting choice to no.");// confirm code is working give user feedback
            }
            if(isAnsYes==true){// if response bool is true use this code
              Console.WriteLine("what is your name?"); // asks for your name 
              yourName = Console.ReadLine(); // saves your name as a variable
              Console.WriteLine($"{yourName}, {yourName} ... i'll remember that, {yourName}"); // shows that it saves your name
            }
            else{// if response bool is false or somehow blank
              yourName = "Anonymous";// sets your name to Anonymous
              Console.WriteLine("since you didn't dox yourself you be known as Anonymous.");//confirms that this is working and give feedback to user
            }
            
            Console.WriteLine("enter a number for side A");
            
            if(!int.TryParse(Console.ReadLine(), out triA)){ // test if input is an int
                Console.WriteLine("input was not an int. defaulting to 3");
                triA=3; // if input is not an int it defaults to 3
            }

            Console.WriteLine("enter a number for side B");
            if(!int.TryParse(Console.ReadLine(), out triB)){ // test if input is an int
                Console.WriteLine("input was not an int. defaulting to 4");
                triB=4; // if input is not an int it defaults to 4
            }
            aSq = triA * triA; // finds a^2 by multiplying a by itself
            Console.WriteLine($"{triA}^2 = {aSq}");//show that the code is working
            bSq = triB * triB; // finds b^2 by multiplying b by itself
            Console.WriteLine($"{triB}^2 = {bSq}");//shows that the code is working
            cSq = aSq + bSq; // finds c^2 by adding a^2 and b^2 together
            Console.WriteLine($"{aSq} + {bSq} = {cSq}");//shows that the code is working
            triC= (float)Math.Sqrt(cSq); // finds the square root of c^2
            Console.WriteLine($"the square root of {cSq} is {triC}");//shows it did the math code right
            Console.WriteLine($"So, dear {yourName}, the hypotenuse of the triangle is {triC}"); // the triangles c side length 
            Console.WriteLine("beyond this point is for the assignment operators. enter starting number.");
            int assignVar;
            if(!int.TryParse(Console.ReadLine(), out assignVar)){ // test if input is an int
                Console.WriteLine("input was not an int. defaulting to 2");
                assignVar=2; // if input is not an int it defaults to 2
            }
            int prevVar=2; // this variable is only for showing the previous code
           
            Console.WriteLine($"the starting number is {assignVar}");
            while(assignVar < 2048){ // so long as assignVar's value is under 2048 this code will keep going
              prevVar = assignVar;// this will give prevVar the assignVar value
              assignVar *= 2; // this will times assignvar by 2 and give it the new outcome
              Console.WriteLine($"{prevVar} *= 2 ={assignVar}");
            }
        }
    }
}   