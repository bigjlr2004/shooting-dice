using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override void Play(Player other)
        {

            Console.WriteLine("Enter a number for a roll between 1-6");
            int myRoll = int.Parse(Console.ReadLine());

            // Call roll for "this" object and for the "other" object
            int HumanRoll = Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {HumanRoll}");
            if (myRoll > HumanRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < HumanRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }

}
