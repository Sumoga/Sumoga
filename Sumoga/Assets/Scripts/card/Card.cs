using System;

namespace card
{
    [Serializable]
    public class Card
    {
        // each Card requires a human readable name and description to allow
        // player identify how to solve this need.
        public string name;
        public string description;

        // elementary score changes applied on solving this card
        public int solveGreenEnergyChange = 0;
        public int solveHappinessChange = 0;
        public int solveStarsChange = 0;
        public int solveMoneyChange = 0;
        public int solveWorldHealthChange = 0;

        public Card(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public bool Solve()
        {
            return true;
        }

        public override string ToString()
        {
            return name;
        }
    }
}