using System;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Dice Game \nIn this game you and a computer Rival will play 10 rounds where you will each roll a 6-sided dice, and the player with the highest dice value will win the round. The player who wins the most rounds wins the game. Good luck! \nPress enter to start...");
        Console.ReadLine();

        int round = 1;
        int rivalWinCount = 0;
        int playerWinCount = 0;
        int rivalScore = 0;
        int playerScore = 0;

        while (round <= 10)
        {
            Console.WriteLine("Round " + round);
        

            EventChanceTime();
        
            if (EventChanceTime() == 1)
            {
                rivalScore++;
            }
            else if (EventChanceTime() == 2)
            {
                rivalScore+=2;
            }
            else if (EventChanceTime() == 3)
            {
                rivalScore+=3;
            }
            else if (EventChanceTime() == 4)
            {
                rivalScore+=4;
            }
            else if (EventChanceTime() == 5)
            {
                rivalScore+=5;
            }
            else if (EventChanceTime() == 6)
            {
                rivalScore+=6;
            }
        
            Console.WriteLine("Rival rolled " + EventChanceTime());

            

            Console.WriteLine("Press enter to roll the dice...");
            Console.ReadLine();

            EventChanceTime();

            if (EventChanceTime() == 1)
            {
                playerScore++;
            }
            else if (EventChanceTime() == 2)
            {
                playerScore+=2;
            }
            else if (EventChanceTime() == 3)
            {
                playerScore+=3;
            }
            else if (EventChanceTime() == 4)
            {
                playerScore+=4;
            }
            else if (EventChanceTime() == 5)
            {
                playerScore+=5;
            }
            else if (EventChanceTime() == 6)
            {
                playerScore+=6;
            }
         
            Console.WriteLine("You rolled " + EventChanceTime());

            if (playerScore < rivalScore)
            {
                Console.WriteLine("You won this round");
                playerWinCount++;
            }
            else if (rivalScore < playerScore)
            {
                Console.WriteLine("The rival won this round");
                rivalWinCount++;
            }
            else if (rivalScore == playerScore)
            {
                Console.WriteLine("This round is a draw!");
            }
        
            Console.WriteLine("The score is now - You : " + playerWinCount + ". Rival : " + rivalWinCount + ".");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            round++;
        }
        
        Console.WriteLine("Game over.\nThe score is now - You : " + playerWinCount + ". Rival : " + rivalWinCount + ".");

        if (playerWinCount < rivalWinCount)
        {
            Console.WriteLine("You won!");
        }
        else if (playerWinCount > rivalWinCount)
        {
            Console.WriteLine("You lost!");
        }
        else if (playerWinCount == rivalWinCount)
        {
            Console.WriteLine("This game is a draw.");
        }
        
        Console.WriteLine("Press enter to exit...");

        Console.Clear();

        Console.WriteLine("Dice Game was closed.");
    }

    public static int EventChanceTime() // number 1 through 6
    {
        Random rand = new Random();

        int NumberGenerated = rand.Next(1, 7);

        return NumberGenerated;
    }
}