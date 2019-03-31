namespace player
{
    public class Score
    {
        // - spent by taking pro-environmental actions i.e. riding a bicycle (each time minus 1)
        // - recharges over time, with login, performing same actions, watching env. videos, purchasing it for money
        // - Max: 10.
        private int _greenEnergy = 0;

        // - percentage score
        // - affected by fulfilling/non-fulfilling wants
        // - Decrease with low Earth's health
        private int _happiness = 100;

        // - Player experience score
        // - Increases with each action and login
        // - One of the conditions for level up
        public int Stars { get; set; } = 0;

        // - earned every time you log in, do an investment, do a real-life activity
        // - spent on shopping
        public int money { get; set; } = 0;

        public int GreenEnergy
        {
            get { return _greenEnergy; }
            set
            {
                if (value > 10)
                    value = 10;

                _greenEnergy = value;
            }
        }

        public int Happiness
        {
            get { return _happiness; }
            set
            {
                if (value < 0)
                    value = 0;

                if (value > 100)
                    value = 100;

                _happiness = value;
            }
        }
    }
}