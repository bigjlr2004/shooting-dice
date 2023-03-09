using System;

namespace ShootingDice
{
    public class SoreLoserPlayerException : Exception
    {
        // constructor that doesnt call a message (can have two constructors bc it doesn't take the s)
        public SoreLoserPlayerException() { }

        public SoreLoserPlayerException(string message)
         : base(String.Format(message))
        {

        }
    }
}