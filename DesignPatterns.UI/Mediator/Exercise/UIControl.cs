namespace DesignPatterns.UI.Mediator.Exercise
{
    public abstract class UIControl
    {
        private List<System.Action> _eventHandlers = new();
        
        public void AddEventHandler(System.Action eventhandler)
        {
            _eventHandlers.Add(eventhandler);
        }

        public void InvokeHandlers()
        {
            _eventHandlers.ForEach(e => e());
        }
    }
}