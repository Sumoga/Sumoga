namespace inventory
{
    public enum ItemAttribute
    {
        // TYPE (what action can this item take?)
        Vehicle,
        Container,
        Wearable,

        // PROPERTIES (what will happen as a consequence of this action?)
        PollutesAir,
        PollutesWater,
        DrainsEnergy,
        RestoresHappiness
    }
}