namespace DesignPatterns.UI.TemplateMethod
{
    public class GenerateReportTask : BaseTask
    {
        public GenerateReportTask(AuditTrail auditTrail)
            : base(auditTrail)
        {
        }

        protected override void DoExecute()
        {
            System.Console.WriteLine("Generate report");
        }
    }
}