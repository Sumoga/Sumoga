namespace card
{
    public abstract class Card
    {
        // each Card object requires a unique identifier
        public string Id;

        // each Card requires a human readable name and description to allow
        // player identify how to solve this need.
        public abstract string Name { get; }
        public abstract string Description { get; }

        protected Card()
        {
            // TODO construct a method to assign random IDs to game entities
            Id = "";
        }

        protected Card(string id)
        {
            Id = id;
        }

        public abstract bool Solve();

        public override string ToString()
        {
            return Name;
        }
    }
}