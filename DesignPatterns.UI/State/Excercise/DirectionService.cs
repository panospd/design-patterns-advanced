using DesignPatterns.UI.State.Excercise.TravelModes;

namespace DesignPatterns.UI.State.Excercise
{
    public class DirectionService
    {
        public ITravelMode TravelMode { get; set; }

        public DirectionService(ITravelMode travelMode)
        {
            TravelMode = travelMode;
        }

        public int GetEta()
        {
            return TravelMode.GetEta();
        }
        public int GetDirection()
        {
            return TravelMode.GetDirection();
        }
    }
}