namespace DesignPatterns.UI.State.Excercise.TravelModes
{
    public class Cycling : ITravelMode
    {
        public int GetDirection()
        {
            System.Console.WriteLine("Calculating Direction (bicycling)");
            return 2;
        }

        public int GetEta()
        {
            System.Console.WriteLine("Calculating ETA (bicycling)");
            return 2;
        }
    }
}