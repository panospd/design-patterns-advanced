namespace DesignPatterns.UI.State.Excercise.TravelModes
{
    public class DrvingMode : ITravelMode
    {
        public int GetDirection()
        {
            System.Console.WriteLine("Calculating Direction (driving)");
            return 1;
        }

        public int GetEta()
        {
            System.Console.WriteLine("Calculating ETA (driving)");
            return 1;
        }
    }
}