using System;

namespace player
{
    public class Score
    {
        public event Action ScoreChange = () => { };
        // - spent by taking pro-environmental actions i.e. riding a bicycle (each time minus 1)
        // - recharges over time, with login, performing same actions, watching env. videos, purchasing it for money
        // - Max: 10.
        private int _greenEnergy;

        // - percentage score
        // - affected by fulfilling/non-fulfilling wants
        // - Decrease with low Earth's health
        private int _happiness = 100;

        // - Player experience score
        // - Increases with each action and login
        // - One of the conditions for level up
        private int _stars;

        // - earned every time you log in, do an investment, do a real-life activity
        // - spent on shopping
        private int _money;

        public int greenEnergy
        {
            get { return _greenEnergy; }
            set
            {
                if (value > 10)
                    value = 10;

                _greenEnergy = value;
                ScoreChange();
            }
        }

        public int happiness
        {
            get { return _happiness; }
            set
            {
                if (value < 0)
                    value = 0;

                if (value > 100)
                    value = 100;

                _happiness = value;
                ScoreChange();
            }
        }

        public int stars
        {
            get { return _stars; }
            set
            {
                _stars = value;
                ScoreChange();
            }
        }

        public int money
        {
            get { return _money; }
            set
            {
                _money = value;
                ScoreChange();
            }
        }
    }
}