using DesignPatterns.UI.Command.FX;

namespace DesignPatterns.UI.Command
{
    public class Demo
    {
        public void Main()
        {
            var service = new CustomerService();
            var command = new AddCustomerCommand(service);

            var button = new Button(command);

            button.Click();
        }
    }
}