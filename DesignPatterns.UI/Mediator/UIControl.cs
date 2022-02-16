namespace DesignPatterns.UI.Mediator
{
    public abstract class UIControl
    {
        private List<System.Action> _eventHandlers = new();

        public void Attach(System.Action eventhandler)
        {
            _eventHandlers.Add(eventhandler);
        }

        protected void ExecuteHandlers()
        {
            foreach(var eventhandler in _eventHandlers)
            {
                eventhandler();
            }
        }
    }
};