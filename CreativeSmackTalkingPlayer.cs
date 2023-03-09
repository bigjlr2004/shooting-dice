using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        List<string> Taunt = new List<string>()
        {
            "here comes the heat!", "you smell like stinky cheese", "your mom doesn't even love you"
        };

        public override void Play(Player other)
        {

            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Random randomNumberGenerator = new Random();

            string taunt = Taunt[randomNumberGenerator.Next(0, Taunt.Count)];
            // COULD ALSO BE: string taunt = Taunt[randomNumberGenerator.Next(0, 3)];


            Console.WriteLine($"{Name} says {taunt}");
            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");



            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
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

/* 

create a List of Taunts
create a random int and go through the index of a list of taunts

 Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();


*/