using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {

        public override void Play(Player other)
        {

            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            Console.WriteLine($"{Name} rolls a {myRoll}");


            if (myRoll <= otherRoll)
            {
                throw new SoreLoserPlayerException();
            }
            else
            {
                Console.WriteLine($"{Name} Wins!");
            }

        }
    }
}


/*



*/