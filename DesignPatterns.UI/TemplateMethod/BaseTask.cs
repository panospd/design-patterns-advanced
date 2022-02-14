namespace DesignPatterns.UI.TemplateMethod
{
    public abstract class BaseTask
    {
        private AuditTrail _auditTrail;

        public BaseTask(AuditTrail auditTrail)
        {
            _auditTrail = auditTrail;
        }

        public void Execute()
        {
            _auditTrail.Record();
            DoExecute();
        }

        protected abstract void DoExecute();
    }
}