using DesignPatterns.UI.Command.FX;

namespace DesignPatterns.UI.Command
{
    public class AddCustomerCommand : ICommand
    {
        private CustomerService _service;

        public AddCustomerCommand(CustomerService service)
        {
            _service = service;
        }

        public void Execute()
        {
            _service.AddCustomer();
        }
    }
}