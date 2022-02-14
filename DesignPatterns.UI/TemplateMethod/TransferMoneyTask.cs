namespace DesignPatterns.UI.TemplateMethod
{
    public class TransferMoneyTask : BaseTask
    {
        public TransferMoneyTask(AuditTrail auditTrail)
        : base(auditTrail)
        {
        }

        protected override void DoExecute()
        {
            System.Console.WriteLine("Transfer money");
        }
    }
}